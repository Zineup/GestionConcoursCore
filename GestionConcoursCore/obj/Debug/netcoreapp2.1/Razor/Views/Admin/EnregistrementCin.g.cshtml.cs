#pragma checksum "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Admin\EnregistrementCin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c194070854b38463be6358fe30b46422538e42cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EnregistrementCin), @"mvc.1.0.view", @"/Views/Admin/EnregistrementCin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EnregistrementCin.cshtml", typeof(AspNetCore.Views_Admin_EnregistrementCin))]
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
#line 1 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c194070854b38463be6358fe30b46422538e42cf", @"/Views/Admin/EnregistrementCin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EnregistrementCin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Admin\EnregistrementCin.cshtml"
  
    ViewData["Title"] = "EnregistrementCin";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(105, 3684, true);
            WriteLiteral(@"<div class=""container-fluid"">

    <div class=""row"">

        <!-- Approach -->
        <div class=""card shadow mb-4"" style=""margin: 20px 0 0 50px;"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Enregistrement des candidats</h6>
            </div>

            <!--CIN-->
            <div class=""card-body"" style=""width:600px;"">
                <p> <strong>CIN :</strong> </p>

                <div class=""d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"">
                    <div class=""input-group"">
                        <input type=""text"" id=""value"" class=""form-control bg-light border-0 small"" placeholder=""Entrer le CIN de votre étudiant ..."" aria-label=""Search"" aria-describedby=""basic-addon2"" style=""width:300px;"" />
                        <div class=""input-group-append"">
                            <button type=""submit"" class=""btn btn-primary"" id=""btn""> Submit </button>
                     ");
            WriteLiteral(@"   </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!--Ici, l'insertion des infos et tableau avec AJAX-->
    <div class=""container"" style='margin:50px;width:800px; background-color:white;'>
        <table class='table' id=""tablo""></table>
    </div>

    <div class=""container"">
        <table class='table' id=""tablo1""></table>
    </div>
</div>



<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {
        //submit button
        console.log(""ready"");
        $(""#btn"").on(""click"", function () {
            console.log(""clicking"");

            //fct seulement pr l'enregistrement
            $.get(""/Admin/generateNumDossier"", { cin: $(""#value"").val() }, function (date) {  //enters this scope if cin exists in db
                console.log(""fetch cin"");

                $(""#tablo"").empty();
                $(""#tablo1"").empty();


      ");
            WriteLiteral(@"          //informations sur le candidat :
                $.get(""/Admin/etudiantByCin"", { cin: $(""#value"").val() }, function (data) {

                    $.each(data, function (index, ligne) {
                        console.log(ligne);

                        //comme carte d'etudiant :
                        $(""#tablo"").append(

                            ""<tr><td> <img width='100' src='/images/ENSA.jpg' /> </td>"" +
                            ""<td rowspan='2'><img  src='/images/userPic/"" + ligne.photo + ""' alt='Personal picture' style='width:200px;'></td>""+
                            ""</tr > "" +
                            ""<td><span'><br>ENSA de Safi <br>Concours d'accès en <span>"" + ligne.niveau + ""</span>ème année</span></td>"" +
                            ""</tr>"" +
                            ""<tr><td>CIN : </td><td><span id='cin1' '>"" + ligne.cin + ""</span></td><tr>"" +
                            ""<tr><td>Num dossier : </td><td><span id='dossierr'>"" + ligne.num_dossier + ""</span> <");
            WriteLiteral(@"/td></tr>""
                        );

                        //infos générales sur le candidat :
                        $(""#tablo1"").append(
                            ""<thead><tr><th> Nom</th><th>Prénom</th><th>Filière</th><th>Diplôme</th><th>CNE</th></tr></thead>"" +
                            ""<tbody><tr><td>"" + ligne.nom + ""</td><td>"" + ligne.prenom + ""</td> <td>"" + ligne.nomFil + ""</td><td>"" + ligne.typeDipl + ""</td><td>"" + ligne.cne + ""</td></tr> </tbody > ""
                        );

                    });

                });


            });
        });
    });

</script>");
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
