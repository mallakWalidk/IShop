#pragma checksum "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84325c7a68accea43d8fb20972f2fd892d20024"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_invoice), @"mvc.1.0.view", @"/Views/User/invoice.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Malla\source\repos\First Project\First Project\Views\_ViewImports.cshtml"
using First_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Malla\source\repos\First Project\First Project\Views\_ViewImports.cshtml"
using First_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84325c7a68accea43d8fb20972f2fd892d20024", @"/Views/User/invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a68f0be254b764138254c4e012429a4ba67772d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<First_Project.Models.OrderProduct>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
  
    Layout="~/Views/Shared/_Layout12.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n  <div class=\"card-body\">\r\n    <div class=\"container mb-5 mt-3\">\r\n      <div class=\"row d-flex align-items-baseline\">\r\n");
            WriteLiteral(@"        <hr>
      </div>

      <div class=""container"">
        <div class=""col-md-12"">
          <div class=""text-center"">
            <h1 style=""color:#E88F2A ;""> IShop </h1>
          </div>

        </div>


        <div class=""row"">
          <div class=""col-xl-8"">
            <ul class=""list-unstyled"">
              <li class=""text-muted"">To: <span style=""color:#5d9fc5 ;"">");
#nullable restore
#line 34 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
                                                                  Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
            </ul>
          </div>
          <div class=""col-xl-4"">
            <p class=""text-muted"">Invoice</p>
            <ul class=""list-unstyled"">
              <li class=""text-muted""><i class=""fas fa-circle"" style=""color:#E88F2A ;""></i> <span
                  class=""fw-bold"">ID:</span>#");
#nullable restore
#line 41 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
                                        Write(Model.First().Order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li class=\"text-muted\"><i class=\"fas fa-circle\" style=\"color:#E88F2A ;\"></i> <span\r\n                  class=\"fw-bold\">Creation Date: </span>");
#nullable restore
#line 43 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
                                                   Write(Model.First().Order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ul>
          </div>
        </div>

        <div class=""row my-2 mx-1 justify-content-center"">
          <table class=""table table-striped table-borderless"">
            <thead style=""background-color:#E88F2A ;"" class=""text-white"">
              <tr>
                <th scope=""col"">Description</th>
                <th scope=""col"">Qty</th>
                <th scope=""col"">Unit Price</th>
              </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 58 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
                 foreach(var item in Model)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <tr>\r\n                <td> ");
#nullable restore
#line 61 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
                Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 62 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 63 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
               Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>

          </table>
        </div>
        <div class=""row"">
          <div class=""col-xl-3"">
            <p class=""text-black float-start""><span class=""text-black me-3""> Total Amount</span><span
                style=""font-size: 25px;"">");
#nullable restore
#line 73 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\invoice.cshtml"
                                    Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" JD</span></p>\r\n          </div>\r\n        </div>\r\n        <hr>\r\n        <div class=\"row\">\r\n          <div class=\"col-xl-10\">\r\n            <p>Thank you for your purchase</p>\r\n\r\n          </div>\r\n        </div>\r\n\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<First_Project.Models.OrderProduct>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
