using GoWebApp.Server.Data;
using GoWebApp.Server.Hubs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWebApp.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration/*, DataContext context*/)
        {
            Configuration = configuration;
            //DbContext = context;
        }

        public IConfiguration Configuration { get; }
        //public DataContext DbContext { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<DataContext>(x => x.UseSqlite(Configuration.GetConnectionString("default")));
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSignalR();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).
                AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                    //options.Events = new JwtBearerEvents
                    //{
                    //    OnMessageReceived = DbContext =>
                    //    {
                    //        var accessToken = Configuration.GetSection("AppSettings:Token").Value;
                    //        var path = DbContext.HttpContext.Request.Path;
                    //        if(!string.IsNullOrEmpty(accessToken)&&(path.StartsWithSegments("/hubs")))
                    //        {
                    //            DbContext.Token = accessToken;
                    //        }
                    //        return Task.CompletedTask;
                    //    }
                    //};
                })
                .AddJwtBearer("Signalr", options =>
                {
                    options.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = context =>
                        {
                            var accessToken = context.Request.Query["token2"];
                            var path = context.HttpContext.Request.Path;
                            if (!string.IsNullOrEmpty(accessToken) && (path.StartsWithSegments("/hubs")))
                            {
                                context.Token = accessToken;
                            }
                            return Task.CompletedTask;
                        }
                    };
                });
            services.AddResponseCompression(opts => //signalr hub rabi to
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });
            services.AddHttpContextAccessor();
            //hub signalr services
            
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression(); //to je za signalr hub

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                
                app.UseHsts();
            }
            //hub signalr configuration
           

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapHub<GoHub>("/gohub");
                endpoints.MapFallbackToFile("index.html");
                
                //endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
