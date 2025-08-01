using Business;
using Business.@interface;
using Core;
using DataAccsess;
using DataAccsess.abstrack;
using DataAccsess.Interface;
using Entity;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IDrSet,DrSet>();
builder.Services.AddScoped<IPtSet, PtSet>();
builder.Services.AddScoped<IOrSet, OrSet>();
builder.Services.AddScoped<IMtSet, MtSet>();
builder.Services.AddScoped<IDrSer, DrSer>();
builder.Services.AddScoped<IPtSer, PtSer>();
builder.Services.AddScoped<IOrSer, OrSer>();
builder.Services.AddScoped<IMtSer, MtSer>();

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
