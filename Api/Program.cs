using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

using EDA.QueryHandler;
using EDA.Query.Interface;
using EDA.Infra.Interface;
using EDA.Infra.Repositories; 
using EDA.Entity;
using EDA.Query;
using EDA.CommandHandle;
using EDA.Command.Interface;
using EDA;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddTransient<IQueryHandler<GetUserbyId, UserDbo>, GetUserbyIdQueryHandler>();
builder.Services.AddTransient<ICommandHandler<CreateUserCommandHandler>>();
builder.Services.AddTransient<ICommandHandler<UpdateUserCommandHandler>>();
builder.Services.AddTransient<ICommandHandler<DeleteUserCommandHandler>>();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.Run();
