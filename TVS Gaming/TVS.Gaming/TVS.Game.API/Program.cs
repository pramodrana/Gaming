using System.ComponentModel;
using TVS.ApiService.Service.GameAnswer;
using TVS.ApiService.Service.GameCategory;
using TVS.ApiService.Service.GameMode;
using TVS.ApiService.Service.GameProperty;
using TVS.ApiService.Service.GameQuestion;
using TVS.ApiService.Service.GameScore;
using TVS.Factory.Factory.Game;
using TVS.Factory.Factory.GameAnswer;
using TVS.Factory.Factory.GameCategory;
using TVS.Factory.Factory.GameProperty;
using TVS.Factory.Factory.GameScore;
using TVS.Service.Service.Game;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Services
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IGameCategoryService, GameCategoryService>();
builder.Services.AddScoped<IGameQuestionService, GameQuestionService>();
builder.Services.AddScoped<IGameAnswerService, GameAnswerService>();
builder.Services.AddScoped<IGameScoreService, GameScoreService>();
builder.Services.AddScoped<IGamePropertyService, GamePropertyService>();
builder.Services.AddScoped<IGameModeService, GameModeService>();
#endregion

#region Factories
builder.Services.AddScoped<IGameFactory, GameFactory>();
builder.Services.AddScoped<IGameCategoryFactory, GameCategoryFactory>();
//builder.Services.AddScoped<IGameQuestionFactory, GameQuestionFactory>();
builder.Services.AddScoped<IGameAnswerFactory, GameAnswerFactory>();
builder.Services.AddScoped<IGameScoreFactory, GameScoreFactory>();
builder.Services.AddScoped<IGamePropertyFactory, GamePropertyFactory>();
builder.Services.AddScoped<IGameModeFactory, GameModeFactory>();
#endregion

#region Repositories
builder.Services.AddScoped<IGameFactory, GameFactory>();
builder.Services.AddScoped<IGameCategoryFactory, GameCategoryFactory>();
builder.Services.AddScoped<IGameModeFactory, GameModeFactory>();
//builder.Services.AddScoped<IGameQuestionFactory, GameQuestionFactory>();
builder.Services.AddScoped<IGameAnswerFactory, GameAnswerFactory>();
builder.Services.AddScoped<IGameScoreFactory, GameScoreFactory>();
builder.Services.AddScoped<IGamePropertyFactory, GamePropertyFactory>();
#endregion


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
