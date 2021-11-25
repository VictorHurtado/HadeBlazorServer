#pragma checksum "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "325e7c19d81ac32942c59a1658a84fff721d20d0"
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
#line 4 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
using CititorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex flex-row justify-content-between ");
            __builder.AddMarkupContent(2, "<h3>Asignación de Diseños</h3>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-flex flex-row justify-content-between");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Articulo: ");
#nullable restore
#line 14 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
__builder.AddContent(7, selectedArticle!=null?selectedArticle.descripcionArticulo : "" );

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        \r\n        <br><br>\r\n        ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "class", "btn btn-custom mx-3");
            __builder.AddAttribute(11, "style", "color:white;");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                                                                      ()=>expandCarList = !expandCarList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "<span class=\"oi oi-cart\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "d-flex flex-row ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "d-flex flex-row flex-wrap ");
#nullable restore
#line 24 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
         foreach (var design in designsList)
        {
            if (design.status == 1)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card m-3 ");
            __builder.AddAttribute(21, "style", "width: 18rem;");
            __builder.OpenElement(22, "img");
            __builder.AddAttribute(23, "class", "card-img-top minHeightDesingImage");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 29 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                                                                         design.imagenDiseño

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-body");
            __builder.OpenElement(29, "h5");
            __builder.AddAttribute(30, "class", "card-title");
#nullable restore
#line 31 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
__builder.AddContent(31, design.idDiseño);

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, " ");
#nullable restore
#line 31 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
__builder.AddContent(33, design.descripcion);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "card-text");
#nullable restore
#line 32 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
__builder.AddContent(37, design.fechaCarga);

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, " - ");
#nullable restore
#line 32 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
__builder.AddContent(39, design.Tamaño);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "btn btn-primary");
            __builder.AddAttribute(43, "style", "color:white;");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                                                                                  ()=>selectDesignOfList(design)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Asignar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 41 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
     if (expandCarList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", " d-flex flex-column carDesign col-4");
#nullable restore
#line 45 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
             foreach (var article in articlesListDe)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "class", "my-2");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                                          ()=>selectArticleOfList(article)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "card mx-auto");
            __builder.AddAttribute(53, "style", "width: 8rem; height: 200px;");
            __builder.OpenElement(54, "img");
            __builder.AddAttribute(55, "class", "card-img-top cardDesign");
            __builder.AddAttribute(56, "src", 
#nullable restore
#line 49 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                                                                   article.imagenArticulo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "card-body");
            __builder.OpenElement(61, "p");
            __builder.AddAttribute(62, "class", "card-text");
#nullable restore
#line 52 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
__builder.AddContent(63, article.descripcionArticulo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"


            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "my-5");
            __builder.AddAttribute(66, "style", "width:100%; color:white; ");
            __builder.AddMarkupContent(67, "<h4>Vista Previa</h4>\r\n                ");
            __builder.OpenElement(68, "p");
            __builder.AddContent(69, "Articulo: ");
#nullable restore
#line 67 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
__builder.AddContent(70, selectedArticle!=null?selectedArticle.descripcionArticulo : "" );

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "p");
            __builder.AddMarkupContent(73, "Diseño: ");
#nullable restore
#line 68 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
__builder.AddContent(74, selectedDesign!=null?selectedDesign.descripcion : "" );

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 69 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                 if(imagePathPreview!= "images/"){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "style", "width:100%; display:block");
            __builder.OpenElement(77, "img");
            __builder.AddAttribute(78, "class", "mx-auto maxWidhtPreviewImage");
            __builder.AddAttribute(79, "src", 
#nullable restore
#line 71 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                                                                        imagePathPreview

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(80, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "<br>\r\n                <br>\r\n                ");
            __builder.OpenElement(82, "a");
            __builder.AddAttribute(83, "class", "btn btn-primary  btn-lg btn-block  ");
            __builder.AddAttribute(84, "style", "color:white;");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
                                                                                              ()=>asignDesign(selectedArticle.idArticulo, selectedDesign.idDiseño)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Guardar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\DesignList.razor"
       
    string visibleArticleClass { get; set; }

    IEnumerable<Design> designsList;
    IEnumerable<Article> articlesListDe;

    protected bool expandCarList;

    Article selectedArticle;
    Design selectedDesign;

    string imagePathPreview= "images/";

    protected override async Task OnInitializedAsync()
    {
        designsList = await IDesignService.AllDesignsGet();
        articlesListDe = await IListdeService.AllArticleListDe();
    }
    void selectDesignOfList(Design design)
    {
        selectedDesign = design;
         Console.WriteLine(selectedDesign.descripcion);
         updatePreview();
    }
    void selectArticleOfList(Article article)
    {
        selectedArticle = article;
        
        Console.WriteLine(selectedArticle.descripcionArticulo);
        updatePreview();
    }
    void updatePreview(){
        if(selectedArticle!=null && selectedDesign!= null){
            resetImagePath();
            imagePathPreview= $"{imagePathPreview}{selectedArticle.idArticulo}{selectedDesign.idDiseño}.jpg";  
            Console.WriteLine(imagePathPreview);
        }
        
    }
     void resetImagePath(){
        imagePathPreview= "images/";
    }
    protected async Task asignDesign (int idArticle,int idDesign) {
        if(idArticle!=0 && idDesign!=0){
            bool result = await IListdeService.ListdeUpdateDesign(idArticle,idDesign);
            Console.WriteLine(result);
            selectedDesign= null;
            selectedArticle=null;
           resetImagePath();

        }
        
    }
   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IListdeService IListdeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDesignService IDesignService { get; set; }
    }
}
#pragma warning restore 1591
