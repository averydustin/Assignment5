#pragma checksum "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b284c41cbe6474095884a2715bbc85fff1e66b19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\_ViewImports.cshtml"
using Assignment5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\_ViewImports.cshtml"
using Assignment5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b284c41cbe6474095884a2715bbc85fff1e66b19", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876998f13cb4f63c53a124137e3bcbabf06324f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<header style=""text-align:center"" class=""font-weight-bold"">
    <h1>Amazon Book List</h1>
</header>



    <div>
        <div style=""padding:30px"">
            <table class=""table table-striped"">
                <thead class=""thead-dark"">
                    <tr>
                        <th style=""padding:20px"">Book ID</th>
                        <th style=""padding:20px"">Book Title</th>
                        <th style=""padding:20px"">Book Author Name</th>
                        <th style=""padding:20px"">Book Publisher</th>
                        <th style=""padding:20px"">Book ISBN</th>
                        <th style=""padding:20px"">Book Classification</th>
                        <th style=""padding:20px"">Book Category</th>
                        <th style=""padding:20px"">Book Price</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 28 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                     foreach(var x in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"padding:20px\">");
#nullable restore
#line 31 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                            Write(x.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"padding:20px\">");
#nullable restore
#line 32 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                            Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"padding:20px\">");
#nullable restore
#line 33 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                            Write(x.AuthFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                                         Write(x.AuthLast);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td style=\"padding:20px\">");
#nullable restore
#line 34 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                            Write(x.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"padding:20px\">");
#nullable restore
#line 35 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                            Write(x.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"padding:20px\">");
#nullable restore
#line 36 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                            Write(x.Classif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"padding:20px\">");
#nullable restore
#line 37 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                            Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"padding:20px\">");
#nullable restore
#line 38 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                                            Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\christy work\source\repos\Assignment5\Assignment5\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
