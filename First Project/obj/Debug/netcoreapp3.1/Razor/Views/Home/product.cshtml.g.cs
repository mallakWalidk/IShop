#pragma checksum "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5952774d90f10dd5a52f0f356a0358dda35653d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_product), @"mvc.1.0.view", @"/Views/Home/product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5952774d90f10dd5a52f0f356a0358dda35653d", @"/Views/Home/product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a68f0be254b764138254c4e012429a4ba67772d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<First_Project.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\product.cshtml"
  
    Layout="~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
     
        <!-- Product section-->
        <section class=""py-5"">
            <div class=""container px-4 px-lg-5 my-5"">
                <div class=""row gx-4 gx-lg-5 align-items-center"">
                    <div class=""col-md-6""><img class=""card-img-top mb-5 mb-md-0""");
            BeginWriteAttribute("src", " src=", 385, "", 440, 1);
#nullable restore
#line 11 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\product.cshtml"
WriteAttributeValue("", 390, Url.Content("~/Image/" + Model.First().ImagePath), 390, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" /></div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"small mb-1\"></div>\r\n                        <h1 class=\"display-5 fw-bolder\">");
#nullable restore
#line 14 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\product.cshtml"
                                                   Write(Model.First().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                        <div class=\"fs-5 mb-5\">\r\n                            <span>");
#nullable restore
#line 16 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\product.cshtml"
                             Write(Model.First().Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" JD</span>\r\n                        </div>\r\n                        <p class=\"lead\">");
#nullable restore
#line 18 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\product.cshtml"
                                   Write(Model.First().Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""d-flex"">
                            <input class=""form-control text-center me-3"" id=""inputQuantity"" type=""number"" value=""1"" style=""max-width: 3rem"" />
                            <button class=""btn btn-outline-dark flex-shrink-0"" onclick=""showAlert()"" type=""button"">
                                <i class=""bi-cart-fill me-1""></i>
                                Add to cart
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </section>
       ");
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
