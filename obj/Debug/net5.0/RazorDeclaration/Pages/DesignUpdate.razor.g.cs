// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CititorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using CititorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using CititorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\programming\hade_blazzor\HadeBlazorServer\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignUpdate.razor"
using CititorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignUpdate.razor"
using CititorServer.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditDesign")]
    public partial class DesignUpdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignUpdate.razor"
       

    Design design = new Design();

    protected async Task DesignUpdateSend()
    {   
        if(design.idDiseño != 0 && design.imagenDiseño != null && design.fechaCarga!= null && design.Tamaño!= null){
            await IDesignService.DesignUpdate(design);
        }
      

        NavigationManager.NavigateTo("/");
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
