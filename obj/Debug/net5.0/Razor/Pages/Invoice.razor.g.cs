#pragma checksum "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69fac1b33e7dcc520c8f08232c544b2555e5149f"
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
#line 3 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
using CititorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
using CititorServer.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Invoice")]
    public partial class Invoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Facturación</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-flex mr-5 m-auto col-lg-12 col-sm-12");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "class", "row g-3");
            __builder.AddMarkupContent(9, "<div class=\"col-md-6\"><label for=\"inputEmail4\" class=\"form-label\">Email</label>\r\n        <input type=\"email\" class=\"form-control\" id=\"inputEmail4\"></div>\r\n      ");
            __builder.AddMarkupContent(10, "<div class=\"col-md-6\"><label for=\"inputFact\" class=\"form-label\">Numero de Compra</label>\r\n        <input type=\"text\" disabled class=\"form-control\" id=\"inputFact\"></div>\r\n      ");
            __builder.AddMarkupContent(11, "<div class=\"col-md-6\"><label for=\"inputName\" class=\"form-label\">Nombre</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"inputName\" placeholder=\"Nombre\"></div>\r\n      ");
            __builder.AddMarkupContent(12, "<div class=\"col-md-6\"><label for=\"inputLastName\" class=\"form-label\">Apellido</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"inputLastName\" placeholder=\"Apellido\"></div>\r\n      ");
            __builder.AddMarkupContent(13, "<div class=\"col-12\"><label for=\"inputAddress\" class=\"form-label\">Dirección</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"inputAddress\" placeholder=\"Dirección\"></div>\r\n      ");
            __builder.AddMarkupContent(14, "<div class=\"col-md-6\"><label for=\"inputCity\" class=\"form-label\">City</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"inputCity\"></div>\r\n      ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-md-4");
            __builder.AddMarkupContent(17, "<label for=\"inputState\" class=\"form-label\">State</label><br>\r\n        ");
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "id", "inputState");
            __builder.AddAttribute(20, "class", "form-select");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "selected");
            __builder.AddContent(23, "Choose...");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n          ");
            __builder.OpenElement(25, "option");
            __builder.AddContent(26, "...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n      ");
            __builder.AddMarkupContent(28, "<div class=\"col-md-2\"><label for=\"inputZip\" class=\"form-label\">Zip</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"inputZip\"></div>\r\n      ");
            __builder.AddMarkupContent(29, "<div class=\"col-12\"><div class=\"form-check\"><input class=\"form-check-input\" type=\"checkbox\" id=\"gridCheck\">\r\n          <label class=\"form-check-label\" for=\"gridCheck\">\r\n            Check me out\r\n          </label></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n<br>\r\n<br>\r\n<br>\r\n  ");
            __builder.AddMarkupContent(31, "<h4>Resumen de la Compra</h4>\r\n\r\n  ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "table-responsive m-auto col-lg-12 col-sm-12");
            __builder.OpenElement(34, "table");
            __builder.AddAttribute(35, "class", "table table-striped table-bordered mw-75 m-auto");
            __builder.AddAttribute(36, "id", "example");
            __builder.AddMarkupContent(37, "<thead><tr><th>Código</th>\r\n          <th>Descripción</th>\r\n\r\n\r\n          <th>Cantidad</th>\r\n\r\n          <th>Valor</th></tr></thead>\r\n      ");
            __builder.OpenElement(38, "tbody");
#nullable restore
#line 90 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
          
          int i = 0;
          var myQtArticles = qtArticleListDe.ToList();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
         foreach (var articleFor in articlesListDe)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "tr");
            __builder.OpenElement(40, "td");
#nullable restore
#line 97 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(41, articleFor.idArticulo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 98 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(44, articleFor.descripcionArticulo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n            ");
            __builder.OpenElement(46, "td");
#nullable restore
#line 100 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(47, myQtArticles[@i].cantArticulo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "td");
#nullable restore
#line 101 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(50, articleFor.valor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 105 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"

          i = i + 1;

        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "<td></td>\r\n          <td></td>\r\n\r\n          ");
            __builder.AddMarkupContent(53, "<td><strong>Subotal</strong></td>\r\n          ");
            __builder.OpenElement(54, "td");
