using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIRestTomasHerrero.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace APIRestTomasHerrero
{
    public class Startup
    {
        // Harcodeo Conexion a BD para realizar la migración


        // Configuración de clase Startup 
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        // Configura el servicio a donde va a ser migrado para realizar peticiones. 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataFields>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Connection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
