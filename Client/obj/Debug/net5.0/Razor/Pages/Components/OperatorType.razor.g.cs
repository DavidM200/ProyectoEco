#pragma checksum "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf659405a5bce9917be760579f0279243faff5ad"
// <auto-generated/>
#pragma warning disable 1591
namespace GestionTelefonos.Client.Pages.Components
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
    public partial class OperatorType : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
#nullable restore
#line 2 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
__builder.AddContent(1, "." + IconCssClass);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, " {\r\n        width: 16px;\r\n        height: 16px;\r\n        -webkit-mask-image: url(");
#nullable restore
#line 5 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
__builder.AddContent(3, CurrentOperatorType.IconPath);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, ");\r\n        mask-image: url(");
#nullable restore
#line 6 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
__builder.AddContent(5, CurrentOperatorType.IconPath);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, ");\r\n        background-color: currentColor;\r\n    }\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "filter-type-container");
            __builder.AddAttribute(10, "id", 
#nullable restore
#line 10 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                                        PositionTargetID

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<global::DevExpress.Blazor.DxButton>(11);
            __builder.AddAttribute(12, "CssClass", "filter-type-button");
            __builder.AddAttribute(13, "IconCssClass", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 12 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                             IconCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                     () => IsOpen = !IsOpen

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenComponent<global::DevExpress.Blazor.DxDropDown>(16);
            __builder.AddAttribute(17, "HeaderVisible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 15 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "FooterVisible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 16 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "PositionMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::DevExpress.Blazor.DropDownPositionMode>(
#nullable restore
#line 17 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                              DropDownPositionMode.Bottom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "PositionTarget", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 18 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                                  "#" + PositionTargetID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "IsOpen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 14 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                               IsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "IsOpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsOpen = __value, IsOpen))));
            __builder.AddAttribute(23, "BodyTemplate", (global::Microsoft.AspNetCore.Components.RenderFragment<DevExpress.Blazor.IPopupElementInfo>)((context) => (__builder2) => {
                global::__Blazor.GestionTelefonos.Client.Pages.Components.OperatorType.TypeInference.CreateDxListBox_0(__builder2, 24, 25, 
#nullable restore
#line 20 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                             OperatorTypes

#line default
#line hidden
#nullable disable
                , 26, 
#nullable restore
#line 22 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                                        nameof(OperatorTypeWrapper.DisplayText)

#line default
#line hidden
#nullable disable
                , 27, 
#nullable restore
#line 21 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
                                    CurrentOperatorType

#line default
#line hidden
#nullable disable
                , 28, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentOperatorType = __value, CurrentOperatorType)), 29, () => CurrentOperatorType);
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
#nullable restore
#line 26 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
__builder.AddContent(32, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "F:\Blazor\GestionTelefonos\GestionTelefonos\Client\Pages\Components\OperatorType.razor"
       
    [Parameter] public GridDataColumnFilterRowCellTemplateContext FilterContext { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }

    List<OperatorTypeWrapper> OperatorTypes { get; set; }

    OperatorTypeWrapper CurrentOperatorType {
        get => OperatorTypes.First((ot) => ot.Value == FilterContext.DataColumn.FilterRowOperatorType);
        set {
            FilterContext.Grid.BeginUpdate();
            FilterContext.DataColumn.FilterRowOperatorType = value.Value;
            FilterContext.Grid.EndUpdate();
            IsOpen = false;
        }
    }
    bool IsOpen { get; set; } = false;
    string PositionTargetID => $"dropdown-target-container-{FilterContext.DataColumn.FieldName}";
    string IconCssClass => $"icon-class-{FilterContext.DataColumn.FieldName}";
    protected override void OnInitialized() {
        OperatorTypes = Enum.GetValues(typeof(GridFilterRowOperatorType))
            .OfType<GridFilterRowOperatorType>()
            .Select(t => new OperatorTypeWrapper(t, t.ToString())).ToList();
    }

    class OperatorTypeWrapper {
        public OperatorTypeWrapper(GridFilterRowOperatorType value, string displayText) {
            Value = value;
            DisplayText = displayText;
        }
        public GridFilterRowOperatorType Value { get; set; }
        public string DisplayText { get; set; }
        public string IconPath => $"images/filterIcons/{DisplayText}.svg";
    };


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.GestionTelefonos.Client.Pages.Components.OperatorType
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxListBox_0<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxListBox<TData, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextFieldName", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
