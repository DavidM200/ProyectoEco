#pragma checksum "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91bcef6e8ab7a5c26ff0fbb3caff48b653ab27fb"
// <auto-generated/>
#pragma warning disable 1591
namespace GestionTelefonos.Client.Shared
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
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-nf3h498e32");
            __builder.AddMarkupContent(3, "<img style=\"max-width: 100%;max-height: 100%;display: block; margin-left : 10px\" src=\"images\\logo\\LogoEcoComputer.png\" b-nf3h498e32>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-nf3h498e32");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-nf3h498e32></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 7 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "font-family:Roboto");
            __builder.AddAttribute(14, "b-nf3h498e32");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "navbar-nav me-auto mb-2 mb-md-0");
            __builder.AddAttribute(17, "b-nf3h498e32");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddAttribute(20, "b-nf3h498e32");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-nf3h498e32></span> ");
                __builder2.AddMarkupContent(27, "<b b-nf3h498e32>Inicio</b>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "nav-item px-3");
            __builder.AddAttribute(31, "b-nf3h498e32");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", "nav-link");
            __builder.AddAttribute(34, "href", "companies");
            __builder.AddAttribute(35, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "<span class=\"oi oi-clipboard\" aria-hidden=\"true\" b-nf3h498e32></span> ");
                __builder2.AddMarkupContent(37, "<b b-nf3h498e32>Compañías</b>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "nav-item px-3");
            __builder.AddAttribute(41, "b-nf3h498e32");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
            __builder.AddAttribute(44, "href", "employees");
            __builder.AddAttribute(45, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "<span class=\"oi oi-briefcase\" aria-hidden=\"true\" b-nf3h498e32></span> ");
                __builder2.AddMarkupContent(47, "<b b-nf3h498e32>Empleados</b>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "li");
            __builder.AddAttribute(50, "class", "nav-item px-3");
            __builder.AddAttribute(51, "b-nf3h498e32");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            __builder.AddAttribute(53, "class", "nav-link");
            __builder.AddAttribute(54, "href", "rates");
            __builder.AddAttribute(55, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(56, "<span class=\"oi oi-dollar\" aria-hidden=\"true\" b-nf3h498e32></span> ");
                __builder2.AddMarkupContent(57, "<b b-nf3h498e32>Tarifas</b>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n         ");
            __builder.OpenElement(59, "li");
            __builder.AddAttribute(60, "class", "nav-item px-3");
            __builder.AddAttribute(61, "b-nf3h498e32");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(62);
            __builder.AddAttribute(63, "class", "nav-link");
            __builder.AddAttribute(64, "href", "lines");
            __builder.AddAttribute(65, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(66, "<span class=\"oi oi-wifi\" aria-hidden=\"true\" b-nf3h498e32></span> ");
                __builder2.AddMarkupContent(67, "<b b-nf3h498e32>Lineas</b>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.OpenElement(69, "li");
            __builder.AddAttribute(70, "class", "nav-item px-3");
            __builder.AddAttribute(71, "b-nf3h498e32");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(72);
            __builder.AddAttribute(73, "class", "nav-link");
            __builder.AddAttribute(74, "href", "sim");
            __builder.AddAttribute(75, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(76, "<span class=\"oi oi-aperture\" aria-hidden=\"true\" b-nf3h498e32></span> ");
                __builder2.AddMarkupContent(77, "<b b-nf3h498e32>Sim</b>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenElement(79, "li");
            __builder.AddAttribute(80, "class", "nav-item px-3");
            __builder.AddAttribute(81, "b-nf3h498e32");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(82);
            __builder.AddAttribute(83, "class", "nav-link");
            __builder.AddAttribute(84, "href", "terminals");
            __builder.AddAttribute(85, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(86, "<span class=\"oi oi-phone\" aria-hidden=\"true\" b-nf3h498e32></span> ");
                __builder2.AddMarkupContent(87, "<b b-nf3h498e32>Terminales</b>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591