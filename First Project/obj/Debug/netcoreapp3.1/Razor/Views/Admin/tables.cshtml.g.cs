#pragma checksum "C:\Users\Malla\source\repos\First Project\First Project\Views\Admin\tables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3bcc69af1bdc300ed3e81acdb20a3ff83c7f89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_tables), @"mvc.1.0.view", @"/Views/Admin/tables.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3bcc69af1bdc300ed3e81acdb20a3ff83c7f89", @"/Views/Admin/tables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a68f0be254b764138254c4e012429a4ba67772d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_tables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Malla\source\repos\First Project\First Project\Views\Admin\tables.cshtml"
    
    Layout="~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- Table Start -->
            <div class=""container-fluid pt-4 px-4"">
                <div class=""row g-4"">
                    <div class=""col-sm-12 col-xl-6"">
                        <div class=""bg-light rounded h-100 p-4"">
                            <h6 class=""mb-4"">Basic Table</h6>
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">First Name</th>
                                        <th scope=""col"">Last Name</th>
                                        <th scope=""col"">Email</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope=""row"">1</th>
                                        <td>John</td>
                 ");
            WriteLiteral(@"                       <td>Doe</td>
                                        <td>jhon@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">2</th>
                                        <td>Mark</td>
                                        <td>Otto</td>
                                        <td>mark@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">3</th>
                                        <td>Jacob</td>
                                        <td>Thornton</td>
                                        <td>jacob@email.com</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""col-sm-12 col-xl-6"">
                        <div cl");
            WriteLiteral(@"ass=""bg-light rounded h-100 p-4"">
                            <h6 class=""mb-4"">Accented Table</h6>
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">First Name</th>
                                        <th scope=""col"">Last Name</th>
                                        <th scope=""col"">Email</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope=""row"">1</th>
                                        <td>John</td>
                                        <td>Doe</td>
                                        <td>jhon@email.com</td>
                                    </tr>
                                    <tr>
       ");
            WriteLiteral(@"                                 <th scope=""row"">2</th>
                                        <td>Mark</td>
                                        <td>Otto</td>
                                        <td>mark@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">3</th>
                                        <td>Jacob</td>
                                        <td>Thornton</td>
                                        <td>jacob@email.com</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""col-sm-12 col-xl-6"">
                        <div class=""bg-light rounded h-100 p-4"">
                            <h6 class=""mb-4"">Hoverable Table</h6>
                            <table class=""table table-hover"">
                             ");
            WriteLiteral(@"   <thead>
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">First Name</th>
                                        <th scope=""col"">Last Name</th>
                                        <th scope=""col"">Email</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope=""row"">1</th>
                                        <td>John</td>
                                        <td>Doe</td>
                                        <td>jhon@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">2</th>
                                        <td>Mark</td>
                                        <td>Otto</td>
                            ");
            WriteLiteral(@"            <td>mark@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">3</th>
                                        <td>Jacob</td>
                                        <td>Thornton</td>
                                        <td>jacob@email.com</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""col-sm-12 col-xl-6"">
                        <div class=""bg-light rounded h-100 p-4"">
                            <h6 class=""mb-4"">Color Table</h6>
                            <table class=""table table-dark"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">First Name</th>
         ");
            WriteLiteral(@"                               <th scope=""col"">Last Name</th>
                                        <th scope=""col"">Email</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope=""row"">1</th>
                                        <td>John</td>
                                        <td>Doe</td>
                                        <td>jhon@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">2</th>
                                        <td>Mark</td>
                                        <td>Otto</td>
                                        <td>mark@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">3</th>
              ");
            WriteLiteral(@"                          <td>Jacob</td>
                                        <td>Thornton</td>
                                        <td>jacob@email.com</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""col-sm-12 col-xl-6"">
                        <div class=""bg-light rounded h-100 p-4"">
                            <h6 class=""mb-4"">Bordered Table</h6>
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">First Name</th>
                                        <th scope=""col"">Last Name</th>
                                        <th scope=""col"">Email</th>
                                    </tr>
                   ");
            WriteLiteral(@"             </thead>
                                <tbody>
                                    <tr>
                                        <th scope=""row"">1</th>
                                        <td>John</td>
                                        <td>Doe</td>
                                        <td>jhon@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">2</th>
                                        <td>Mark</td>
                                        <td>Otto</td>
                                        <td>mark@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">3</th>
                                        <td>Jacob</td>
                                        <td>Thornton</td>
                                        <td>jacob@email.com</td>
                          ");
            WriteLiteral(@"          </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""col-sm-12 col-xl-6"">
                        <div class=""bg-light rounded h-100 p-4"">
                            <h6 class=""mb-4"">Table Without Border</h6>
                            <table class=""table table-borderless"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">First Name</th>
                                        <th scope=""col"">Last Name</th>
                                        <th scope=""col"">Email</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope=""row"">1</th>
               ");
            WriteLiteral(@"                         <td>John</td>
                                        <td>Doe</td>
                                        <td>jhon@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">2</th>
                                        <td>Mark</td>
                                        <td>Otto</td>
                                        <td>mark@email.com</td>
                                    </tr>
                                    <tr>
                                        <th scope=""row"">3</th>
                                        <td>Jacob</td>
                                        <td>Thornton</td>
                                        <td>jacob@email.com</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div cla");
            WriteLiteral(@"ss=""col-12"">
                        <div class=""bg-light rounded h-100 p-4"">
                            <h6 class=""mb-4"">Responsive Table</h6>
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">#</th>
                                            <th scope=""col"">First Name</th>
                                            <th scope=""col"">Last Name</th>
                                            <th scope=""col"">Email</th>
                                            <th scope=""col"">Country</th>
                                            <th scope=""col"">ZIP</th>
                                            <th scope=""col"">Status</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                      ");
            WriteLiteral(@"                  <tr>
                                            <th scope=""row"">1</th>
                                            <td>John</td>
                                            <td>Doe</td>
                                            <td>jhon@email.com</td>
                                            <td>USA</td>
                                            <td>123</td>
                                            <td>Member</td>
                                        </tr>
                                        <tr>
                                            <th scope=""row"">2</th>
                                            <td>Mark</td>
                                            <td>Otto</td>
                                            <td>mark@email.com</td>
                                            <td>UK</td>
                                            <td>456</td>
                                            <td>Member</td>
                                        </tr>");
            WriteLiteral(@"
                                        <tr>
                                            <th scope=""row"">3</th>
                                            <td>Jacob</td>
                                            <td>Thornton</td>
                                            <td>jacob@email.com</td>
                                            <td>AU</td>
                                            <td>789</td>
                                            <td>Member</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Table End -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591