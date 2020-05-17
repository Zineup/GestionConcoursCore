#pragma checksum "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3d89bc1885853baf437613833e3678ec508a222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Step3), @"mvc.1.0.view", @"/Views/Auth/Step3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Step3.cshtml", typeof(AspNetCore.Views_Auth_Step3))]
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
#line 1 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d89bc1885853baf437613833e3678ec508a222", @"/Views/Auth/Step3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Step3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionConcoursCore.Models.DiplomeNote>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
  
    /**/

    /**/

    ViewBag.Title = "Step3";
    Layout = null;

#line default
#line hidden
            BeginContext(128, 550, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" />

<style>
    body {
        background: #7db4f3;
        background: -webkit-linear-gradient(-135deg, #7db4f3, #fdaee9dc);
        background: -o-linear-gradient(-135deg, #7db4f3, #fdaee9dc);
        background: -moz-linear-gradient(-135deg, #7db4f3, #fdaee9dc);
        background: linear-gradient(-135deg, #7db4f3, #fdaee9dc);
    }
</style>

<h2 class=""text-center mt-3 font-weight-bold"">Step 3 : Informations de Diplôme</h2>

");
            EndContext();
#line 24 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
 using (Html.BeginForm("Step3", "Auth", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(740, 263, true);
            WriteLiteral(@"    <hr class=""col-md-7 offset-md-2 mb-4"" />
    <div class=""row "" style=""padding-bottom: 40px"">
        <div class=""col-md-7 offset-3"">
            <div class=""form-group"">
                <h4 class=""register-heading text-white"">Diplome Obtenu</h4><br />

");
            EndContext();
#line 32 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
                 if (ViewBag.Niveau == "3")
                {

                    

#line default
#line hidden
            BeginContext(1090, 975, false);
#line 35 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
               Write(Html.DropDownListFor(model => model.Type,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="DUT", Value="DUT"},
                       new SelectListItem{Text="DEUG", Value="DEUG"},
                       new SelectListItem{Text="Liscence Professionnelle - DUT", Value="Lic.pro-DUT"},
                       new SelectListItem{Text="Liscence Professionnelle - DEUG", Value="Lic.pro-DEUG"},
                       new SelectListItem{Text="Liscence Fondamentale - DUT", Value="Lic.fnd-DUT"},
                       new SelectListItem{Text="Liscence Fondamentale - DEUG", Value="Lic.fnd-DEUG"},
                       new SelectListItem{Text="Liscence ST - DUT", Value="Lic.st-DUT"},
                       new SelectListItem{Text="Liscence ST - DEUG", Value="Lic.st-DEUG"}
                    }
                    , "-- Choix de type du Diplôme --", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
#line 47 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
                                                                                                         
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(2148, 524, false);
#line 51 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
               Write(Html.DropDownListFor(model => model.Type,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="Liscence Professionnelle", Value="Lic.pro"},
                       new SelectListItem{Text="Liscence Fondamentale", Value="Lic.fnd"},
                       new SelectListItem{Text="Liscence Sciences et Techniques", Value="Lic.st"}
                    }
                    , "-- Choix de type du Diplôme --", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
#line 58 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
                                                                                                         
                }

#line default
#line hidden
            BeginContext(2693, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2712, 82, false);
#line 61 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Type, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2794, 80, true);
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2875, 142, false);
#line 66 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Specialite, "Specialité", new { htmlAttributes = new { @class = "form-control", @placeholder = "Specialité" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3017, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3036, 88, false);
#line 67 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Specialite, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3124, 78, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(3203, 131, false);
#line 71 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.NoteDiplome, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note diplome" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3334, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3353, 89, false);
#line 72 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.NoteDiplome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3442, 80, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(3523, 631, false);
#line 77 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.DropDownListFor(model => model.Etablissement,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="École Supérieure de Technologie EST", Value="EST"},
                       new SelectListItem{Text="Faculté des Sciences et Techniques FST", Value="FST"},
                       new SelectListItem{Text="Faculté Polydisciplinaire FP", Value="FP"},
                       new SelectListItem{Text="Faculté des Sciences FS", Value="FS"}
                    }
                    , "-- Choix d'Etablissement --", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(4154, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4173, 91, false);
#line 86 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Etablissement, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4264, 78, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(4343, 137, false);
#line 90 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.VilleObtention, new { htmlAttributes = new { @class = "form-control", @placeholder = "Ville Obtention" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4480, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4499, 92, false);
#line 91 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.VilleObtention, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4591, 282, true);
            WriteLiteral(@"
                <br /><br />
            </div>

        </div>
    </div>
    <div class=""row"">

        <h3 class=""col-11 offset-1 mb-1 text-white"">Notes semestrielle</h3>
    </div>
    <div class=""row"">
        <div class=""col-sm-3 offset-sm-1 mt-3"">

            ");
            EndContext();
            BeginContext(4874, 639, false);
#line 104 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.DropDownListFor(model => model.AnneUni1,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="2014/2015", Value="2014/2015"},
                       new SelectListItem{Text="2015/2016", Value="2015/2016"},
                       new SelectListItem{Text="2016/2017", Value="2016/2017"},
                       new SelectListItem{Text="2017/2018", Value="2017/2018"},
                       new SelectListItem{Text="2018/2019", Value="2018/2019"}
                    }
                    , "Année universitaire 1", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(5513, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(5528, 86, false);
#line 114 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnneUni1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5614, 34, true);
            WriteLiteral("\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(5649, 639, false);
#line 116 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.DropDownListFor(model => model.AnneUni2,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="2015/2016", Value="2015/2016"},
                       new SelectListItem{Text="2016/2017", Value="2016/2017"},
                       new SelectListItem{Text="2017/2018", Value="2017/2018"},
                       new SelectListItem{Text="2018/2019", Value="2018/2019"},
                       new SelectListItem{Text="2019/2020", Value="2019/2020"}
                    }
                    , "Année universitaire 2", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(6288, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(6303, 86, false);
#line 126 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnneUni2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6389, 34, true);
            WriteLiteral("\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(6424, 639, false);
#line 128 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.DropDownListFor(model => model.AnneUni3,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="2015/2016", Value="2015/2016"},
                       new SelectListItem{Text="2016/2017", Value="2016/2017"},
                       new SelectListItem{Text="2017/2018", Value="2017/2018"},
                       new SelectListItem{Text="2018/2019", Value="2018/2019"},
                       new SelectListItem{Text="2019/2020", Value="2019/2020"}
                    }
                    , "Année universitaire 3", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(7063, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(7078, 86, false);
#line 138 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnneUni3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7164, 144, true);
            WriteLiteral("\r\n\r\n            <br />\r\n\r\n\r\n            <div class=\"dropDownSelect2\"></div>\r\n        </div>\r\n        <div class=\"col-sm-3 mt-3\">\r\n\r\n            ");
            EndContext();
            BeginContext(7309, 364, false);
#line 147 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.DropDownListFor(model => model.Redoublant1,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="Oui", Value="Oui"},
                       new SelectListItem{Text="Non", Value="Non"}
                    }
                    , "Redoublant", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(7673, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(7688, 89, false);
#line 154 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.Redoublant1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7777, 36, true);
            WriteLiteral("\r\n            <br />\r\n\r\n            ");
            EndContext();
            BeginContext(7814, 364, false);
#line 157 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.DropDownListFor(model => model.Redoublant2,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="Oui", Value="Oui"},
                       new SelectListItem{Text="Non", Value="Non"}
                    }
                    , "Redoublant", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(8178, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(8193, 89, false);
#line 164 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.Redoublant2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(8282, 36, true);
            WriteLiteral("\r\n            <br />\r\n\r\n            ");
            EndContext();
            BeginContext(8319, 364, false);
#line 167 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.DropDownListFor(model => model.Redoublant3,
                    new List<SelectListItem>
                    {
                       new SelectListItem{Text="Oui", Value="Oui"},
                       new SelectListItem{Text="Non", Value="Non"}
                    }
                    , "Redoublant", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(8683, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(8698, 89, false);
#line 174 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.Redoublant3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(8787, 98, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"col-sm-2 mt-3\">\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(8886, 124, false);
#line 182 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre1, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S1" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9010, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(9029, 87, false);
#line 183 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9116, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(9194, 124, false);
#line 187 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre3, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S3" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9318, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(9337, 87, false);
#line 188 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9424, 79, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(9504, 124, false);
#line 193 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre5, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S5" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9628, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(9647, 87, false);
#line 194 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre5, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9734, 116, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-sm-2 mt-3\">\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(9851, 124, false);
#line 202 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre2, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S2" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9975, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(9994, 87, false);
#line 203 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10081, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(10159, 124, false);
#line 207 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre4, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S4" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10283, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(10302, 87, false);
#line 208 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre4, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10389, 79, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(10469, 124, false);
#line 213 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre6, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S6" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10593, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(10612, 87, false);
#line 214 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre6, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10699, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(10751, 445, true);
            WriteLiteral(@"    <div class=""col-md-12"">
        <div class=""form-group text-center offset-2"">
            <br /><br />
            <div class=""row"">
                <a class=""btn btn-info px-5 mt-2"" href=""Step2"">Previous</a>
                <div class=""offset-lg-8 offset-md-3""></div>
                <input type=""submit"" class=""btn btn-danger px-5 mt-2"" id=""maj"" value=""Finish"" />
            </div>

        </div>
    </div>
    <br /><br />
");
            EndContext();
            BeginContext(11198, 299, true);
            WriteLiteral(@"    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script>
    $(document).ready(function () {
        traitement();
        $(""#Type"").change(function () {
            traitement();
        });
        function traitement() {
            if (");
            EndContext();
            BeginContext(11498, 14, false);
#line 240 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(ViewBag.niveau);

#line default
#line hidden
            EndContext();
            BeginContext(11512, 622, true);
            WriteLiteral(@" == ""3"") {
                var select = $(""#Type"").children(""option:selected"").val();
                if (select == ""DUT"" || select == ""DEUG"") {
                    $(""#Semestre6"").hide();
                    $(""#Semestre5"").hide();
                    $(""#AnneUni3"").hide();
                    $(""#Redoublant3"").hide();
                }
                else {
                    $(""#Semestre6"").show();
                    $(""#Semestre5"").show();
                    $(""#AnneUni3"").show();
                    $(""#Redoublant3"").show();
                }
            }
        }
    });
    </script>
");
            EndContext();
#line 258 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionConcoursCore.Models.DiplomeNote> Html { get; private set; }
    }
}
#pragma warning restore 1591