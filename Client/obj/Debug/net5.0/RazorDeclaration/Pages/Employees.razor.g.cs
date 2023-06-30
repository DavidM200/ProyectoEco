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
#nullable restore
#line 2 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Employees.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Employees.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Employees.razor"
using GestionTelefonos.Client.Pages.PopUps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Employees.razor"
using GestionTelefonos.Client.Pages.Searchers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Employees.razor"
using GestionTelefonos.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class Employees : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Employees.razor"
       
    private Employee[] employees;
    private LinesEmployeeTerminal[] linesEmployeeTerminals;

    private bool showAlert;

    public EmployeePopUp employeePopUp { set; get; }
    public EmployeesSearcher employeesSearcher{ set; get; }

    protected override async Task OnInitializedAsync()
    {
        employees = await employeeService.GetEmployees();
        linesEmployeeTerminals = await linesEmployeeTerminalService.GetLinesEmployeeTerminal();
    }
    async Task Grid_EditModelSaving(GridEditModelSavingEventArgs e) {

        Console.WriteLine("Modelsaving");
        Console.WriteLine(e);
        var employee = (Employee)e.EditModel;
        await (e.IsNew ? employeeService.InsertEmployeeAsync(employee) : employeeService.UpdateEmployeeAsync(employee));
        employees = await employeeService.GetEmployees();
        StateHasChanged();
    }
    async Task Grid_DataItemDeleting(GridDataItemDeletingEventArgs e)
    {
        var emp = (Employee)e.DataItem;
        bool success = await employeeService.DeleteEmployeeAsync(emp.ID);
        if (!success)
        {
            await JsRuntime.InvokeVoidAsync("alert", "Ocurrió un error al eliminar");
            return;
        }
        employees= await employeeService.GetEmployees();
        showAlert = true;
        StateHasChanged();

        await Task.Delay(5000); // Espera de 5 segundos
        showAlert = false;
        StateHasChanged();
    }
    private async Task InputSearch(string search)
    {
        employees = string.IsNullOrEmpty(search)
        ? await employeeService.GetEmployees()
        : await employeeService.Buscar(search);
    }
    private async Task FormSearch(string name)
    {
        employees = string.IsNullOrEmpty(name)
        ? await employeeService.GetEmployees()
        : await employeeService.BuscarForm(name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ILinesEmployeeTerminalService linesEmployeeTerminalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IEmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591