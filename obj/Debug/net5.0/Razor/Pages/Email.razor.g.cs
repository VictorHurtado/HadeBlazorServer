#pragma checksum "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eba7d1ba10c24c368e72f5b2725fd7981ef72034"
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
#line 2 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor"
using CititorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor"
using CititorServer.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Email")]
    public partial class Email : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Enviar cotización</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor"
                  mail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor"
                                       SendEmail

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.OpenElement(7, "tr");
                __builder2.AddMarkupContent(8, "<td>Email:</td>\r\n        ");
                __builder2.OpenElement(9, "td");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "type", "text");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor"
                                      mail.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mail.Email = __value, mail.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "<td>Subject:</td>\r\n        ");
                __builder2.OpenElement(17, "td");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor"
                                      mail.Subject

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mail.Subject = __value, mail.Subject));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "tr");
                __builder2.AddMarkupContent(24, "<td>Body:</td>\r\n        ");
                __builder2.OpenElement(25, "td");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor"
                                      mail.Body

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mail.Body = __value, mail.Body));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.AddMarkupContent(31, "<tr><td colspan=\"2\"><input type=\"submit\" class=\"btn-success\" value=\"Send\"></td></tr>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\victo\Documents\Universidad Santiago\.Net\Hade_Store\CititorServer\CititorServer\Pages\Email.razor"
 
    MailRequest mail = new MailRequest();

    private void SendEmail()
    {
        EmailSenderService.SendEmailAsync(mail);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmailSenderService EmailSenderService { get; set; }
    }
}
#pragma warning restore 1591
