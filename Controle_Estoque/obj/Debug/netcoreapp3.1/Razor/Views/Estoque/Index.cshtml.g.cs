#pragma checksum "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d41a221afc5bfb595033ceda259949b48181b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estoque_Index), @"mvc.1.0.view", @"/Views/Estoque/Index.cshtml")]
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
#line 1 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\_ViewImports.cshtml"
using Controle_Estoque;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\_ViewImports.cshtml"
using Controle_Estoque.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\_ViewImports.cshtml"
using DataAcess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\_ViewImports.cshtml"
using DataAcess.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d41a221afc5bfb595033ceda259949b48181b5f", @"/Views/Estoque/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d500299160255b55dbb0d5455bc17f9cc2765b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Estoque_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Produto</th>
            <th scope=""col"">Descrição</th>
            <th scope=""col"">Fornecedor</th>
            <th scope=""col"">Tipo Unitario</th>
            <th scope=""col"">Categoria</th>
            <th scope=""col"">Quantidade</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml"
         foreach (var item in ViewBag.lista)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">1</th>\r\n            <td>");
#nullable restore
#line 20 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml"
           Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml"
           Write(item.Produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml"
           Write(item.Produto.fornecedor.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml"
           Write(item.Produto.tipoUnitario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml"
           Write(item.Produto.categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml"
           Write(item.QuantidadeEstoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "E:\_DEV BRENO-MORAIS\_Código-Fonte\Controle_Estoque\Controle_Estoque\Views\Estoque\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
