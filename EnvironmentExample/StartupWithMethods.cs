using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentExample
{
    public class StartupWithMethods
    {
        public StartupWithMethods(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine($"Метод: {nameof(ConfigureServices)}");

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EnvironmentExample", Version = "v1" });
            });
        }

        public void ConfigureAndreyLaptopServices(IServiceCollection services)
        {
            Console.WriteLine($"Метод: {nameof(ConfigureAndreyLaptopServices)}");

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EnvironmentExample", Version = "v1" });
            });
        }

        public void ConfigureDarthVaderServices(IServiceCollection services)
        {
            Console.WriteLine($"Метод: {nameof(ConfigureDarthVaderServices)}");

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EnvironmentExample", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Console.WriteLine($"Класс: {nameof(StartupWithMethods)}");
            Console.WriteLine($"Метод: {nameof(Configure)}");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EnvironmentExample v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void ConfigureAndreyLaptop(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Console.WriteLine($"Класс: {nameof(StartupWithMethods)}");
            Console.WriteLine($"Метод: {nameof(ConfigureAndreyLaptop)}");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EnvironmentExample v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void ConfigureDarthVader(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Console.WriteLine($"Класс: {nameof(StartupWithMethods)}");
            Console.WriteLine($"Метод: {nameof(ConfigureDarthVader)}");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EnvironmentExample v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
