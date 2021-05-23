using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using puertaMagica.BL.Contracts;
using puertaMagica.BL.Inplementations;
using puertaMagica.Core.AutoMapper;
using puertaMagica.Core.DTO;
using puertaMagica.DAL;
using puertaMagica.DAL.Contracts;
using puertaMagica.DAL.Entities;
using puertaMagica.DAL.Inplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace puertaMagica.API
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
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "puertaMagica.API", Version = "v1" });
            });

            services.AddCors(o => o.AddPolicy("MyPolicy", builder => {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            //Aquí las inyecciones: Interfaz - Clase
            services.AddScoped<ILoginBL, LoginBL>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IUsuarioBL, UsuarioBL>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<IPokemonBL, PokemonBL>();
            services.AddScoped<IPokemonRepository, PokemonRepository>();
            services.Add(new ServiceDescriptor(typeof(ConcesionarioContext), new ConcesionarioContext(Configuration.GetConnectionString("concesionariodb"))));

            //usuarioDTO Auto mapea Usuario
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<UsuarioDTO, Usuario>());

            services.AddAutoMapper(cfg => cfg.AddProfile(new AutoMapperProfile()));

            //PokemonDTO auto mapea Pokemon
            var configP = new MapperConfiguration(cfg =>
           cfg.CreateMap<PokemonDTO, Pokemon>());

            services.AddAutoMapper(cfg => cfg.AddProfile(new AutoMapperProfile()));
        }




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "puertaMagica.API v1"));
            }
            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
