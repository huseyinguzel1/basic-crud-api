using Business.Abstract;
using Business.Concrete;
using DataAccess;
using DataAccess.EntityFramework.Abstract;
using DataAccess.EntityFramework.Concrete;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IBookDal, EfBookDal>();
builder.Services.AddScoped<IAuthorDal, EfAuthorDal>();
builder.Services.AddScoped<IBookService, BookManager>();
builder.Services.AddScoped<IAuthorService, AuthorManager>();
builder.Services.AddDbContext<BookContext>(ServiceLifetime.Singleton);

// TODO: service register move to extension.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
