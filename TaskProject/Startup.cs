using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Swashbuckle.AspNetCore.Swagger;
using TarefaProject.Domain.Services;
using TaskManager.Data.Context;
using TaskManger.Services;
using TaskProject.Domain.Repositories;
using TaskProject.Domain.Services;
using UserProject.Domain.Repositories;

namespace TaskProject
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
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<TaskManagerContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
           x => x.MigrationsAssembly("TaskProject")));

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddScoped<ITarefaService, TarefaService>();

            services.AddSwaggerGen(s =>
             {
                 s.SwaggerDoc("v1", new Info
                 {
                     Title = "Gerenciador de tarefas",
                     Description = "",
                     Version = "v1"
                 });
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("AllowAnyOrigin");
            //app.UseCors(builder => builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            //app.UseCors((corsPolicyBuilder) =>
            //{
            //    corsPolicyBuilder.AllowAnyOrigin();
            //    corsPolicyBuilder.AllowAnyMethod();
            //    corsPolicyBuilder.AllowAnyHeader();

            //});



            app.UseMvc();

            app.UseSwagger();
            //app.UseSpa(spa =>
            //         {
            //             spa.Options.SourcePath = "ClientApp";

            //             ;

            //             if (env.IsDevelopment())
            //             {
            //                 spa.UseAngularCliServer(npmScript: "start");
            //                 OR

            //                 spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
            //             }
            //         });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Onboarding Tool API v1");
            });
        }
    }
}
