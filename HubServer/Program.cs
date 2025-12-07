using HubServer.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// CORS
app.UseCors();

// Configure the HTTP request pipeline.
app.MapHub<ChatHub>("/chatHub");

app.Run();
