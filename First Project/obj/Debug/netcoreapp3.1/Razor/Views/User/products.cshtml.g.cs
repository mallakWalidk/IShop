#pragma checksum "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55c095340d7a1a4cab7064786944bf2e2e74ecf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_products), @"mvc.1.0.view", @"/Views/User/products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c095340d7a1a4cab7064786944bf2e2e74ecf2", @"/Views/User/products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a68f0be254b764138254c4e012429a4ba67772d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<First_Project.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml"
  
    Layout="~/Views/Shared/_Layout12.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

     <!-- Page Header Start -->
    <div class=""container-fluid bg-dark bg-img p-5 mb-5"">
        <div class=""row"">
            <div class=""col-12 text-center"">
                <h1 class=""display-4 text-uppercase text-white""> Produts </h1>
            </div>
        </div>
    </div>
    <!-- Page Header End -->

    <!-- Contact Start -->
    <div class=""container-fluid contact position-relative px-5"" style=""margin-top: 90px;"">
        <div class=""container"">
            <div class=""row g-5 mb-5"">

");
#nullable restore
#line 22 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml"
                foreach (var item in Model)
                { 
              

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-4 col-md-6\">\r\n         <div class=\"bg-primary border-inner text-center text-white p-5\">\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n  <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=", 1263, "", 1309, 1);
#nullable restore
#line 33 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml"
WriteAttributeValue("", 1268, Url.Content("~/Image/" + item.ImagePath), 1268, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" style=\"width: 280px; height:300px;\">\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">");
#nullable restore
#line 35 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n  </div>\r\n  <ul class=\"list-group list-group-flush\">\r\n    <li class=\"list-group-item\">Price: ");
#nullable restore
#line 38 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml"
                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" JD</li>\r\n    <li class=\"list-group-item\">Category: ");
#nullable restore
#line 39 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml"
                                     Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n  </ul>\r\n             <div class=\"mt-3 mb-3\"> <button class=\"btn btn-dark btn-block\">  <a");
            BeginWriteAttribute("href", " href=\"", 1712, "\"", 1741, 2);
            WriteAttributeValue("", 1719, "/user/product/", 1719, 14, true);
#nullable restore
#line 41 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml"
WriteAttributeValue("", 1733, item.Id, 1733, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Buy Now </a>  </button> </div>\r\n\r\n</div>\r\n         </div>\r\n         </div>\r\n");
#nullable restore
#line 46 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\products.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <!-- Contact End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<First_Project.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591