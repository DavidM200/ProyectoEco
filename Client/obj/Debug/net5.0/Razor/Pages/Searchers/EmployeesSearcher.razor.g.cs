#pragma checksum "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc0c751fec0e0619af54ac3f164ff9f4ce46ccf"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
using GestionTelefonos.Shared.Contracts.Forms;

#line default
#line hidden
#nullable disable
    public partial class EmployeesSearcher : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "search");
            __builder.AddAttribute(3, "placeholder", "Buscar por nombre");
            __builder.AddAttribute(4, "style", "width: 200px; ");
            __builder.AddAttribute(5, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                                                                                       search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => search = __value, search));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                                              () => IsOpen = !IsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "id", "dropdown-target-container");
            __builder.AddMarkupContent(12, "<i class=\"oi oi-caret-bottom\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                                                async () => {await onInputSearch.InvokeAsync(search);search=string.Empty;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n  ");
            __builder.OpenComponent<global::DevExpress.Blazor.DxDropDown>(19);
            __builder.AddAttribute(20, "AllowResize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 12 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                 false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "CloseMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::DevExpress.Blazor.DropDownCloseMode>(
#nullable restore
#line 13 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
               DropDownCloseMode.Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "PreventCloseOnPositionTargetClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 14 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "PositionMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::DevExpress.Blazor.DropDownPositionMode>(
#nullable restore
#line 15 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                  DropDownPositionMode.Bottom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "PositionTarget", "#dropdown-target-container");
            __builder.AddAttribute(25, "RestrictionTarget", "#Navigation-DropDown-Customization");
            __builder.AddAttribute(26, "FooterVisible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 18 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "MinWidth", "300");
            __builder.AddAttribute(28, "MinHeight", "200");
            __builder.AddAttribute(29, "MaxWidth", "500");
            __builder.AddAttribute(30, "MaxHeight", "400");
            __builder.AddAttribute(31, "Width", "max(25vw, 250px)");
            __builder.AddAttribute(32, "IsOpen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 11 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                   IsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "IsOpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsOpen = __value, IsOpen))));
            __builder.AddAttribute(34, "BodyTextTemplate", (global::Microsoft.AspNetCore.Components.RenderFragment<DevExpress.Blazor.IPopupElementInfo>)((context) => (__builder2) => {
#nullable restore
#line 26 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
         if (showAlert)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(35, "<div class=\"alert alert-danger m-4\" role=\"alert\">\r\n                Se han de rellenar todos los campos\r\n            </div>");
#nullable restore
#line 31 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
        }else{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "style", "padding:10px");
                __builder2.AddMarkupContent(38, "<p><b>Nombre</b></p>\r\n            ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "search");
                __builder2.AddAttribute(41, "placeholder", "Introduce un nombre...");
                __builder2.AddAttribute(42, "style", "width:215px;");
                __builder2.AddAttribute(43, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                                                                                                  employee.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Name = __value, employee.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 36 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(45, "FooterTextTemplate", (global::Microsoft.AspNetCore.Components.RenderFragment<DevExpress.Blazor.IPopupElementInfo>)((context) => (__builder2) => {
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "class", "btn btn-primary");
                __builder2.AddAttribute(48, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
                                                    async () => {
        if(employee.Name==null){
             showAlert=true;
                await Task.Delay(3000); // Espera de 3 segundos
                showAlert = false;
                StateHasChanged();
        }else{
        await onFormSearch.InvokeAsync(employee);
        IsOpen=false;
        employee.Name=null;
        }
        }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(49, "<i class=\"oi oi-magnifying-glass\"></i>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Searchers\EmployeesSearcher.razor"
       
    private bool showAlert = false;
    bool IsOpen { get; set; } = false;
    string search;
    Employee employee { get; set; } = new();

    [Parameter]
    public EventCallback<Employee> onFormSearch{ get; set; }
    [Parameter]
    public EventCallback<string> onInputSearch{ get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