#nullable restore
#line 114 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(55, subtotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "<td></td>\r\n          <td></td>\r\n\r\n          ");
            __builder.AddMarkupContent(59, "<td><strong>  Descuento</strong></td>\r\n          ");
            __builder.OpenElement(60, "td");
#nullable restore
#line 123 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(61, discount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n          ");
            __builder.OpenElement(63, "tr");
            __builder.AddMarkupContent(64, "<td></td>\r\n          <td></td>\r\n\r\n          ");
            __builder.AddMarkupContent(65, "<td><strong>  Total</strong></td>\r\n          ");
            __builder.OpenElement(66, "td");
#nullable restore
#line 132 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(67, total);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n  <br>\r\n  <br>\r\n  <br>\r\n    ");
            __builder.AddMarkupContent(69, "<h4>Sección de Cupones</h4>\r\n  ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row py-5");
            __builder.OpenElement(72, "form");
            __builder.AddAttribute(73, "class", "column gy-2 gx-3 align-items-center");
#nullable restore
#line 151 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
             for(int j=0; j<cont;j++){
              

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-auto");
            __builder.OpenElement(76, "label");
            __builder.AddAttribute(77, "class", "visually-hidden");
            __builder.AddAttribute(78, "for", "autoSizingInput");
            __builder.AddMarkupContent(79, "Código de Cupón ");
#nullable restore
#line 155 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(80, j);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "<br>\r\n              ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "row");
#nullable restore
#line 158 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
               if(j == cont-1  && bonos.Count()==0 ){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "text");
            __builder.AddAttribute(86, "class", "form-control col-8");
            __builder.AddAttribute(87, "value", "0");
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 159 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                                                                                     (ChangeEventArgs __e) =>addBonoInBonos(__e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "id", "autoSizingInput");
            __builder.AddAttribute(90, "placeholder", "Jane Doe");
            __builder.CloseElement();
#nullable restore
#line 160 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
              }else if(j == cont-1  && bonos.Count()!=0 ) {
                 String value=  bonos[bonos.Count()-1].co_alpha;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "type", "text");
            __builder.AddAttribute(93, "class", "form-control col-8");
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 162 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                                                                          (ChangeEventArgs __e) =>addBonoInBonos(__e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "id", "autoSizingInput");
            __builder.CloseElement();
#nullable restore
#line 163 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
              
              }else{
                String value=  bonos[j].co_alpha;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "type", "text");
            __builder.AddAttribute(98, "class", "form-control col-8");
            __builder.AddAttribute(99, "disabled");
            __builder.AddAttribute(100, "id", "autoSizingInput");
            __builder.AddAttribute(101, "placeholder", 
#nullable restore
#line 166 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                                                                                                           value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 167 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
              }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "d-flex justify-content-center col-2 px-0 py-0");
            __builder.AddAttribute(104, "style", "height: calc(1.5em + .75rem + 2px) !important;");
#nullable restore
#line 171 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                   if(bonos.Count()>0 && bonos.Count()>j){
                    if(bonos[j].porcentaje>0 && bonos[j].porcentaje<55 ){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(105, "a");
            __builder.AddAttribute(106, "class", "btn btn-warning btn-lg btn-block px-0");
            __builder.AddAttribute(107, "style", "color:white; font-size: 0.8rem; ");
            __builder.OpenElement(108, "b");
#nullable restore
#line 173 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(109, bonos[j].porcentaje);

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, " %");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 174 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                    }else if(bonos[j].porcentaje>=56){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(111, "a");
            __builder.AddAttribute(112, "class", "btn btn-success btn-lg btn-block px-0");
            __builder.AddAttribute(113, "style", "color:white; font-size: 0.8rem; ");
            __builder.OpenElement(114, "b");
#nullable restore
#line 175 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
__builder.AddContent(115, bonos[j].porcentaje);

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, " %");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 176 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                    }
                  }else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(117, "<a class=\"btn btn-danger btn-lg btn-block px-0\" style=\"color:white; font-size: 0.8rem; \"><b>0%</b></a>");
#nullable restore
#line 179 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
              
                   }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "<br>");
