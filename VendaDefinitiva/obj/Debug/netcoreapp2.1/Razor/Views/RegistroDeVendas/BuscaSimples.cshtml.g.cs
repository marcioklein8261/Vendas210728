#pragma checksum "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94092bbed8566364aac76b8d112b88a4909e3a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroDeVendas_BuscaSimples), @"mvc.1.0.view", @"/Views/RegistroDeVendas/BuscaSimples.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroDeVendas/BuscaSimples.cshtml", typeof(AspNetCore.Views_RegistroDeVendas_BuscaSimples))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94092bbed8566364aac76b8d112b88a4909e3a36", @"/Views/RegistroDeVendas/BuscaSimples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e758dc3e3bf9e0239497b7bf2d9fa7766e001b", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroDeVendas_BuscaSimples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VendaDefinitiva.Models.RegistroDeVenda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
  
    ViewData["Title"] = "Busca Simples";

#line default
#line hidden
            BeginContext(109, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(116, 17, false);
#line 6 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(222, 653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c3f4cfd7dd84f14893be6e0033fdcbe", async() => {
                BeginContext(274, 213, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"Inicial\">Início</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"inicial\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 487, "", 514, 1);
#line 14 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
WriteAttributeValue("", 494, ViewData["Inicial"], 494, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(514, 197, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"Final\">Final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"Final\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 711, "", 736, 1);
#line 18 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
WriteAttributeValue("", 718, ViewData["Final"], 718, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(736, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(875, 136, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(1012, 43, false);
#line 27 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 215, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1271, 38, false);
#line 34 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1389, 40, false);
#line 37 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1509, 44, false);
#line 40 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 83, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        <!--");
            EndContext();
            BeginContext(1637, 62, false);
#line 43 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayNameFor(model => model.Vendedor.Departamento.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 97, true);
            WriteLiteral("--> Departamento\r\n\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1797, 42, false);
#line 47 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1919, 42, false);
#line 50 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 55 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2121, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2206, 37, false);
#line 59 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2335, 39, false);
#line 62 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(2374, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2466, 48, false);
#line 65 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2606, 61, false);
#line 68 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendedor.Departamento.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2667, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2759, 41, false);
#line 71 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2800, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2892, 41, false);
#line 74 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2933, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaSimples.cshtml"
                }

#line default
#line hidden
            BeginContext(3012, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VendaDefinitiva.Models.RegistroDeVenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
