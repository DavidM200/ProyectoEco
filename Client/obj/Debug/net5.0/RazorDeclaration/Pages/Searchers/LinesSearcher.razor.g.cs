// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GestionTelefonos.Client.Pages.Searchers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using GestionTelefonos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using GestionTelefonos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\_Imports.razor"
using GestionTelefonos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\LinesSearcher.razor"
using GestionTelefonos.Shared.Contracts.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\LinesSearcher.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class LinesSearcher : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 147 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\LinesSearcher.razor"
       
    private bool showAlert = false;
    bool IsOpen { get; set; } = false;
    bool IsOpenSelector { get; set; } = false;
    string search;
    private Rate[] rates;
    LineSearcherForm lineSearcher { get; set; } = new();
    private IEnumerable<Company> companies;
    List<int> companiesList = new();
    DateTime  MinDate = new DateTime(2000, 01, 01);

    [Parameter]
    public EventCallback<LineSearcherForm> onFormSearch { get;  set; }
    [Parameter]
    public EventCallback<string> onInputSearch { get; set; }

    async Task openForm()
    {
        IsOpen = true;

        lineSearcher.CompanyIds = new List<int>();

        //Console.WriteLine(lineForm.CompanyIds);

        //string json = JsonSerializer.Serialize(lineForm.CompanyIds);

        companies = await companyService.GetCompanies();
        rates = await rateService.GetRates();

        lineSearcher.CompanyIds = new();
        //Añade todas las compañias en actibo al TagBox del formulario de busqueda
        lineSearcher.CompanyIds.AddRange(companies.Where(x => x.DischargeDate == null).Select(x => x.ID)); 
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ILineService lineService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ICompanyService companyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IRateService rateService { get; set; }
    }
}
#pragma warning restore 1591
