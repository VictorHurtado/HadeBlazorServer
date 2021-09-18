#pragma checksum "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd5b633aa6571d8aa487979406dfa2c3eab7195"
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
#line 4 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
using CititorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
using CititorServer.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DesignList")]
    public partial class DesignList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Catalogo de Diseños</h1>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex flex-row flex-wrap");
#nullable restore
#line 12 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
         foreach (var design in designsList )
            {   
              if(design.status ==1){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card m-3 ");
            __builder.AddAttribute(5, "style", "width: 18rem;");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "class", "card-img-top min-height-img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 16 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
                                                                   design.imagenDiseño

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenElement(13, "h5");
            __builder.AddAttribute(14, "class", "card-title");
            __builder.AddContent(15, 
#nullable restore
#line 18 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
                                                design.idDiseño

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 18 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
                                                                 design.descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "card-text");
            __builder.AddContent(21, 
#nullable restore
#line 19 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
                                              design.fechaCarga

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " - ");
            __builder.AddContent(23, 
#nullable restore
#line 19 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
                                                                   design.Tamaño

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<a href=\"#\" class=\"btn btn-primary\">Agregar</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
              } 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\DesignList.razor"
       

    IEnumerable<Design> designsList;
    protected override async Task OnInitializedAsync(){
         
        designsList= await IDesignService.AllDesignsGet();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDesignService IDesignService { get; set; }
    }
}
#pragma warning restore 1591
