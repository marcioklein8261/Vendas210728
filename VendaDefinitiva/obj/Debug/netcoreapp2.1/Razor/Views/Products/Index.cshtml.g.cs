#pragma checksum "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19544eceb5f4f81c851ad5254efffa06986e58b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\_ViewImports.cshtml"
using VendaDefinitiva;

#line default
#line hidden
#line 2 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\_ViewImports.cshtml"
using VendaDefinitiva.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19544eceb5f4f81c851ad5254efffa06986e58b2", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e758dc3e3bf9e0239497b7bf2d9fa7766e001b", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VendaDefinitiva.Models.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Produtos";

#line default
#line hidden
            BeginContext(100, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(107, 17, false);
#line 8 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 119, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(244, 47, false);
#line 14 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(291, 70, true);
            WriteLiteral("\r\n            </th>\r\n            >\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(362, 50, false);
#line 18 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnidadeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(412, 79, true);
            WriteLiteral("\r\n            </th>>\r\n           \r\n        </tr>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml"
         foreach(var item in Model)
            {

#line default
#line hidden
            BeginContext(543, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(616, 40, false);
#line 29 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(model=>item.NomeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(656, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(736, 45, false);
#line 32 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(model => item.UnidadeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(781, 54, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 36 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Products\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(850, 57, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n<p>Página de Produtos</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VendaDefinitiva.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
