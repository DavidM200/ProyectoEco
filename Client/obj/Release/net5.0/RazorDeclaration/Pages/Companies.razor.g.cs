// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GestionTelefonos.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies")]
    public partial class Companies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Companies.razor"
       
    private Company[] companies;


    protected override async Task OnInitializedAsync()
    {
        companies = await companyService.getCompanies();
    }

    async Task Grid_EditModelSaving(GridEditModelSavingEventArgs e) {
        var company = (Company)e.EditModel;
        if (e.IsNew)
            await companyService.insertCompanyAsync(company);
        else
            await companyService.updateCompanyAsync(company);

        companies = await companyService.getCompanies();
        StateHasChanged();
    }
    async Task Grid_DataItemDeleting(GridDataItemDeletingEventArgs e) {
        var company = (Company)e.DataItem;
        await companyService.deleteCompanyAsync(company.ID);

        companies = await companyService.getCompanies();
        StateHasChanged();
    }    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ICompanyService companyService { get; set; }
    }
}
#pragma warning restore 1591
