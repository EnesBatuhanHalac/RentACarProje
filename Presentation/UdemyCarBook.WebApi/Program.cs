
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Persistance.Context;
using UdemyCarBook.Persistance.Repositories;

namespace UdemyCarBook.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<CarBookContext>();
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            
            builder.Services.AddScoped<GetAboutQueryHandler>();
            builder.Services.AddScoped<GetAboutByIdQueryHandler>();
            builder.Services.AddScoped<CreateAboutCommandHandler>();
            builder.Services.AddScoped<UpdateAboutCommandHandler>();
            builder.Services.AddScoped<RemoveAboutCommandHandler>();
            // Add services to the container.

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
        }
    }
}
