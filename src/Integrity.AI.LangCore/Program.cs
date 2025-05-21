using Integrity.AI.LangCore.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<LangChainAgent>();
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
