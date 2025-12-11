using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.SignalR.Client;
using Signal.Client.Desktop.Models;

namespace Signal.Client.Desktop.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HubConnection _connection;
    
    private bool CanSendMessage() => _connection.State == HubConnectionState.Connected && !string.IsNullOrWhiteSpace(Message);
    
    [ObservableProperty] private string _login = $"User{Guid.NewGuid().ToString()[..5]}";
    [ObservableProperty] private string _chatRoom = "MainRoom";
    [ObservableProperty] private string _message;
    [ObservableProperty] private string _connectionStatus = "Отключен";

    public ObservableCollection<string> Messages { get; set; } = new();
    

    public MainWindowViewModel()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5146/chat")
            .Build();
        
        _connection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            Dispatcher.UIThread.Post(() =>
            {
                var newMessage = $"{user}: {message}";
                Messages.Add(newMessage);
            });
        });
        
        _connection.Closed += async _ =>
        {
            await Dispatcher.UIThread.InvokeAsync(() => ConnectionStatus = "Отключен (Ошибка)");
        };
    }
    
    [RelayCommand]
    public async Task Connect()
    {
        try
        {
            ConnectionStatus = "Подключение...";
            await _connection.StartAsync();
            
            await _connection.InvokeAsync("JoinChat", new ClientUserConnection 
            {
                UserName = Login,
                ChatRoom = ChatRoom
            });

            ConnectionStatus = $"Подключен к {ChatRoom}";
        }
        catch (Exception ex)
        {
            ConnectionStatus = $"Ошибка подключения: {ex.Message}";
        }
    }

    [RelayCommand]
    public async Task SendMessage()
    {
        if (_connection.State != HubConnectionState.Connected || string.IsNullOrWhiteSpace(Message))
            return;
        
        try
        {
            await _connection.InvokeAsync("Send", Login, Message, ChatRoom);
            
            Message = string.Empty; 
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Ошибка отправки: {ex.Message}");
        }
    }
}