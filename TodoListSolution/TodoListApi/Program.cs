using TodoListApi.Data;
using Microsoft.EntityFrameworkCore;
using FluentAssertions.Common;


        

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

// Register the DbContext with an in-memory database
builder.Services.AddDbContext<TodoListContext>(static options =>
    options.UseInMemoryDatabase("TodoListDatabase"));


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
    
