using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TDM_OnLineStore.Dominium.Models.Interface;
using TDM_OnLineStore.Repository;
using TDM_OnLineStore.Repository.Repositories;

namespace TDM_OnLineStore_Angular.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            /// Configure the Context that will be used (Connection to the DB)
            var connectionString = Configuration.GetConnectionString("TDM_OnLineStoreDB");
            services.AddDbContextPool<AppDbContext>(opition =>                              // --- It was AddDbContext. Changed to better performance --- 
                                                  opition.UseLazyLoadingProxies()           // --- Allows the automatic loading of all relationship between tables in the DB ---
                                                        .UseMySql(connectionString,
                                                                     m => m.MigrationsAssembly("TDM_OnLineStore.Repository")));

            ///Connection between the Repository Interface and the Concrete Repository (Dependence Injection)
            services.AddScoped<IProductRepository, ProductRepository>();

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    ////RUNNING FROM THE ASP.NET Core SERVER (IIS)
                    //spa.UseAngularCliServer(npmScript: "start");

                    //RUNNING FROM THE ANGULAR SERVER
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200/");
                }
            });
        }
    }
}