#pragma checksum "D:\_DESENVOLVIMENTO\CODIGO FONTE\ControleEstoQueTech\Controle_Estoque\Views\EntradaSaida\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EntradaSaida_Index), @"mvc.1.0.view", @"/Views/EntradaSaida/Index.cshtml")]
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
#line 1 "D:\_DESENVOLVIMENTO\CODIGO FONTE\ControleEstoQueTech\Controle_Estoque\Views\_ViewImports.cshtml"
using Controle_Estoque;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_DESENVOLVIMENTO\CODIGO FONTE\ControleEstoQueTech\Controle_Estoque\Views\_ViewImports.cshtml"
using Controle_Estoque.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_DESENVOLVIMENTO\CODIGO FONTE\ControleEstoQueTech\Controle_Estoque\Views\_ViewImports.cshtml"
using DataAcess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_DESENVOLVIMENTO\CODIGO FONTE\ControleEstoQueTech\Controle_Estoque\Views\_ViewImports.cshtml"
using DataAcess.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c27", @"/Views/EntradaSaida/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d500299160255b55dbb0d5455bc17f9cc2765b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_EntradaSaida_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VMModalCadHome>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"CadastroBairro\" class=\" modalCadastro\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c273914", async() => {
                WriteLiteral(@"
        <div>
            <h3 style=""background-color: #106b45; color: white; margin: 0; padding: 13px; text-align: center;"">
                ENTRADA E SAIDA DE PRODUTOS
            </h3>
        </div>

        <!-- <div class=""form-group  row m-2"">
                  <label class=""p-0"">Bairro</label> -->
        <!-- <input placeholder=""Bairro ""> -->
        <!--
                  <select class=""form form-control"">
                      <option >JD Florianopolis</option>
                      <option>JD união</option>
                  </select>
              </div> -->

        <div class=""row "" style=""padding: 10px;"">


            <div class=""col-12 form-group"">
                <label>NOME DO PRODUTO</label>
                <input class=""margin9 form-control"" type=""text""");
                BeginWriteAttribute("name", " name=\"", 893, "\"", 900, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 901, "\"", 906, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row \" style=\"padding: 10px;\">\r\n            <div class=\"col-3 form-group\">\r\n                <label>ESTOQUE MÁXIMO</label>\r\n                <input class=\"margin9 form-control\" type=\"date\"");
                BeginWriteAttribute("name", " name=\"", 1153, "\"", 1160, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1161, "\"", 1166, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n\r\n            <div class=\"col-3 form-group\">\r\n                <label>QUANTIDADE</label>\r\n                <input class=\"margin9 form-control\" type=\"number\"");
                BeginWriteAttribute("name", " name=\"", 1344, "\"", 1351, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1352, "\"", 1357, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n\r\n            <div class=\"col-3 form-group\">\r\n                <label>VALOR</label>\r\n                <input class=\"margin9 form-control\" type=\"number\"");
                BeginWriteAttribute("name", " name=\"", 1530, "\"", 1537, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1538, "\"", 1543, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n\r\n            <div class=\"col-3 form-group\">\r\n                <label>TOTAL</label>\r\n                <input class=\"margin9 form-control\" type=\"number\"");
                BeginWriteAttribute("name", " name=\"", 1716, "\"", 1723, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1724, "\"", 1729, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"row \" style=\"padding: 10px;\">\r\n\r\n            <div class=\"col-4 form-group\">\r\n                <label>TIPO</label>\r\n                <select class=\"form form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c277438", async() => {
                    WriteLiteral("JD Florianopolis");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c278482", async() => {
                    WriteLiteral("JD união");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n\r\n            <div class=\"col-4 form-group\">\r\n                <label>CATEGORIA</label>\r\n                <select class=\"form form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c279721", async() => {
                    WriteLiteral("JD Florianopolis");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c2710765", async() => {
                    WriteLiteral("JD união");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n\r\n            <div class=\"col-4 form-group\">\r\n                <label>FORNECEDOR</label>\r\n                <select class=\"form form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c2712006", async() => {
                    WriteLiteral("JD Florianopolis");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cac5d6e4cbde9bbbbe8db9b51e8a5a43938c2713051", async() => {
                    WriteLiteral("JD união");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>




        </div>


        <div class=""m-2"" style="" height: 112px;"">
            <div class=""row"" style=""padding-left: 14px; padding-top: 23px;    padding-left: 14px;
        padding-top: 23px;
        WIDTH: 44%;
        MARGIN: auto;"">

                <div class=""col-2 Width144 form-group"">
                    <button class=""form-control heigth63 btnVoltar"">VOLTAR</button>
                </div>
                <div class=""col-2 Width144 form-group"">
                    <button class=""form-control heigth63 btnSalvar"">SALVAR</button>
                </div>

            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>



<style>
    .modalCadastro {
        width: 90%;
        height: 80%;
        /* margin: 0; */
        /* padding: 0; */
        max-width: 740px;
        margin-left: 174px;
        border: 1px solid #00000038;
        margin-top: 29px;
        /* padding: 8px; */
        border-radius: 4px;
    }

    .heigth63 {
        height: 63px;
    }

    .Width144 {
        width: 144px;
    }

    a {
        text-decoration: none;
    }

    .modal a.close-modal {
        top: 12.5px;
        margin-right: 19px;
    }

    .btnSalvar {
        background-color: #177117;
        color: white;
        width: 125px;
        margin-left: 111px;
    }

    .btnVoltar {
        color: white;
        background-color: #0e330e;
        width: 125px;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VMModalCadHome> Html { get; private set; }
    }
}
#pragma warning restore 1591
