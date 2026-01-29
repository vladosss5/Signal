using Chat.API.Hubs;
using Chat.Implementation.Extentions;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddSignalR();
services.RegistrationServices(configuration);

var app = builder.Build();

app.MapHub<ChatHub>("/chat");

app.Run();