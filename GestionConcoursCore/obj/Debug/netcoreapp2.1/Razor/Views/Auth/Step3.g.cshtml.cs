#pragma checksum "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0cdaf18cc57f12a1670c6a1e70ba43a466f5887"
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
#line 1 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0cdaf18cc57f12a1670c6a1e70ba43a466f5887", @"/Views/Auth/Step3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Step3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionConcoursCore.Models.DiplomeNote>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("shortcut icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/x-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ensa_logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
  
    
    ViewBag.Title = "Step3";
    Layout = null;

#line default
#line hidden
            BeginContext(110, 17, true);
            WriteLiteral("\r\n<!-- icon -->\r\n");
            EndContext();
            BeginContext(127, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd277fe45d2c4f8fa4ccd404d9e9c86e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 552, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" />

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
#line 24 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
 using (Html.BeginForm("Step3", "Auth", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(819, 263, true);
            WriteLiteral(@"    <hr class=""col-md-7 offset-md-2 mb-4"" />
    <div class=""row "" style=""padding-bottom: 40px"">
        <div class=""col-md-7 offset-3"">
            <div class=""form-group"">
                <h4 class=""register-heading text-white"">Diplome Obtenu</h4><br />

");
            EndContext();
#line 32 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
                 if (ViewBag.Niveau == "3")
                {

                    

#line default
#line hidden
            BeginContext(1169, 975, false);
#line 35 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
#line 47 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
                                                                                                         
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(2227, 524, false);
#line 51 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
#line 58 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
                                                                                                         
                }

#line default
#line hidden
            BeginContext(2772, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2791, 82, false);
#line 61 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Type, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2873, 80, true);
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2954, 142, false);
#line 66 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Specialite, "Specialité", new { htmlAttributes = new { @class = "form-control", @placeholder = "Specialité" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3096, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3115, 88, false);
#line 67 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Specialite, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3203, 78, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(3282, 131, false);
#line 71 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.NoteDiplome, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note diplome" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3413, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3432, 89, false);
#line 72 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.NoteDiplome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3521, 80, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n\r\n                ");
            EndContext();
            BeginContext(3602, 631, false);
#line 77 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
            BeginContext(4233, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4252, 91, false);
#line 86 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Etablissement, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4343, 78, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(4422, 137, false);
#line 90 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.VilleObtention, new { htmlAttributes = new { @class = "form-control", @placeholder = "Ville Obtention" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4559, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4578, 92, false);
#line 91 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.VilleObtention, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4670, 282, true);
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
            BeginContext(4953, 639, false);
#line 104 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
            BeginContext(5592, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(5607, 86, false);
#line 114 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnneUni1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5693, 34, true);
            WriteLiteral("\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(5728, 639, false);
#line 116 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
            BeginContext(6367, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(6382, 86, false);
#line 126 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnneUni2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6468, 34, true);
            WriteLiteral("\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(6503, 639, false);
#line 128 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
            BeginContext(7142, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(7157, 86, false);
#line 138 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnneUni3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7243, 144, true);
            WriteLiteral("\r\n\r\n            <br />\r\n\r\n\r\n            <div class=\"dropDownSelect2\"></div>\r\n        </div>\r\n        <div class=\"col-sm-3 mt-3\">\r\n\r\n            ");
            EndContext();
            BeginContext(7388, 364, false);
#line 147 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
            BeginContext(7752, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(7767, 89, false);
#line 154 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.Redoublant1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7856, 36, true);
            WriteLiteral("\r\n            <br />\r\n\r\n            ");
            EndContext();
            BeginContext(7893, 364, false);
#line 157 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
            BeginContext(8257, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(8272, 89, false);
#line 164 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.Redoublant2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(8361, 36, true);
            WriteLiteral("\r\n            <br />\r\n\r\n            ");
            EndContext();
            BeginContext(8398, 364, false);
#line 167 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
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
            BeginContext(8762, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(8777, 89, false);
#line 174 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
       Write(Html.ValidationMessageFor(model => model.Redoublant3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(8866, 98, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"col-sm-2 mt-3\">\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(8965, 124, false);
#line 182 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre1, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S1" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9089, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(9108, 87, false);
#line 183 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9195, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(9273, 124, false);
#line 187 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre3, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S3" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9397, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(9416, 87, false);
#line 188 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9503, 79, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(9583, 124, false);
#line 193 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre5, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S5" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9707, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(9726, 87, false);
#line 194 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre5, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9813, 116, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-sm-2 mt-3\">\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(9930, 124, false);
#line 202 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre2, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S2" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10054, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(10073, 87, false);
#line 203 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10160, 77, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(10238, 124, false);
#line 207 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre4, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S4" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10362, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(10381, 87, false);
#line 208 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre4, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10468, 79, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(10548, 124, false);
#line 213 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.EditorFor(model => model.Semestre6, new { htmlAttributes = new { @class = "form-control", @placeholder = "Note S6" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10672, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(10691, 87, false);
#line 214 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(Html.ValidationMessageFor(model => model.Semestre6, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10778, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(10830, 445, true);
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
            BeginContext(11277, 299, true);
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
            BeginContext(11577, 14, false);
#line 240 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"
           Write(ViewBag.niveau);

#line default
#line hidden
            EndContext();
            BeginContext(11591, 622, true);
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
#line 258 "D:\2emeGI-S2\DotNet\Projet3\V2\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step3.cshtml"

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
