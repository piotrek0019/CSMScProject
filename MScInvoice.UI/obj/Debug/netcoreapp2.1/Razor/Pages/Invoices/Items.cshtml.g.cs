#pragma checksum "E:\OneDrive\Programowanie\Projects\CSMScProject\CSMScProject\MScInvoice.UI\Pages\Invoices\Items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13283db996d858b85d911d91d6a6e5587a142db7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MScInvoice.UI.Pages.Invoices.Pages_Invoices_Items), @"mvc.1.0.razor-page", @"/Pages/Invoices/Items.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Invoices/Items.cshtml", typeof(MScInvoice.UI.Pages.Invoices.Pages_Invoices_Items), null)]
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
#line 1 "E:\OneDrive\Programowanie\Projects\CSMScProject\CSMScProject\MScInvoice.UI\Pages\_ViewImports.cshtml"
using MScInvoice.UI;

#line default
#line hidden
#line 2 "E:\OneDrive\Programowanie\Projects\CSMScProject\CSMScProject\MScInvoice.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13283db996d858b85d911d91d6a6e5587a142db7", @"/Pages/Invoices/Items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1c90f45e28c9bcdebedd377be145cf6517f032", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Invoices_Items : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/invoices/items.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 92, true);
            WriteLiteral("\n<div id=\"app\" class=\"container\">\n\n    <div v-if=\"!editing\">\n        <button class=\"button\" ");
            EndContext();
            BeginContext(148, 432, true);
            WriteLiteral(@"@click=""newItem"">Add New Item</button>
        <table class=""table"">
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Price</th>
                <th></th>
                <th></th>
            </tr>
            <tr v-for=""(item, index) in items"">
                <td>{{item.id}}</td>
                <td>{{item.name}}</td>
                <td>{{item.price}}</td>
                <td><a ");
            EndContext();
            BeginContext(581, 71, true);
            WriteLiteral("@click=\"editItem(item.id, index)\">Edit</a></td>\n                <td><a ");
            EndContext();
            BeginContext(653, 529, true);
            WriteLiteral(@"@click=""deleteItem(item.id, index)"">Remove</a></td>
            </tr>
        </table>
    </div>
    <div v-else>
        <div class=""field"">
            <label class=""label"">Item Name</label>
            <div class=""control"">
                <input class=""input"" v-model=""itemModel.name"" />
            </div>
            <label class=""label"">Item Price</label>
            <div class=""control"">
                <input class=""input"" v-model=""itemModel.price"" />
            </div>
            <button class=""button is-success"" ");
            EndContext();
            BeginContext(1183, 108, true);
            WriteLiteral("@click=\"createItem\" v-if=\"!itemModel.id\">Create Item</button>\n            <button class=\"button is-warning\" ");
            EndContext();
            BeginContext(1292, 83, true);
            WriteLiteral("@click=\"updateItem\" v-else>Update Item</button>\n            <button class=\"button\" ");
            EndContext();
            BeginContext(1376, 67, true);
            WriteLiteral("@click=\"cancel\">Cancel</button>\n        </div>\n\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1460, 167, true);
                WriteLiteral("\n    <script src=\"https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.js\"></script>\n    <script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\n\n    ");
                EndContext();
                BeginContext(1627, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51cada3a72dc46c5bf8567f4a6e625a0", async() => {
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
                BeginContext(1673, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MScInvoice.UI.Pages.Admin.ItemsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Admin.ItemsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Admin.ItemsModel>)PageContext?.ViewData;
        public MScInvoice.UI.Pages.Admin.ItemsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
