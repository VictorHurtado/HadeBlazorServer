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
#line 1 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using CititorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using CititorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\nicol\Desktop\HadeBlazorServer\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\Desktop\HadeBlazorServer\Pages\DesignAdd.razor"
using CititorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\Desktop\HadeBlazorServer\Pages\DesignAdd.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\nicol\Desktop\HadeBlazorServer\Pages\DesignAdd.razor"
       

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
