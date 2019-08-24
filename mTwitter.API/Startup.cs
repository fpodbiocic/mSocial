using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using mTwitter.API.Extensions;
using mTwitter.API.Models;
using mTwitter.API.Models.DatabaseModels.mTwitter;
using mTwitter.API.Services;

namespace mTwitter.API
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
            // ------------------------------------------------------------------------
            // DB connection strings

            // mTwitter database
            services.AddDbContext<mTwitterContext>(options => options.UseSqlServer(Configuration.GetConnectionString("mTwitterDatabase")));

            // ------------------------------------------------------------------------

            // ------------------------------------------------------------------------
            // CORS service

            services.ConfigureCors();

            // ------------------------------------------------------------------------

            // ------------------------------------------------------------------------
            // Repository service

            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IUserService, UserService>();

            // ------------------------------------------------------------------------

            // ------------------------------------------------------------------------
            // Logger factory service

            services.AddSingleton<ILoggerFactory, LoggerFactory>();
            services.AddSingleton(typeof(ILogger<>), typeof(Logger<>)).AddOptions();

            // ------------------------------------------------------------------------

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // ------------------------------------------------------------------------
            // appsettings.json

            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppsettingsJson>(appSettingsSection);

            // ------------------------------------------------------------------------

            // ------------------------------------------------------------------------
            // Configure JWT authentication

            var appSettings = appSettingsSection.Get<AppsettingsJson>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        var userService = context.HttpContext.RequestServices.GetRequiredService<IUserService>();
                        var userId = context.Principal.Identity.Name;
                        var user = userService.GetUserById(new Guid(userId));
                        if (user == null)
                        {
                            // return unauthorized if user no longer exists
                            context.Fail("Unauthorized");
                        }
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            // ------------------------------------------------------------------------


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
