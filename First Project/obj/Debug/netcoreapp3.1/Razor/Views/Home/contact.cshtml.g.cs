#pragma checksum "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d7501c376b936538331e1aae4468f979714bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_contact), @"mvc.1.0.view", @"/Views/Home/contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d7501c376b936538331e1aae4468f979714bf1", @"/Views/Home/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a68f0be254b764138254c4e012429a4ba67772d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\contact.cshtml"
   
    Layout="~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     <!-- Page Header Start -->
    <div class=""container-fluid bg-dark bg-img p-5 mb-5"">
        <div class=""row"">
            <div class=""col-12 text-center"">
                <h1 class=""display-4 text-uppercase text-white"">Contact Us</h1>
            </div>
        </div>
    </div>
    <!-- Page Header End -->

    <!-- Contact Start -->
    <div class=""container-fluid contact position-relative px-5"" style=""margin-top: 90px;"">
        <div class=""container"">
            <div class=""row g-5 mb-5"">
               
                <div class=""col-lg-3 col-md-6"">
                    <div class=""bg-primary border-inner text-center text-white p-5"">
                        <i class=""bi bi-envelope-open fs-1 text-white""></i>
                        <h6 class=""text-uppercase my-2"">Email Us</h6>
                        <span>");
#nullable restore
#line 24 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\contact.cshtml"
                         Write(ViewBag.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6"">
                    <div class=""bg-primary border-inner text-center text-white p-5"">
                        <i class=""bi bi-phone-vibrate fs-1 text-white""></i>
                        <h6 class=""text-uppercase my-2"">Call Us</h6>
                        <span>+");
#nullable restore
#line 31 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\contact.cshtml"
                          Write(ViewBag.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
                                <div class=""col-lg-3 col-md-6"">
                    <div class=""bg-primary border-inner text-center text-white p-5"">
                        <i class=""fa-brands fa-instagram-square fs-2 text-white""></i>
                        <h6 class=""text-uppercase my-2"">Follow us</h6>
                        <span>www.instagram.com/ ");
#nullable restore
#line 38 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\contact.cshtml"
                                            Write(ViewBag.instagram);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6"">
                    <div class=""bg-primary border-inner text-center text-white p-5"">
                       <i class=""fa-brands fa-facebook fs-2 text-white""></i>
                        <h6 class=""text-uppercase my-2"">Follow us</h6>
                        <span>www.facebook.com/ ");
#nullable restore
#line 45 "C:\Users\Malla\source\repos\First Project\First Project\Views\Home\contact.cshtml"
                                           Write(ViewBag.facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Contact End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
