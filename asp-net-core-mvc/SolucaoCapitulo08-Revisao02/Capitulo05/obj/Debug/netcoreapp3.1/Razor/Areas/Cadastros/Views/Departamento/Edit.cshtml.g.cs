#pragma checksum "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Cadastros\Views\Departamento\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50eaf151da4e5832ba503421c62bed8c9d8f6a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cadastros_Views_Departamento_Edit), @"mvc.1.0.view", @"/Areas/Cadastros/Views/Departamento/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50eaf151da4e5832ba503421c62bed8c9d8f6a7e", @"/Areas/Cadastros/Views/Departamento/Edit.cshtml")]
    public class Areas_Cadastros_Views_Departamento_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Modelo.Cadastros.Departamento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Cadastros\Views\Departamento\Edit.cshtml"
  
    Layout = "_LayoutIES";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-block"">
    <div class=""card-header text-white bg-secondary text-center h1"">Alterando um departamento existente</div>
    <div class=""card-body"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""DepartamentoID"" />
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""InstituicaoID"" class=""control-label""></label>
                <select asp-for=""InstituicaoID"" class=""form-control""");
            BeginWriteAttribute("asp-items", " asp-items=", 870, "", 902, 1);
#nullable restore
#line 19 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Cadastros\Views\Departamento\Edit.cshtml"
WriteAttributeValue("", 881, ViewBag.Instituicoes, 881, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></select>
            </div>
            <div class=""form-group text-center h3"">
                <input type=""submit"" value=""Atualizar Departamento"" class=""btn btn-primary"" />
                <a asp-action=""Index"" class=""btn btn-warning"">Retornar à listagem de departamentos</a>
            </div>
        </form>
    </div>
</div>

");
            DefineSection("ScriptPage", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Cadastros\Views\Departamento\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Modelo.Cadastros.Departamento> Html { get; private set; }
    }
}
#pragma warning restore 1591