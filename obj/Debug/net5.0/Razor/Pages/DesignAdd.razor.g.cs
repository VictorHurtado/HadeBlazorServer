#pragma checksum "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "565392405a5fd32fb8711140cdd99bc6311662e5"
// <auto-generated/>
#pragma warning disable 1591
namespace CititorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using CititorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using CititorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
using CititorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
using CititorServer.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DesignAdd")]
    public partial class DesignAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Adicionar Diseños</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-flex mr-5 m-auto col-lg-4 col-sm-12");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                          design

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                                  DesignInsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "table");
                __builder2.OpenElement(10, "tr");
                __builder2.AddMarkupContent(11, "\r\n                    Código Diseño:\r\n                    ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "required");
                __builder2.AddAttribute(15, "class", "col-12");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                              design.idDiseño

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => design.idDiseño = __value, design.idDiseño));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, " \r\n                ");
                __builder2.OpenElement(19, "tr");
                __builder2.AddMarkupContent(20, "\r\n                    Url Imagen Diseño:\r\n                    ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "type", "text");
                __builder2.AddAttribute(23, "required");
                __builder2.AddAttribute(24, "class", "col-12");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                              design.imagenDiseño

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => design.imagenDiseño = __value, design.imagenDiseño));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenElement(28, "tr");
                __builder2.AddMarkupContent(29, "\r\n                    Fecha:\r\n                    ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "date");
                __builder2.AddAttribute(32, "class", "col-12");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                              design.fechaCarga

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => design.fechaCarga = __value, design.fechaCarga, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenElement(36, "tr");
                __builder2.AddMarkupContent(37, "\r\n                    Descripción:\r\n                    ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "text");
                __builder2.AddAttribute(40, "class", "col-12");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                              design.descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => design.descripcion = __value, design.descripcion));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "tr");
                __builder2.AddMarkupContent(45, "\r\n                    Tamaño:\r\n                    ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "text");
                __builder2.AddAttribute(48, "class", "col-12");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                              design.Tamaño

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => design.Tamaño = __value, design.Tamaño));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                <br>\r\n                <br>\r\n                ");
                __builder2.OpenElement(52, "tr");
                __builder2.OpenElement(53, "td");
                __builder2.AddAttribute(54, "colspan", "2");
                __builder2.AddAttribute(55, "class", "d-flex justify-content-between");
                __builder2.AddMarkupContent(56, "<input type=\"submit\" value=\"Adicionar\" class=\"btn btn-primary btn-lg col-7\">\r\n                        ");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "type", "button");
                __builder2.AddAttribute(59, "value", "Cancelar");
                __builder2.AddAttribute(60, "class", "btn btn-secondary btn-lg col-4");
                __builder2.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                                                                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "d-flex m-auto col-lg-5 col-sm-8");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "d-flex flex-row flex-wrap");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card m-3 ");
            __builder.AddAttribute(69, "style", "width: 18rem;");
#nullable restore
#line 54 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                         if(design.imagenDiseño!=null){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "img");
            __builder.AddAttribute(71, "class", "card-img-top");
            __builder.AddAttribute(72, "src", 
#nullable restore
#line 55 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                                            design.imagenDiseño

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(73, "alt", "Card image cap");
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                        }else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "img");
            __builder.AddAttribute(75, "class", "card-img-top");
            __builder.AddAttribute(76, "src", 
#nullable restore
#line 57 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                                            defaultImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "alt", "Card image cap");
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "card-body");
            __builder.OpenElement(80, "h5");
            __builder.AddAttribute(81, "class", "card-title");
            __builder.AddContent(82, 
#nullable restore
#line 61 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                                    design.descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                            ");
            __builder.OpenElement(84, "p");
            __builder.AddAttribute(85, "class", "card-text");
            __builder.AddContent(86, 
#nullable restore
#line 62 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                                  design.fechaCarga

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(87, " - ");
            __builder.AddContent(88, 
#nullable restore
#line 62 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
                                                                       design.Tamaño

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignAdd.razor"
       
    string defaultImage="https://dbdzm869oupei.cloudfront.net/img/quadres/preview/29304.png";
    Design design = new Design();
    Design consultDesign = new Design();
    

    protected async Task DesignInsert()
    {
      
        await IDesignService.DesignInsert(design);
        

       
    }
    protected async Task DesignGet()
    {   
        consultDesign = await IDesignService.DesignGet(design.idDiseño);
        Console.WriteLine (consultDesign.imagenDiseño); 
           
        

       
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDesignService IDesignService { get; set; }
    }
}
#pragma warning restore 1591