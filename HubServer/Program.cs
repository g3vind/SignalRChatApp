using HubServer.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapHub<ChatHub>("/chatHub");

app.Run();
