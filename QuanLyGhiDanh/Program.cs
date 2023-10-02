using QuanLyGhiDanh.AppDBContext;
using QuanLyGhiDanh.Repository_.Repository;
using QuanLyGhiDanh.Service_.Interface;
using QuanLyGhiDanh.Service_.Service;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBContext>();

AddDI(builder.Services);

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
void AddDI(IServiceCollection services)
{
    services.AddScoped<BangDiemRepository>();
    services.AddScoped<IBangDiemService, BangDiemService>();

    

}