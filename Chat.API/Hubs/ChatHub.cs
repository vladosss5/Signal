using Chat.API.DTOs;
using Chat.API.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace Chat.API.Hubs;

public class ChatHub : Hub<IChatClient>
{
    public async Task JoinChat(UserConnection userConnection)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.ChatRoom);

        await Clients
            .Group(userConnection.ChatRoom)
            .ReceiveMessage("Admin", $"{userConnection.UserName} присоединился");
    }
    
    public async Task Send(string userName, string message, string chatRoom)
    {
        await Clients
            .Group(chatRoom)
            .ReceiveMessage(userName, message);
    }
}