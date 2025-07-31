using Business;
using Core;
using DataAccsess;
using Entity;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IDataSet<>), typeof(DataBaseAc<>));
builder.Services.AddScoped<testCore<Doktorlar, DrDTO>, DrSer>();
builder.Services.AddScoped<testCore<Hastalar, PtDTO>, PtSer>();
builder.Services.AddScoped<testCore<Randevular, OrDTO>, OrSer>();
builder.Services.AddScoped<testCore<Durum, MtDTO>, MtSer>();


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
