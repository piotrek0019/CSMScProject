#pragma checksum "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Invoices\PayMethods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a4767cd4fa121bbf789b0bbe2cbb21afeb494fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MScInvoice.UI.Pages.Invoices.Pages_Invoices_PayMethods), @"mvc.1.0.razor-page", @"/Pages/Invoices/PayMethods.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Invoices/PayMethods.cshtml", typeof(MScInvoice.UI.Pages.Invoices.Pages_Invoices_PayMethods), null)]
namespace MScInvoice.UI.Pages.Invoices
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\_ViewImports.cshtml"
using MScInvoice.UI;

#line default
#line hidden
#line 2 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a4767cd4fa121bbf789b0bbe2cbb21afeb494fa", @"/Pages/Invoices/PayMethods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1c90f45e28c9bcdebedd377be145cf6517f032", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Invoices_PayMethods : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/invoices/payMethods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 90, true);
            WriteLiteral("<div id=\"app\" class=\"container\">\n    <div v-if=\"!editing\">\n        <button class=\"button\" ");
            EndContext();
            BeginContext(151, 392, true);
            WriteLiteral(@"@click=""newPayMethod"">Add New Pay Method</button>
        <table class=""table"">
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th></th>
                <th></th>
            </tr>
            <tr v-for=""(payMethod, index) in payMethods"">
                <td>{{payMethod.id}}</td>
                <td>{{payMethod.name}}</td>
                <td><a ");
            EndContext();
            BeginContext(544, 81, true);
            WriteLiteral("@click=\"editPayMethod(payMethod.id, index)\">Edit</a></td>\n                <td><a ");
            EndContext();
            BeginContext(626, 379, true);
            WriteLiteral(@"@click=""deletePayMethod(payMethod.id, index)"">Remove</a></td>
            </tr>
        </table>
    </div>
    <div v-else>
        <div class=""field"">
            <label class=""label"">Pay Method Name</label>
            <div class=""control"">
                <input class=""input"" v-model=""payMethodModel.name"" />
            </div>
            <button class=""button is-success"" ");
            EndContext();
            BeginContext(1006, 124, true);
            WriteLiteral("@click=\"createPayMethod\" v-if=\"!payMethodModel.id\">Create Pay Method</button>\n            <button class=\"button is-warning\" ");
            EndContext();
            BeginContext(1131, 94, true);
            WriteLiteral("@click=\"updatePayMethod\" v-else>Update Pay Method</button>\n            <button class=\"button\" ");
            EndContext();
            BeginContext(1226, 248, true);
            WriteLiteral("@click=\"cancel\">Cancel</button>\n\n        </div>\n    </div>\n    <div v-if=\"payMethods.length < 12\">\n        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />\n    </div>\n</div>\n\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1491, 167, true);
                WriteLiteral("\n    <script src=\"https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.js\"></script>\n    <script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\n\n    ");
                EndContext();
                BeginContext(1658, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4767cd4fa121bbf789b0bbe2cbb21afeb494fa6369", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1709, 1, true);
                WriteLiteral("\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MScInvoice.UI.Pages.Admin.PayMethodsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Admin.PayMethodsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Admin.PayMethodsModel>)PageContext?.ViewData;
        public MScInvoice.UI.Pages.Admin.PayMethodsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
