// Messenger.Client/Services/SignalR/ChatHubService.cs

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Signal.Desktop.Services.ChatHubService;

public sealed class ChatHubService : IChatHubService
{
    private HubConnection? _hubConnection;
    private readonly ILogger<ChatHubService> _logger;
    
    public event Action<string, string>? MessageReceived;
    public HubConnectionState ConnectionState => _hubConnection?.State ?? HubConnectionState.Disconnected;
    
    public ChatHubService(ILogger<ChatHubService> logger)
    {
        _logger = logger;
    }
    
    public async Task ConnectAsync(string hubUrl, CancellationToken cancellationToken = default)
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl(hubUrl)
            .Build();
        
        _hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            MessageReceived?.Invoke(user, message);
        });
        
        await _hubConnection.StartAsync(cancellationToken);
    }
    
    public async Task JoinChatAsync(string chatRoom, string userName, CancellationToken cancellationToken = default)
    {
        if (_hubConnection == null)
            throw new InvalidOperationException("Hub connection not established");
            
        var userConnection = new { ChatRoom = chatRoom, UserName = userName };
        await _hubConnection.InvokeAsync("JoinChat", userConnection, cancellationToken);
    }
}