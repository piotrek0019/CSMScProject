#pragma checksum "E:\OneDrive\Programowanie\Projects\CSMScProject\CSMScProject\MScInvoice.UI\Pages\Invoices\Invoices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1baaba6ffa4519bbc2d144e1cf98f0e3b333a59e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MScInvoice.UI.Pages.Invoices.Pages_Invoices_Invoices), @"mvc.1.0.razor-page", @"/Pages/Invoices/Invoices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Invoices/Invoices.cshtml", typeof(MScInvoice.UI.Pages.Invoices.Pages_Invoices_Invoices), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1baaba6ffa4519bbc2d144e1cf98f0e3b333a59e", @"/Pages/Invoices/Invoices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1c90f45e28c9bcdebedd377be145cf6517f032", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Invoices_Invoices : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("payMethod in payMethods"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-bind:value", new global::Microsoft.AspNetCore.Html.HtmlString("payMethod"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/components/dropdown-items.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/components/vue-simple-search-dropdown.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/invoices/invoices.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2041, true);
            WriteLiteral(@"<h2>Invoices</h2>

<div id=""app"" class=""container"">
    <div>

        <!-- edit/new invoice-->
        <div v-if=""editing"">
            <div class=""box"">
                <div class=""columns"" style=""margin-bottom: calc(0.2rem - 0.75rem);"">
                    <div v-if=""invoice.InvoiceId"" class=""column"">
                        <input hidden type=""text"" v-model=""invoice.InvoiceId"">
                        <label class=""label"">Invoice Number</label>
                        <div class=""control"">
                            <input disabled=""disabled"" readonly=""readonly"" class=""input"" v-model=""invoice.InvoiceNumber"" />
                        </div>
                    </div>
                    <div v-if=""invoice.InvoiceId"" class=""column"">
                        <label class=""label"">Invoice Date</label>
                        <div class=""control"">
                            <input type=""date"" disabled=""disabled"" readonly=""readonly"" class=""input"" v-model=""invoice.InvoiceDate"" />
                        </div>
");
            WriteLiteral(@"                    </div>
                    <div class=""column"">
                        <label class=""label"">Due Date</label>
                        <div class=""control"">
                            <input type=""date"" class=""input"" v-model=""invoice.DueDate"" />
                        </div>
                    </div>


                </div>

                <label class=""label"">Browse customers</label>
                <Dropdown :options=""customers""
                          v-on:selected=""customerSelection""
                          v-on:filter=""getDropdownValues""
                          :disabled=""false""
                          name=""customer1""
                          :maxItem=""10""
                          placeholder=""Please select a customer"">
                </Dropdown>

                <p class=""is-size-5 block"" >Selected customer: <strong>{{ selectedCustomer.name || 'none' }}</strong></p>
                <div class=""block"">
                    <button class=""button is-link is-light"" ");
            EndContext();
            BeginContext(2100, 125, true);
            WriteLiteral("@click=\"showHideCustomer\">{{ checkButton }} Customer</button>\n                    <button class=\"button is-warning is-light\" ");
            EndContext();
            BeginContext(2226, 2159, true);
            WriteLiteral(@"@click=""addCustomer"">Add new customer</button>
                </div>
                <div>
                    <div v-if=""isSeenCustomer"" class=""field"">
                        <label class=""label"">Customer Name</label>
                        <div class=""control"">
                            <input class=""input"" v-model=""selectedCustomer.name"" :disabled=""isDisabledCustomer"" />
                        </div>
                        <label class=""label"">Address 1</label>
                        <div class=""control"">
                            <input class=""input"" v-model=""selectedCustomer.address1"" :disabled=""isDisabledCustomer"" />
                        </div>
                        <label class=""label"">Address 2</label>
                        <div class=""control"">
                            <input class=""input"" v-model=""selectedCustomer.address2"" :disabled=""isDisabledCustomer"" />
                        </div>
                        <div class=""columns"">
                            <div class=""column""");
            WriteLiteral(@">
                                <label class=""label"">City</label>
                                <div class=""control"">
                                    <input class=""input"" v-model=""selectedCustomer.city"" :disabled=""isDisabledCustomer"" />
                                </div>
                            </div>
                            <div class=""column"">
                                <label class=""label"">Post Code</label>
                                <div class=""control"">
                                    <input class=""input"" v-model=""selectedCustomer.postCode"" :disabled=""isDisabledCustomer"" />
                                </div>
                            </div>
                        </div>
                        <label class=""label"">Number</label>
                        <div class=""control"">
                            <input class=""input"" v-model=""selectedCustomer.number1"" :disabled=""isDisabledCustomer"" />
                        </div>


                    </div>
               ");
            WriteLiteral(" </div>\n            </div>\n\n\n            <div class=\"field\">\n                <button class=\"button is-warning\" ");
            EndContext();
            BeginContext(4386, 781, true);
            WriteLiteral(@"@click=""addSectionToInvoice"">Add Section</button>
                <ul>
                    <li>Section</li>



                    <li class=""box"" v-for=""(section, indexSection) in sections"">
                        <label class=""label"">Browse Items</label>

                        <Dropdown :options=""items""
                                  v-on:selected=""itemSelection""
                                  v-on:filter=""getDropdownValues""
                                  :disabled=""false""
                                  name=""item""
                                  :maxItem=""10""
                                  placeholder=""Please select a item"">
                        </Dropdown>
                        <hr />
                        <button class=""button is-warning"" ");
            EndContext();
            BeginContext(5168, 1027, true);
            WriteLiteral(@"@click=""addItemToInvoice(indexSection)"">Add Item</button>

                        <p class=""is-size-5"">Selected item: <strong>{{ selectedItem.name || 'none' }}</strong></p>

                        <ul>
                            <li>
                                <input hidden type=""text"" v-model=""section.date"">
                                <label class=""label"">Section Name</label>
                                <div class=""columns"">
                                    <div class=""column"">
                                        <div class=""control"">
                                            <input class=""input"" type=""text"" v-model=""section.name"">
                                        </div>
                                    </div>
                                    <div class=""column is-2"">
                                        <div class=""buttons is-right"">
                                            <button class=""button is-info is-light"" 
                                                 ");
            WriteLiteral("   ");
            EndContext();
            BeginContext(6196, 2385, true);
            WriteLiteral(@"@click=""deleteSectionFromInvoice(indexSection)"">
                                            Delete Section
                                            </button>
                                        </div>
                                    </div>
                                </div>

                            </li>
                            <li>
                                <div class=""columns"" style=""margin-bottom: calc(0.2rem - 0.75rem);"">
                                    <div class=""column"">
                                        <label class=""label"">Name</label>
                                    </div>
                                    <div class=""column is-2"">
                                        <label class=""label"">Price</label>
                                    </div>
                                    <div class=""column is-2"">
                                        <label class=""label"">Tax</label>
                                    </div>
                                ");
            WriteLiteral(@"    <div class=""column is-2"">
                                        <label class=""label"">Quantity</label>
                                    </div>
                                    <div class=""column is-2"">
                                        <label class=""label"">Total</label>
                                    </div>
                                    <div class=""column is-2"">
                                        <!--??-->
                                    </div>
                                </div>
                            </li>
                            <li v-for=""(input, indexItem) in section.inputs"">
                                <input hidden type=""text"" v-model=""input.id"">
                                <div class=""columns"" style=""margin-bottom: calc(0.2rem - 0.75rem);"">
                                    <div class=""column"">
                                        <div class=""control"">
                                            <input class=""input"" type=""text"" v-model=""inp");
            WriteLiteral(@"ut.name"">
                                        </div>
                                    </div>
                                    <div class=""column is-2"">
                                        <div class=""control"">
                                            <input class=""input""  type='number' step='0.1' v-model=""input.price"" ");
            EndContext();
            BeginContext(8582, 327, true);
            WriteLiteral(@"@change=""calculateTotalLine(input, indexSection)"">
                                        </div>
                                    </div><div class=""column is-2"">
                                        <div class=""control"">
                                            <input class=""input"" type='number' v-model=""input.tax"" ");
            EndContext();
            BeginContext(8910, 370, true);
            WriteLiteral(@"@change=""calculateTotalLine(input, indexSection)"">
                                        </div>
                                    </div>

                                    <div class=""column is-2"">
                                        <div class=""control"">
                                            <input class=""input"" type='number' v-model=""input.quantity"" ");
            EndContext();
            BeginContext(9281, 696, true);
            WriteLiteral(@"@change=""calculateTotalLine(input, indexSection)"">
                                        </div>
                                    </div>
                                    <div class=""column is-2"">
                                        <div class=""control"">
                                            <input readonly=""readonly"" class=""input"" type=""text"" v-model=""input.totalLine"">
                                        </div>
                                    </div>
                                    <div class=""column is-2"">
                                        <div class=""buttons is-right"">
                                            <button class=""button is-info is-light"" ");
            EndContext();
            BeginContext(9978, 1976, true);
            WriteLiteral(@"@click=""deleteItemFromInvoice(indexSection, indexItem)"">Delete</button>
                                        </div>
                                    </div>
                                </div>
                                <div style=""border-bottom: 1px solid #cecbcb; margin-bottom: 3px""></div>

                            </li>
                            <li>
                                <div class=""level-right"">
                                    <p class=""level-item""><strong>Sub Total: {{section.subSum}}</strong></p>
                                </div>
                                <div style=""border-bottom: 1px solid #cecbcb; margin-bottom: 3px""></div>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <div class=""level-right"">
                            <p class=""level-item""><strong>Total: {{sumTotal}}</strong></p>
                        </div>
                        <div style=""border-bottom: 1");
            WriteLiteral(@"px solid #cecbcb; margin-bottom: 3px""></div>
                    </li>
                    <li>
                        <div class=""level-right"">
                            <p class=""level-item""><strong>Total Tax: {{totalTax}}</strong></p>
                        </div>
                        <div style=""border-bottom: 1px solid #cecbcb; margin-bottom: 3px""></div>
                    </li>
                    <li>
                        <div class=""level-right"">
                            <p class=""level-item""><strong>Total With Tax: {{totalPlusTax}}</strong></p>
                        </div>
                        <div style=""border-bottom: 1px solid #cecbcb; margin-bottom: 3px""></div>
                    </li>
                </ul>

                <!-- pay method-->
                <div class=""block"">
                    <div class=""select"">
                        <select v-model=""selectedPayMethod"">
                            ");
            EndContext();
            BeginContext(11954, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1baaba6ffa4519bbc2d144e1cf98f0e3b333a59e18828", async() => {
                BeginContext(12019, 80, true);
                WriteLiteral("\n                                {{payMethod.name}}\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
            BeginContext(12108, 305, true);
            WriteLiteral(@"
                        </select>
                    </div>
                    <span class=""is-size-4"">Selected: <strong>{{ selectedPayMethod.name }}</strong></span>
                </div>
                <div class=""block"">
                    <button v-if=""!invoice.InvoiceId"" class=""button is-link"" ");
            EndContext();
            BeginContext(12414, 217, true);
            WriteLiteral("@click=\"createInvoice\">\n                        <span v-if=\"loading\">Loading...</span>\n                        <slot v-else>Save Invoice</slot>\n                    </button>\n                    <button class=\"button\" ");
            EndContext();
            BeginContext(12632, 108, true);
            WriteLiteral("@click=\"cancel\">Cancel</button>\n                    <button v-if=\"invoice.InvoiceId\" class=\"button is-link\" ");
            EndContext();
            BeginContext(12741, 220, true);
            WriteLiteral("@click=\"updateInvoice\" >\n                        <span v-if=\"loading\">Loading...</span>\n                        <slot v-else>Update Invoice</slot>\n                    </button>\n                    <button class=\"button\" ");
            EndContext();
            BeginContext(12962, 217, true);
            WriteLiteral("@click=\"printInvoice\">Print</button>\n\n                </div>\n                <br />\n            </div>\n        </div>\n        <!-- list of invoices-->\n        <div v-if=\"!editing\">\n\n            <button class=\"button\" ");
            EndContext();
            BeginContext(13180, 606, true);
            WriteLiteral(@"@click=""newInvoice"">Add New Invoice</button>
            <table class=""table"">
                <tr>
                    <th>Id</th>
                    <th>Customer</th>
                    <th>Invoice No</th>
                    <th>Date</th>
                    <th></th>
                    <th></th>
                </tr>
                <tr v-for=""(invoice, index) in invoices"">
                    <td>{{invoice.id}}</td>
                    <td>{{invoice.customerName}}</td>
                    <td>{{invoice.invoiceNo}}</td>
                    <td>{{invoice.date}}</td>
                    <td><a ");
            EndContext();
            BeginContext(13787, 117, true);
            WriteLiteral("@click=\"editInvoice(invoice.id, index)\">Edit</a></td>\n                    <td><a v-if=\"index + 1 == invoices.length\" ");
            EndContext();
            BeginContext(13905, 136, true);
            WriteLiteral("@click=\"deleteInvoice(invoice.id, index)\">Remove</a></td>\n                </tr>\n            </table>\n        </div>\n    </div>\n</div>\n\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(14058, 183, true);
                WriteLiteral("\n    \n    <script src=\"https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.js\"></script>\n    \n    <script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\n\n\n    \n    ");
                EndContext();
                BeginContext(14241, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1baaba6ffa4519bbc2d144e1cf98f0e3b333a59e23337", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14298, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(14303, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1baaba6ffa4519bbc2d144e1cf98f0e3b333a59e24593", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14372, 15, true);
                WriteLiteral("\n    \n    \n    ");
                EndContext();
                BeginContext(14387, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1baaba6ffa4519bbc2d144e1cf98f0e3b333a59e25862", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14436, 13, true);
                WriteLiteral("\n    \n\n\n\n   \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MScInvoice.UI.Pages.Admin.InvoicesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Admin.InvoicesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Admin.InvoicesModel>)PageContext?.ViewData;
        public MScInvoice.UI.Pages.Admin.InvoicesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
