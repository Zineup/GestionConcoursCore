#pragma checksum "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb3b0d858af9e3177c847ae7f46396cb77937ff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FichierScanne), @"mvc.1.0.view", @"/Views/Home/FichierScanne.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FichierScanne.cshtml", typeof(AspNetCore.Views_Home_FichierScanne))]
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
#line 1 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3b0d858af9e3177c847ae7f46396cb77937ff5", @"/Views/Home/FichierScanne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FichierScanne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionConcoursCore.Models.FichierModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
  
    ViewData["Title"] = "Fichier Scanné";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(149, 674, true);
            WriteLiteral(@"

<div class=""page-content-wrapper-inner"" style=""font-family:'Arial Rounded MT';"">
    <div class=""content-viewport"">
        <div class=""container-fluid"">
            <!-- USER DATA-->
            <div class=""user-data m-b-40"">
                <h2 class=""title-3 mb-4 mt-4 text-center text-warning font-weight-bold"">
                    <i class=""mdi mdi-account-circle link-icon mr-4""></i>
                    Fichiers Scannés
                </h2>
                <hr class=""col-md-8 offset-md-2 mb-5"" />
                <div class=""offset-2"">
                    <div class=""row"">
                        <div class=""col-md-8 mb-3 showcase_content_area"">
");
            EndContext();
#line 21 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
                             using (Html.BeginForm("FichierScanne", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
                            {
                                

#line default
#line hidden
            BeginContext(1023, 23, false);
#line 23 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1050, 99, true);
            WriteLiteral("                                <div class=\"form-horizontal\">\r\n                                    ");
            EndContext();
            BeginContext(1150, 64, false);
#line 26 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
                               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 104, true);
            WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n                                        ");
            EndContext();
            BeginContext(1319, 94, false);
#line 28 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
                                   Write(Html.LabelFor(model => model.files, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 111, true);
            WriteLiteral("\r\n                                        <div class=\"col-md-10\">\r\n                                            ");
            EndContext();
            BeginContext(1525, 89, false);
#line 30 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
                                       Write(Html.TextBoxFor(model => model.files, "", new { @type = "file", @multiple = "multiple" }));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(1661, 83, false);
#line 31 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.files, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 637, true);
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <div class=""col-md-offset-2 col-md-10"">
                                            <input type=""submit"" value=""Upload"" class=""btn btn-primary"" />
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <div class=""col-md-offset-2 col-md-10 text-success"">
                                            ");
            EndContext();
            BeginContext(2382, 20, false);
#line 41 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
                                       Write(ViewBag.UploadStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2402, 136, true);
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                </div>\r\n");
            EndContext();
#line 46 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Home\FichierScanne.cshtml"
                            }

#line default
#line hidden
            BeginContext(2569, 108, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionConcoursCore.Models.FichierModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
