#pragma checksum "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d501cdcf05992384d677e8710e3a192428ac9c31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ModifierDiplome), @"mvc.1.0.view", @"/Views/Home/ModifierDiplome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ModifierDiplome.cshtml", typeof(AspNetCore.Views_Home_ModifierDiplome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d501cdcf05992384d677e8710e3a192428ac9c31", @"/Views/Home/ModifierDiplome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ModifierDiplome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionConcoursCore.ViewModels.DiplomeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(148, 477, true);
            WriteLiteral(@"

<div class=""page-content-wrapper-inner"" style=""font-family:'Arial Rounded MT';"">
    <div class=""content-viewport"">
        <div class=""container-fluid"">
            <!-- USER DATA-->
            <div class=""user-data m-b-40"">
                <div class=""col-md-12 register-right"">
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">

");
            EndContext();
#line 17 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                             using (Html.BeginForm("ModifierDiplome", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
                            {
                                

#line default
#line hidden
            BeginContext(827, 34, false);
#line 19 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                           Write(Html.HiddenFor(model => model.Cne));

#line default
#line hidden
            EndContext();
            BeginContext(863, 755, true);
            WriteLiteral(@"                                <div class=""row register-form "" style=""padding-bottom: 40px"">
                                    <div class=""col-md-8 offset-2 "">
                                        <h2 class=""title-3 mb-4 mt-4 text-center text-warning font-weight-bold"">
                                            <i class=""mdi mdi-certificate link-icon mr-4""></i>
                                            Informations sur Diplômes et Notes
                                        </h2>
                                        <hr class=""col-md-12  mb-5"" />
                                        <div class=""form-group"">
                                            <h4 class=""register-heading text-success"">Diplome obtenu</h4><br />

");
            EndContext();
#line 30 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                             if (ViewBag.niveau == 3)
                                            {

                                                

#line default
#line hidden
            BeginContext(1787, 1311, false);
#line 33 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
#line 45 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                                                                                                                     
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
            BeginContext(3293, 720, false);
#line 49 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
#line 56 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                                                                                                                     
                                            }

#line default
#line hidden
            BeginContext(4062, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(4109, 82, false);
#line 59 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Type, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4191, 164, true);
            WriteLiteral("\r\n\r\n\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            ");
            EndContext();
            BeginContext(4356, 142, false);
#line 64 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.Specialite, "Specialité", new { htmlAttributes = new { @class = "form-control", @placeholder = "Specialité" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4498, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(4545, 88, false);
#line 65 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Specialite, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4633, 162, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n\r\n                                            ");
            EndContext();
            BeginContext(4796, 131, false);
#line 69 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.NoteDiplome, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note diplome" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4927, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(4974, 89, false);
#line 70 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.NoteDiplome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5063, 164, true);
            WriteLiteral("\r\n\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n\r\n                                            ");
            EndContext();
            BeginContext(5228, 855, false);
#line 75 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
            BeginContext(6083, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(6130, 91, false);
#line 84 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Etablissement, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6221, 167, true);
            WriteLiteral("\r\n\r\n                                        </div>\r\n                                        <div class=\"form-group mb-0\">\r\n                                            ");
            EndContext();
            BeginContext(6389, 137, false);
#line 88 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.VilleObtention, new { htmlAttributes = new { @class = "form-control", @placeholder = "Ville Obtention" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6526, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(6573, 92, false);
#line 89 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.VilleObtention, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6665, 565, true);
            WriteLiteral(@"
                                            <br /><br />
                                        </div>

                                    </div>
                                </div>
                                <div class=""row"">

                                    <h3 class=""col-11 offset-1 mb-1 text-success"">Notes semestrielles</h3>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-3 offset-sm-1 mt-3"">

                                        ");
            EndContext();
            BeginContext(7231, 891, false);
#line 102 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
            BeginContext(8122, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(8165, 86, false);
#line 112 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.AnneUni1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(8251, 90, true);
            WriteLiteral("\r\n                                        <br />\r\n                                        ");
            EndContext();
            BeginContext(8342, 891, false);
#line 114 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
            BeginContext(9233, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(9276, 86, false);
#line 124 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.AnneUni2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9362, 90, true);
            WriteLiteral("\r\n                                        <br />\r\n                                        ");
            EndContext();
            BeginContext(9453, 891, false);
#line 126 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
            BeginContext(10344, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(10387, 86, false);
#line 136 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.AnneUni3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10473, 284, true);
            WriteLiteral(@"

                                        <br />


                                        <div class=""dropDownSelect2""></div>
                                    </div>
                                    <div class=""col-sm-3 mt-3"">

                                        ");
            EndContext();
            BeginContext(10758, 532, false);
#line 145 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
            BeginContext(11290, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(11333, 89, false);
#line 152 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Redoublant1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(11422, 92, true);
            WriteLiteral("\r\n                                        <br />\r\n\r\n                                        ");
            EndContext();
            BeginContext(11515, 532, false);
#line 155 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
            BeginContext(12047, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(12090, 89, false);
#line 162 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Redoublant2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(12179, 92, true);
            WriteLiteral("\r\n                                        <br />\r\n\r\n                                        ");
            EndContext();
            BeginContext(12272, 532, false);
#line 165 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
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
            BeginContext(12804, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(12847, 89, false);
#line 172 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Redoublant3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(12936, 210, true);
            WriteLiteral("\r\n\r\n\r\n                                    </div>\r\n\r\n                                    <div class=\"col-sm-2 mt-3\">\r\n\r\n                                        <div>\r\n                                            ");
            EndContext();
            BeginContext(13147, 124, false);
#line 180 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.Semestre1, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S1" } }));

#line default
#line hidden
            EndContext();
            BeginContext(13271, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(13318, 87, false);
#line 181 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Semestre1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(13405, 189, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <br />\r\n                                        <div>\r\n                                            ");
            EndContext();
            BeginContext(13595, 124, false);
#line 185 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.Semestre3, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S3" } }));

#line default
#line hidden
            EndContext();
            BeginContext(13719, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(13766, 87, false);
#line 186 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Semestre3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(13853, 191, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <br />\r\n\r\n                                        <div>\r\n                                            ");
            EndContext();
            BeginContext(14045, 124, false);
#line 191 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.Semestre5, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S5" } }));

#line default
#line hidden
            EndContext();
            BeginContext(14169, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(14216, 87, false);
#line 192 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Semestre5, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(14303, 256, true);
            WriteLiteral(@"
                                        </div>

                                    </div>

                                    <div class=""col-sm-2 mt-3"">

                                        <div>
                                            ");
            EndContext();
            BeginContext(14560, 124, false);
#line 200 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.Semestre2, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S2" } }));

#line default
#line hidden
            EndContext();
            BeginContext(14684, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(14731, 87, false);
#line 201 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Semestre2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(14818, 189, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <br />\r\n                                        <div>\r\n                                            ");
            EndContext();
            BeginContext(15008, 124, false);
#line 205 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.Semestre4, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S4" } }));

#line default
#line hidden
            EndContext();
            BeginContext(15132, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(15179, 87, false);
#line 206 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Semestre4, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(15266, 191, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <br />\r\n\r\n                                        <div>\r\n                                            ");
            EndContext();
            BeginContext(15458, 124, false);
#line 211 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.EditorFor(model => model.Semestre6, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S6" } }));

#line default
#line hidden
            EndContext();
            BeginContext(15582, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(15629, 87, false);
#line 212 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.Semestre6, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(15716, 134, true);
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
            BeginContext(15852, 477, true);
            WriteLiteral(@"                                <div class=""col-md-8 offset-2 "">
                                    <div class=""form-group text-center"">
                                        <br /><br />
                                        <button type=""submit"" class=""btn btn-primary btn-rounded"" id=""maj"" style=""width:180px"">Mettre à jour</button>

                                    </div>
                                </div>
                                <br /><br />
");
            EndContext();
#line 225 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"


                            }

#line default
#line hidden
            BeginContext(16364, 447, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {


        traitement();

        $(""#Type"").change(function () {

            traitement();

        });


        function traitement() {
            if (");
            EndContext();
            BeginContext(16812, 14, false);
#line 251 "D:\2emeGI-S2\DotNet\Projet3\V5\GestionConcoursCore\GestionConcoursCore\Views\Home\ModifierDiplome.cshtml"
           Write(ViewBag.niveau);

#line default
#line hidden
            EndContext();
            BeginContext(16826, 809, true);
            WriteLiteral(@" == 3) {

                var select = $(""#Type"").children(""option:selected"").val();
                if (select == ""DUT"" || select == ""DEUG"") {
                    $(""#Semestre6"").hide();
                    $(""#Semestre5"").hide();
                    $(""#AnneUni3"").hide();
                    $(""#Redoublant3"").hide();
                    $(""#Semestre5"").val(""0"");
                    $(""#Semestre6"").val(""0"");
                    $(""#Redoublant3"").val("""");
                    $(""#AnneUni3"").val("""");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionConcoursCore.ViewModels.DiplomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
