#pragma checksum "C:\Users\Malla\source\repos\First Project\First Project\Views\User\product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6df3643c02adfc582bb5e6ba515e49d802fb3f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_product), @"mvc.1.0.view", @"/Views/User/product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df3643c02adfc582bb5e6ba515e49d802fb3f0d", @"/Views/User/product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a68f0be254b764138254c4e012429a4ba67772d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<First_Project.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\product.cshtml"
  
    Layout="~/Views/Shared/_Layout12.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     \r\n        <!-- Product section-->\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6df3643c02adfc582bb5e6ba515e49d802fb3f0d4172", async() => {
                WriteLiteral("\r\n\r\n        <section class=\"py-5\">\r\n            <div class=\"container px-4 px-lg-5 my-5\">\r\n                <div class=\"row gx-4 gx-lg-5 align-items-center\">\r\n                    <div class=\"col-md-6\"><img class=\"card-img-top mb-5 mb-md-0\"");
                BeginWriteAttribute("src", " src=", 437, "", 492, 1);
#nullable restore
#line 13 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\product.cshtml"
WriteAttributeValue("", 442, Url.Content("~/Image/" + Model.First().ImagePath), 442, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"...\" /></div>\r\n                    <div class=\"col-md-6\">\r\n                              <input type=\"text\" name=\"ProductId\" class=\"form-control\" id=\"validationDefault01\" \r\n                              placeholder=\"Full Name\"");
                BeginWriteAttribute("value", " value=", 724, "", 748, 1);
#nullable restore
#line 16 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\product.cshtml"
WriteAttributeValue("", 731, Model.First().Id, 731, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n\r\n                        <div class=\"small mb-1\"></div>\r\n                        <h1 class=\"display-5 fw-bolder\">");
#nullable restore
#line 19 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\product.cshtml"
                                                   Write(Model.First().Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h1>\r\n                        <div class=\"fs-5 mb-5\">\r\n                            <span>");
#nullable restore
#line 21 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\product.cshtml"
                             Write(Model.First().Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" JD</span>\r\n                        </div>\r\n                        <p class=\"lead\">");
#nullable restore
#line 23 "C:\Users\Malla\source\repos\First Project\First Project\Views\User\product.cshtml"
                                   Write(Model.First().Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        <div class=""d-flex"">
                            <input class=""form-control text-center me-3"" id=""inputQuantity"" type=""number"" value=""1"" style=""max-width: 3rem"" name=""Quantity"" />
                            <button class=""btn btn-outline-dark flex-shrink-0"" type=""submit"">
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
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n       ");
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
