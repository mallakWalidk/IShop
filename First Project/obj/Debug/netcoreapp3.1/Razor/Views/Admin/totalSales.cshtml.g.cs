#pragma checksum "C:\Users\Malla\source\repos\First Project\First Project\Views\Admin\totalSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "624286aac6afa6761b264b4c70c8e8d13cedb18c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_totalSales), @"mvc.1.0.view", @"/Views/Admin/totalSales.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"624286aac6afa6761b264b4c70c8e8d13cedb18c", @"/Views/Admin/totalSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a68f0be254b764138254c4e012429a4ba67772d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_totalSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<First_Project.Models.sales>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Malla\source\repos\First Project\First Project\Views\Admin\totalSales.cshtml"
  
    ViewData["Title"] = "totalSales";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\" id=\"T\">\r\n    <thead>\r\n        <tr>\r\n            <th>Customer Name </th>\r\n            <th>Product Name </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\Malla\source\repos\First Project\First Project\Views\Admin\totalSales.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Malla\source\repos\First Project\First Project\Views\Admin\totalSales.cshtml"
               Write(item.store.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Malla\source\repos\First Project\First Project\Views\Admin\totalSales.cshtml"
               Write(item.order.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\Malla\source\repos\First Project\First Project\Views\Admin\totalSales.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<First_Project.Models.sales>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