#nullable restore
#line 190 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
          } 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(119, "<br>\r\n        ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "row d-flex justify-content-between");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "col-auto d-flex justify-content-center col-2");
            __builder.OpenElement(124, "a");
            __builder.AddAttribute(125, "class", "btn btn-danger  btn-lg ");
            __builder.AddAttribute(126, "style", "color:white;");
            __builder.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 196 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                                                                              ()=>removeNewInput()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(128, "-");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n           ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col-auto d-flex justify-content-center col-2");
            __builder.OpenElement(132, "a");
            __builder.AddAttribute(133, "class", "btn btn-success  btn-lg ");
            __builder.AddAttribute(134, "style", "color:white;");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 199 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                                                                               ()=>addNewInput()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(136, "+");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        \r\n          ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "col-auto d-flex justify-content-center col-8 p-0");
            __builder.OpenElement(140, "a");
            __builder.AddAttribute(141, "class", "btn btn-primary btn-lg btn-block");
            __builder.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 203 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
                                                                  ()=>calculateBonoPercentage()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "style", "color:white;");
            __builder.AddContent(144, "Aplicar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 217 "D:\programming\hade_blazzor\HadeBlazorServer\Pages\Invoice.razor"
       
  
  IEnumerable<Article> articlesListDe;
  IEnumerable<Listde> qtArticleListDe;

  List<Bono> bonos = new List<Bono>();
  
  int cont=1;
  double subtotal = 0;

  double percent= 0;
  double discount =0;
  double MAXOFPERCENT =56;
  double total = 0;
  protected override async Task OnInitializedAsync()
  {

    articlesListDe = await IListdeService.AllArticleListDe();
    qtArticleListDe = await IListdeService.AllListdeGet();

    calculateSubtotal();
    calculateTotal();

  }
  void addNewInput(){
    cont++;
  }
  void removeNewInput(){
    bonos.RemoveAt(bonos.Count()-1);
     printAllBonos();
    cont--;
  }
  void calculateSubtotal(){
    if(articlesListDe.Count() ==qtArticleListDe.Count()  && qtArticleListDe.Count()!= 0 && articlesListDe.Count() != 0){
      int i=0;
      var myQtArticles = qtArticleListDe.ToList();
      foreach(var articleFor in articlesListDe){
          if(articleFor.idArticulo == myQtArticles[i].idArticulo){
    
            subtotal = subtotal + (articleFor.valor*myQtArticles[i].cantArticulo);
          }
    
          i++;
      }
    }
  }

  void calculateTotal(){
    total=0;
    total = Math.Round(subtotal -discount,2);
  }
  void calculateBonoPercentage(){

    discount=0;
      foreach(var bono in bonos){
        percent = percent + (bono.porcentaje);
         if(percent<=MAXOFPERCENT){
           Console.WriteLine(percent);
           
           discount = discount + ((bono.porcentaje/100.0) * subtotal);

           discount= Math.Round(discount,2);
         }else{
           Console.WriteLine("Excediste el porcentaje del bono");
         }
      }
      calculateTotal();
  }

  public async void addBonoInBonos(Microsoft.AspNetCore.Components.ChangeEventArgs args){

    Bono newBono= new Bono();
    
    try{
      newBono = await IBonoService.bonoGet((string)args.Value);
      
      if(noDuplicateBono(newBono) != true && bonos.Count() != cont && newBono.idBono !=0 ){ 
        bonos.Add(newBono);
      }
      
    }catch(Exception e){
      Console.WriteLine("Algo salio mal");
     }
  
      printAllBonos();
  }


  void printAllBonos(){
    Console.WriteLine("-------------------------");
    foreach(var bono in bonos){
      Console.WriteLine("bono: "+ bono.co_alpha + " porcentaje:"+ bono.porcentaje);
    }
  }
  public bool noDuplicateBono(Bono newBono){
      foreach(var bono in bonos){
        if(bono.idBono == newBono.idBono){
          return true;
        }
      }
      return false;
  }


  protected override async Task OnAfterRenderAsync(bool firstRender)
  {
    if (firstRender)
    {
      await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }
  }



  void Cancel()
  {
    NavigationManager.NavigateTo("/");
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBonoService IBonoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IListdeService IListdeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDesignService IDesignService { get; set; }
    }
}
#pragma warning restore 1591
