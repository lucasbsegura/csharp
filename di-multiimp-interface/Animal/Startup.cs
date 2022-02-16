using AnimalMoviment.Entities;
using AnimalMoviment.Enums;
using AnimalMoviment.Intefaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace AnimalMoviment
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            RegisterServices(services);

            RegisterSwagger(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AnimalMoviment v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void RegisterServices(IServiceCollection s)
        {
            //s.AddScoped<IMoviment<Animal>, Animal>(); 
            s.AddScoped<Dog>(); 
            s.AddScoped<Human>(); 
            s.AddScoped<Cat>();

            s.AddTransient<Func<MovimentEnum, IMoviment>>(movimentProvider => key => 
            { 
                switch (key) 
                { 
                    case MovimentEnum.Cat: return movimentProvider.GetService<Cat>(); 
                    case MovimentEnum.Dog: return movimentProvider.GetService<Dog>(); 
                    case MovimentEnum.Human: return movimentProvider.GetService<Human>(); 
                    default: return null; 
                } 
            });

            s.AddScoped<ISound, Dog>(); 
            s.AddScoped<ISound, Human>(); 
            s.AddScoped<ISound, Cat>();

            s.AddScoped<IFeeling<Dog>, Dog>(); 
            s.AddScoped<IFeeling<Human>, Human>(); 
            s.AddScoped<IFeeling<Cat>, Cat>(); 
        }

        public void RegisterSwagger(IServiceCollection s)
        {
            s.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AnimalMoviment", Version = "v1" });
            });
        }
    }
}
