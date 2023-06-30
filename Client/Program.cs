using GestionTelefonos.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GestionTelefonos.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddDevExpressBlazor();

            builder.Services.AddTransient<ICompanyService, CompanyService>();

            builder.Services.AddTransient<IEmployeeService, EmployeeService>();

            builder.Services.AddTransient<IRateService, RateService>();

            builder.Services.AddTransient<ILineService, LineService>();

            builder.Services.AddTransient<ISimService, SimService>();

            builder.Services.AddTransient<ITerminalService, TerminalService>();

            builder.Services.AddTransient<IPhoneIncidenceService, PhoneIncidenceService>();

            builder.Services.AddTransient<IPayMethodService, PayMethodService>();

            builder.Services.AddTransient<ITerminalStateService, TerminalStateService>();

            builder.Services.AddTransient<ILinesEmployeeService, LinesEmployeeService>();

            builder.Services.AddTransient<ILinesTerminalService, LinesTerminalService>();

            builder.Services.AddTransient<ILinesEmployeeTerminalService, LinesEmployeeTerminalService>();

            await builder.Build().RunAsync();
        }
    }
}

