using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BL;
using DAL;
using Microsoft.AspNetCore.Cors;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public IConfiguration Configuration { get; }

        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _apphost;
        
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment apphost)
        {
            _apphost = apphost;            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddRazorPages();
           
            //services.AddDbContext<MeetAndFeedDbContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("MafDatabase")));

            services.AddEntityFrameworkSqlite().AddDbContext<MeetAndFeedDbContext>(options => { options.UseSqlite($"Data Source ={_apphost.ContentRootPath}/MafDatabase"); });
 
        
            services.AddScoped<IAllergyService, AllergyService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IUserService, UserService>();

            services.AddSwaggerGen(options => { options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "API-testing", Version = "V1" }); });

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:8080",
                                            "http://localhost:59119")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });



            services.AddControllers();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint(@"/swagger/v1/swagger.json", "API-testing"); 
                                    c.RoutePrefix = string.Empty; });
            
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireCors(MyAllowSpecificOrigins);
            });
        }
    }
}
