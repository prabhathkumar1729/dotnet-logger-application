using LoggerApp.Loggers;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string ch = builder.Configuration.GetValue<string>("LoggerClass");
switch (ch)
{
    case "file":
        builder.Services.AddScoped<LoggerApp.Loggers.ILogger, FileLogger>();
        break;
    case "db":
        builder.Services.AddScoped<LoggerApp.Loggers.ILogger, DBLogger>();
        break;
    case "console":
        builder.Services.AddScoped<LoggerApp.Loggers.ILogger, ConsoleLogger>();
        break;
}


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
