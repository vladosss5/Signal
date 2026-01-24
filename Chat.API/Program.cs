using Chat.API.Hubs;
using Chat.Implementation.Extentions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.RegistrationDataContext();
builder.Services.RegistrationServices();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapHub<ChatHub>("/chat");
app.MapControllers();

app.Run();