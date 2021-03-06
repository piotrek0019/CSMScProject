#pragma checksum "E:\OneDrive\Programowanie\Projects\CSMScProject\MScInvoice.UI\Pages\Accounts\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c746e900289d774acc684c464708e9ae217390"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MScInvoice.UI.Pages.Accounts.Pages_Accounts_Users), @"mvc.1.0.razor-page", @"/Pages/Accounts/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Accounts/Users.cshtml", typeof(MScInvoice.UI.Pages.Accounts.Pages_Accounts_Users), null)]
namespace MScInvoice.UI.Pages.Accounts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\OneDrive\Programowanie\Projects\CSMScProject\MScInvoice.UI\Pages\_ViewImports.cshtml"
using MScInvoice.UI;

#line default
#line hidden
#line 2 "E:\OneDrive\Programowanie\Projects\CSMScProject\MScInvoice.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c746e900289d774acc684c464708e9ae217390", @"/Pages/Accounts/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1c90f45e28c9bcdebedd377be145cf6517f032", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Accounts_Users : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/accounts/users.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 104, true);
            WriteLiteral("\n\n    <div id=\"app\" class=\"container\">\n        <div v-if=\"!editing\">\n            <button class=\"button\" ");
            EndContext();
            BeginContext(163, 332, true);
            WriteLiteral(@"@click=""newUser"">Add New User</button>
            <table class=""table"">
                <tr>
                    <th>Name</th>
                    <th></th>

                </tr>
                <tr v-for=""(user, index) in users"">
                    <td>{{user.userName}}</td>
                    <td>
                        <a ");
            EndContext();
            BeginContext(496, 181, true);
            WriteLiteral("@click=\"editUser(user.userName, index)\">\n                            Edit\n                        </a>\n                    </td>\n                    <td>\n                        <a ");
            EndContext();
            BeginContext(678, 881, true);
            WriteLiteral(@"@click=""deleteUser(user.userName, index)"">
                        Remove
                        </a>
                    </td>

                </tr>
            </table>
        </div>
        <div v-else>
            <div class=""field"">
                <div class=""block"">
                    <label class=""label"">User Name</label>
                    <div class=""control"">
                        <input class=""input"" 
                               v-model=""userModel.username"" />
                    </div>
                    <label class=""label"">Password</label>
                    <div class=""control"">
                        <input class=""input"" 
                               v-model=""userModel.password"" />
                    </div>
                </div>
                <div class=""block"">
                    <button class=""button"" 
                            ");
            EndContext();
            BeginContext(1560, 217, true);
            WriteLiteral("@click=\"createUser()\" \n                            v-if=\"!userModel.id\">\n                        Create\n                    </button>\n                    <button class=\"button is-warning\" \n                            ");
            EndContext();
            BeginContext(1778, 166, true);
            WriteLiteral("@click=\"updateUser\" \n                            v-else>\n                        Update Item\n                    </button>\n                    <button class=\"button\" ");
            EndContext();
            BeginContext(1945, 249, true);
            WriteLiteral("@click=\"cancel\">\n                        Cancel\n                    </button>\n                </div>\n            </div>\n        </div>\n    </div>\n    <br /><br /><br /><br /><br /><br /><br /><br />\n<br /><br /><br /><br /><br /><br /><br /><br />\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2211, 167, true);
                WriteLiteral("\n    <script src=\"https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.js\"></script>\n    <script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\n\n    ");
                EndContext();
                BeginContext(2378, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22c746e900289d774acc684c464708e9ae2173906936", async() => {
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
                BeginContext(2424, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MScInvoice.UI.Pages.Accounts.UsersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Accounts.UsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Accounts.UsersModel>)PageContext?.ViewData;
        public MScInvoice.UI.Pages.Accounts.UsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
