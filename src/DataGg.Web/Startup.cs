using DataGg.Database;
using DataGg.Web.Converters;
using DataGg.Web.Data;
using DataGg.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Web
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();

            /* ADDED FROM API EXAMPLE SLN */
            services.AddControllers().AddJsonOptions(options =>
            {

                //options.JsonSerializerOptions.Converters.Add(new IsoDateFormatter());

                // obviously this very clearly means we want camel case property names
                // u wot mate
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "data.gg", Version = "v1" });
            });
            /**/


            //TODO: Revist. Not working for some reason?? maybe .net 5 issue?
            services.AddWebOptimizer(pipeline =>
           {
               pipeline.AddCssBundle("/css/bundle.css", new string[] { "wwwroot/css/*.css" }).UseContentRoot();
           });

            // sensible use of http client
            services.AddHttpClient();

            // emailz
            services.AddTransient<IEmailSender, EmailSender>();

            // data layer
            services.AddSingleton<RootDb>();
            services.AddSingleton<GuernseyDb>();

            // normal services
            services.AddSingleton<CacheManager>();

            // hosted services
            services.AddHostedService<CacheBackgroundService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();

                /* ADDED FROM API EXAMPLE SLN */
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "data.gg v1"));
                /**/
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            /* MUST GO ABOVE UseStaticFiles */
            app.UseWebOptimizer();
            /**/

            app.UseStaticFiles(new StaticFileOptions
            {
                ServeUnknownFileTypes = true,
            });


                app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                /* ADDED FROM API EXAMPLE SLN */
                endpoints.MapControllers();
                /**/
            });
        }
    }
}
