#pragma checksum "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138a54b65ff9a2fbb6027888a01854ca64fd3e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Delete.cshtml", typeof(AspNetCore.Views_Home_Delete))]
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
#line 1 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/_ViewImports.cshtml"
using MedicalManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138a54b65ff9a2fbb6027888a01854ca64fd3e30", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32a003e9397b6f5323dc24f5b581c2696bcf9563", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/medical-img01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(1, 5, false);
#line 1 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(6, 23, true);
            WriteLiteral(" HomeDetailsViewModel\n\n");
            EndContext();
#line 3 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
  
    ViewBag.Title = "Medication Delete";

#line default
#line hidden
            BeginContext(75, 234, true);
            WriteLiteral("\n<div class=\"row justify-content-center m-3\">\n    \n    <div class=\"col-sm-8\">\n        \n        <h2>The Following Medication Successfully Deleted</h2>\n        <div clss=\"card\">\n            <div class=\"card-header\">\n                <h1>");
            EndContext();
            BeginContext(310, 21, false);
#line 14 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
               Write(Model.Medication.Name);

#line default
#line hidden
            EndContext();
            BeginContext(331, 89, true);
            WriteLiteral("</h1>\n            </div>\n            <div class=\"card-body text-center\">\n                ");
            EndContext();
            BeginContext(420, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4bc3f2bb2c64d5c9d2c93f55aabe3a1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(481, 27, true);
            WriteLiteral("\n                <h4>Dose: ");
            EndContext();
            BeginContext(509, 21, false);
#line 18 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
                     Write(Model.Medication.Dose);

#line default
#line hidden
            EndContext();
            BeginContext(530, 40, true);
            WriteLiteral("</h4>\n                <h4>Time To Take: ");
            EndContext();
            BeginContext(571, 27, false);
#line 19 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
                             Write(Model.Medication.Administer);

#line default
#line hidden
            EndContext();
            BeginContext(598, 45, true);
            WriteLiteral("</h4>\n                <h4>Prescription Date: ");
            EndContext();
            BeginContext(644, 27, false);
#line 20 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
                                  Write(Model.Medication.Prescribed);

#line default
#line hidden
            EndContext();
            BeginContext(671, 40, true);
            WriteLiteral("</h4>\n                <h4>Total Refill: ");
            EndContext();
            BeginContext(712, 24, false);
#line 21 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
                             Write(Model.Medication.Refills);

#line default
#line hidden
            EndContext();
            BeginContext(736, 39, true);
            WriteLiteral("</h4>\n                <h4>Doctor Name: ");
            EndContext();
            BeginContext(776, 27, false);
#line 22 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
                            Write(Model.Medication.Prescriber);

#line default
#line hidden
            EndContext();
            BeginContext(803, 93, true);
            WriteLiteral("</h4>\n            </div>\n            <div class=\"card-footer text-center\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 896, "\"", 931, 1);
#line 25 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
WriteAttributeValue("", 903, Url.Action("Index", "Home"), 903, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(932, 52, true);
            WriteLiteral(" class=\"btn btn-primary\">Back</a>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 984, "\"", 1020, 1);
#line 26 "/Users/e002128/khalid_demo/aspnet_demo/medicalmanager/MedicalManager/MedicalManager/Views/Home/Delete.cshtml"
WriteAttributeValue("", 991, Url.Action("Create", "Home"), 991, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1021, 90, true);
            WriteLiteral(" class=\"btn btn-primary\">Create</a>>\n            </div>\n        </div>\n\n    </div>\n\n</div>");
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