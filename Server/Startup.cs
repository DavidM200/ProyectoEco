using GestionTelefonos.Data.Dapper.Repositories;
using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared.Contracts.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GestionTelefonos.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IRateService, RateService>();
            services.AddTransient<ILineService, LineService>();
            services.AddTransient<ISimService, SimService>();
            services.AddTransient<ITerminalService, TerminalService>();
            services.AddTransient<IPhoneIncidenceService, PhoneIncidenceService>();
            services.AddTransient<IPayMethodService, PayMethodService>();
            services.AddTransient<ITerminalStateService, TerminalStateService>();
            services.AddTransient<ILinesEmployeeService, LinesEmployeeService>();
            services.AddTransient<ILinesTerminalService, LinesTerminalService>();
            services.AddTransient<ILinesEmployeeTerminalService, LinesEmployeeTerminalService>();

            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IRateRepository, RateRepository>();
            services.AddTransient<ILineRepository, LineRepository>();
            services.AddTransient<ISimRepository, SimRepository>();
            services.AddTransient<ITerminalRepository, TerminalRepository>();
            services.AddTransient<IPhoneIncidenceRepository, PhoneIncidenceRepository>();
            services.AddTransient<IPayMethodRepository, PayMethodRepository>();
            services.AddTransient<ITerminalStateRepository, TerminalStateRepository>();
            services.AddTransient<ILinesEmployeeRepository, LinesEmployeeRepository>();
            services.AddTransient<ILinesTerminalRepository, LinesTerminalRepository>();
            services.AddTransient<ILinesEmployeeTerminalRepository, LinesEmployeeTerminalRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
