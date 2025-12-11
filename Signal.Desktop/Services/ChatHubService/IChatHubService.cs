using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace Signal.Desktop.Services.ChatHubService;

public interface IChatHubService
{
    Task ConnectAsync(string hubUrl, CancellationToken cancellationToken = default);
    Task JoinChatAsync(string chatRoom, string userName, CancellationToken cancellationToken = default);
    event Action<string, string> MessageReceived;
    HubConnectionState ConnectionState { get; }
}