#pragma checksum "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "795d0d52098931f7a8b0d418221895a5dcb7c4ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendedores_Detalhes), @"mvc.1.0.view", @"/Views/Vendedores/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendedores/Detalhes.cshtml", typeof(AspNetCore.Views_Vendedores_Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795d0d52098931f7a8b0d418221895a5dcb7c4ed", @"/Views/Vendedores/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e758dc3e3bf9e0239497b7bf2d9fa7766e001b", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendedores_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VendaDefinitiva.Models.Vendedor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
  
    ViewData["Titlle"] = "Detalhes";

#line default
#line hidden
            BeginContext(85, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(92, 18, false);
#line 6 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
Write(ViewData["Titlle"]);

#line default
#line hidden
            EndContext();
            BeginContext(110, 100, true);
            WriteLiteral("</h2>\r\n<div>\r\n    <h4>Vendedor</h4>\r\n\r\n\r\n    <dl class=\" dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(211, 40, false);
#line 13 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 36, false);
#line 16 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(331, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(377, 41, false);
#line 20 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(418, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(462, 37, false);
#line 23 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(499, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(543, 52, false);
#line 26 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDeNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(595, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(639, 48, false);
#line 29 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.DataDeNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(687, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(731, 47, false);
#line 32 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.SalarioBase));

#line default
#line hidden
            EndContext();
            BeginContext(778, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(822, 43, false);
#line 35 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.SalarioBase));

#line default
#line hidden
            EndContext();
            BeginContext(865, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(909, 48, false);
#line 38 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(957, 45, true);
            WriteLiteral("\r\n\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1003, 49, false);
#line 42 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Departamento.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 51, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1103, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17f46e07dd4b4c4687c283fca4387a97", async() => {
                BeginContext(1150, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\klein\OneDrive\Dropbox\CursoCSharpNelioAlves\CursoCSharpNelioAlves\Course\VendaDefinitiva\VendaDefinitiva\Views\Vendedores\Detalhes.cshtml"
                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1158, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1164, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26179868d0f1464094e7c8584b0fbb83", async() => {
                BeginContext(1188, 18, true);
                WriteLiteral("Volta para a lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1210, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VendaDefinitiva.Models.Vendedor> Html { get; private set; }
    }
}
#pragma warning restore 1591
