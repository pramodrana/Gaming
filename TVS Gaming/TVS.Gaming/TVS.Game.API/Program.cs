using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Web.Http.Filters;
using TVS.ApiService.Service.GameAnswer;
using TVS.ApiService.Service.GameCategory;
using TVS.ApiService.Service.GameMode;
using TVS.ApiService.Service.GameProperty;
using TVS.ApiService.Service.GameQuestion;
using TVS.ApiService.Service.GameScore;
using TVS.Data.Models;
using TVS.Factory.Factory.Game;
using TVS.Factory.Factory.GameAnswer;
using TVS.Factory.Factory.GameCategory;
using TVS.Factory.Factory.GameProperty;
using TVS.Factory.Factory.GameScore;
using TVS.Game.API.Filters;
using TVS.Repository.Repository.ExceptionLog;
using TVS.Repository.Repository.Game;
using TVS.Repository.Repository.GameAnswer;
using TVS.Repository.Repository.GameCategory;
using TVS.Repository.Repository.GameMode;
using TVS.Repository.Repository.GameProperty;
using TVS.Repository.Repository.GameQuestion;
using TVS.Repository.Repository.GameScore;
using TVS.Service.Service.Game;
using TVS.Service.Services.ExceptionLog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
builder.Services.AddTransient<TVSMAZTCASDBUAT03Context,TVSMAZTCASDBUAT03Context>();
#region Services
builder.Services.AddTransient<IGameService, GameService>();
builder.Services.AddTransient<IGameCategoryService, GameCategoryService>();
builder.Services.AddTransient<IGameQuestionService, GameQuestionService>();
builder.Services.AddTransient<IGameAnswerService, GameAnswerService>();
builder.Services.AddTransient<IGameScoreService, GameScoreService>();
builder.Services.AddTransient<IGamePropertyService, GamePropertyService>();
builder.Services.AddTransient<IGameModeService, GameModeService>();
builder.Services.AddTransient<IExceptionService, ExceptionService>();
#endregion

#region Factories
builder.Services.AddTransient<IGameFactory, GameFactory>();
builder.Services.AddTransient<IGameCategoryFactory, GameCategoryFactory>();
//builder.Services.AddScoped<IGameQuestionFactory, GameQuestionFactory>();
builder.Services.AddTransient<IGameAnswerFactory, GameAnswerFactory>();
builder.Services.AddTransient<IGameScoreFactory, GameScoreFactory>();
builder.Services.AddTransient<IGamePropertyFactory, GamePropertyFactory>();
builder.Services.AddTransient<IGameModeFactory, GameModeFactory>();
#endregion

#region Repositories
builder.Services.AddTransient<IGameRepository, GameRepository>();
builder.Services.AddTransient<IGameCategoryRepository, GameCategoryRepository>();
builder.Services.AddTransient<IGameModeRepository, GameModeRepository>();
builder.Services.AddTransient<IGameQuestionRepository, GameQuestionRepository>();
builder.Services.AddTransient<IGameAnswerRepository, GameAnswerRepository>();
builder.Services.AddTransient<IGameScoreRepository, GameScoreRepository>();
builder.Services.AddTransient<IGamePropertyRepository, GamePropertyRepository>();
builder.Services.AddTransient<IExceptionRepository, ExceptionRepository>();
#endregion
builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
// Add services to the container.
builder.Services.AddControllers(options =>
{
    //Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata filterMetadata = options.Filters.Add<TokenValidtionAttribute>();
    options.Filters.Add<TokenValidtionAttribute>();
});

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
