using First.CORE.COMMON;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using First.INFRA.COMMON;
using First.INFRA.REPOSITORY;
using First.INFRA.SERVICE;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace First.API
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

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
                };
            });





            services.AddScoped<IDbContext, DbContext>();
           
            services.AddScoped<IAboutusRepository, AboutusRepository>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();


            services.AddScoped<IAboutusService, AboutusService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IRouteRepository, RouteRepository>();
            services.AddScoped<IRouteService, RouteService>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<ISchoolService, SchoolService>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IJWTRepository, JWTRepository>();


            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IJWTService, JWTService>();

            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<IFooterRepository, FooterRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IFooterService, FooterService>();
            services.AddScoped<IAttendanceService, AttendanceService>();



            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
