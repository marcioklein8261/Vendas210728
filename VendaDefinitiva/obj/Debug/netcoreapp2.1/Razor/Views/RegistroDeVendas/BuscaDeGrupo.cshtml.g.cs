#pragma checksum "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aedd6f98ddb436661135d1c4b79d7deaaa2457c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroDeVendas_BuscaDeGrupo), @"mvc.1.0.view", @"/Views/RegistroDeVendas/BuscaDeGrupo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroDeVendas/BuscaDeGrupo.cshtml", typeof(AspNetCore.Views_RegistroDeVendas_BuscaDeGrupo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aedd6f98ddb436661135d1c4b79d7deaaa2457c8", @"/Views/RegistroDeVendas/BuscaDeGrupo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e758dc3e3bf9e0239497b7bf2d9fa7766e001b", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroDeVendas_BuscaDeGrupo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Departamento, RegistroDeVenda>>>
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
  
    ViewData["Title"] = "Procura em Grupo";
    DateTime Inicial = DateTime.Parse(ViewData["Inicial"] as string);
    DateTime Final = DateTime.Parse(ViewData["Final"] as string);

#line default
#line hidden
            BeginContext(254, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(261, 17, false);
#line 9 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(278, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(367, 653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d6691a65234ff6877abc838b2d6f9a", async() => {
                BeginContext(419, 218, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"Inicial\">Min Inicial</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"Inicial\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 637, "", 663, 1);
#line 17 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
WriteAttributeValue("", 644, ViewData["Incial"], 644, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(663, 195, true);
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"Final\">Final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"Final\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 858, "", 883, 1);
#line 21 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
WriteAttributeValue("", 865, ViewData["Final"], 865, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(883, 130, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
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
            BeginContext(1020, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 29 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
 foreach (var departmentGroup in Model)
{

#line default
#line hidden
            BeginContext(1088, 125, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Departamento ");
            EndContext();
            BeginContext(1214, 24, false);
#line 33 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
                                            Write(departmentGroup.Key.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 20, true);
            WriteLiteral(", Total de Vendas = ");
            EndContext();
            BeginContext(1259, 67, false);
#line 33 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
                                                                                         Write(departmentGroup.Key.VendaTotalDoDepto(Inicial,Final).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 663, true);
            WriteLiteral(@"</h3>

        
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Data
                        </th>
                        <th>
                            Amount
                        </th>
                        <th>
                            Vendedor
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 56 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
                     foreach (var item in departmentGroup)
                    {

#line default
#line hidden
            BeginContext(2072, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2169, 39, false);
#line 60 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(2208, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2312, 41, false);
#line 63 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2353, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2457, 48, false);
#line 66 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2505, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2609, 41, false);
#line 69 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2650, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 72 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
                    }

#line default
#line hidden
            BeginContext(2741, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 77 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\RegistroDeVendas\BuscaDeGrupo.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Departamento, RegistroDeVenda>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
