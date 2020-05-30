#pragma checksum "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Admin\FichierScanne3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73cce7aabf4ab9c08178e47fd515406484db6499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_FichierScanne3), @"mvc.1.0.view", @"/Views/Admin/FichierScanne3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/FichierScanne3.cshtml", typeof(AspNetCore.Views_Admin_FichierScanne3))]
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
#line 1 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73cce7aabf4ab9c08178e47fd515406484db6499", @"/Views/Admin/FichierScanne3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_FichierScanne3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Admin\FichierScanne3.cshtml"
  
    ViewBag.Title = "Fichier Scanné 3 ème année";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(114, 1709, true);
            WriteLiteral(@"
<div class=""container-fluid"">

    <h4 class=""font-weight-bold text-center pt-3 pb-5"">Fichier des Diplomes 3 ème anné</h4>
    <div class=""row mb-4 offset-3"">
        <div class=""col-md-6"">
            <input type=""text"" class=""form-control"" id=""cne"" placeholder=""Entrer le cne de l'étudiant"" />
        </div>
        <div class=""col-md-2"">
            <button id=""search"" class=""btn btn-primary btn-block"">Search</button>
        </div>
    </div>
    <table class=""table table-bordered"">
        <tr>
            <th class=""text-center"">ID</th>
            <th class=""text-center"">Diplome 1</th>
            <th class=""text-center"">Diplome 2</th>
            <th class=""text-center"">Diplome 3</th>
        </tr>
        <tbody id=""tbody""></tbody>
    </table>

</div>
<!-- /.container-fluid -->


<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {
        //search button
        $(""#search"").click(functio");
            WriteLiteral(@"n () {
            $.get(""/Admin/FichierScanne"", { cne: $(""#cne"").val(), niveau: 3 }, function (data) {
                $(""#tbody"").empty();
                $.each(data, function (index, row) {
                    $(""#tbody"").append(""<tr><td>"" + row.id + ""</td><td><a href=\""../../DiplomeScanné/"" + row.nom.split(""|"")[0] + ""\"" download>"" + row.nom.split(""|"")[0] + ""</a></td><td><a href=\""../../DiplomeScanné/"" + row.nom.split(""|"")[1] + ""\"" download>"" + row.nom.split(""|"")[1] + ""</a></td><td><a href=\""../../DiplomeScanné/"" + row.nom.split(""|"")[2] + ""\"" download>"" + row.nom.split(""|"")[2] + ""</a></td></tr>"");
                });
            });
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
