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
#line 3 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\ArticleUpdate.razor"
using CititorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\ArticleUpdate.razor"
using CititorServer.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditArticle")]
    public partial class ArticleUpdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\ArticleUpdate.razor"
       

    Article article = new Article();

    protected async Task ArticleUpdateSend()
    {   
        if(article.idArticulo != null && article.descripcionArticulo != null && article.valor!=0){
            await IArticleService.ArticleUpdate(article);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArticleService IArticleService { get; set; }
    }
}
#pragma warning restore 1591
