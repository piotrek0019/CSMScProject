#pragma checksum "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb23e63b529c6e80b9ca8cef4d9bfdbdcecf590e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MScInvoice.UI.Pages.Pdf.Pages_Pdf_Invoice), @"mvc.1.0.razor-page", @"/Pages/Pdf/Invoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Pdf/Invoice.cshtml", typeof(MScInvoice.UI.Pages.Pdf.Pages_Pdf_Invoice), @"{id}")]
namespace MScInvoice.UI.Pages.Pdf
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb23e63b529c6e80b9ca8cef4d9bfdbdcecf590e", @"/Pages/Pdf/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1c90f45e28c9bcdebedd377be145cf6517f032", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pdf_Invoice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/pdfInvoice.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: Museo; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(93, 39, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(132, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb23e63b529c6e80b9ca8cef4d9bfdbdcecf590e5218", async() => {
                BeginContext(138, 36, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    ");
                EndContext();
                BeginContext(174, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb23e63b529c6e80b9ca8cef4d9bfdbdcecf590e5638", async() => {
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
                BeginContext(227, 13, true);
                WriteLiteral("\r\n\r\n   \r\n  \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(251, 4861, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb23e63b529c6e80b9ca8cef4d9bfdbdcecf590e7789", async() => {
                BeginContext(286, 286, true);
                WriteLiteral(@"
   

    <div class=""invoice-container"">
        <div style=""text-align: left;"">
            <div>
                <div class=""left"">
                    <h2 class=""mylogo"">august</h2>
                </div>
                <div class=""right"">
                    Invoice #: ");
                EndContext();
                BeginContext(573, 23, false);
#line 30 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                          Write(Model.Invoice.InvoiceNo);

#line default
#line hidden
                EndContext();
                BeginContext(596, 37, true);
                WriteLiteral("<br />\r\n                    Created: ");
                EndContext();
                BeginContext(634, 18, false);
#line 31 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                        Write(Model.Invoice.Date);

#line default
#line hidden
                EndContext();
                BeginContext(652, 34, true);
                WriteLiteral("<br />\r\n                    Due:  ");
                EndContext();
                BeginContext(687, 28, false);
#line 32 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                     Write(Model.Invoice.InvoiceDueDate);

#line default
#line hidden
                EndContext();
                BeginContext(715, 198, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"clear\" style=\"display: block; height: 30px;\"></div>\r\n            <div>\r\n                <div class=\"left\">\r\n                    ");
                EndContext();
                BeginContext(914, 25, false);
#line 38 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.AccountName);

#line default
#line hidden
                EndContext();
                BeginContext(939, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(968, 29, false);
#line 39 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.AccountAddress1);

#line default
#line hidden
                EndContext();
                BeginContext(997, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1026, 29, false);
#line 40 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.AccountAddress2);

#line default
#line hidden
                EndContext();
                BeginContext(1055, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1084, 25, false);
#line 41 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.AccountCity);

#line default
#line hidden
                EndContext();
                BeginContext(1109, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1138, 29, false);
#line 42 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.AccountPostCode);

#line default
#line hidden
                EndContext();
                BeginContext(1167, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1196, 28, false);
#line 43 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.AccountNumber1);

#line default
#line hidden
                EndContext();
                BeginContext(1224, 107, true);
                WriteLiteral("\r\n                    \r\n                </div>\r\n\r\n                <div class=\"right\">\r\n                    ");
                EndContext();
                BeginContext(1332, 26, false);
#line 48 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.CustomerName);

#line default
#line hidden
                EndContext();
                BeginContext(1358, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1387, 30, false);
#line 49 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.CustomerAddress1);

#line default
#line hidden
                EndContext();
                BeginContext(1417, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1446, 30, false);
#line 50 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.CustomerAddress2);

#line default
#line hidden
                EndContext();
                BeginContext(1476, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1505, 26, false);
#line 51 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.CustomerCity);

#line default
#line hidden
                EndContext();
                BeginContext(1531, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1560, 30, false);
#line 52 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.CustomerPostCode);

#line default
#line hidden
                EndContext();
                BeginContext(1590, 28, true);
                WriteLiteral("<br />\r\n                    ");
                EndContext();
                BeginContext(1619, 29, false);
#line 53 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.CustomerNumber1);

#line default
#line hidden
                EndContext();
                BeginContext(1648, 315, true);
                WriteLiteral(@"<br />
                </div>
            </div>
        </div>
        <div class=""clear"" style=""display: block; height: 30px;""></div>




        <table>
            <tr class=""heading"">
                <td>Payment Method</td>
                <td></td>
                <td></td>
                <td>");
                EndContext();
                BeginContext(1964, 27, false);
#line 67 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(Model.Invoice.PayMethodName);

#line default
#line hidden
                EndContext();
                BeginContext(1991, 191, true);
                WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr class=\"details\">\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n\r\n            </tr>\r\n");
                EndContext();
#line 77 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
              
                decimal subTotal = 0;
                decimal subTotalTax = 0;
                var SumOfSections = new List<decimal>();
                var SumOfSectionsTax = new List<decimal>();


                foreach (var s in Model.Invoice.InvoiceSections)
                {

                    subTotal = 0;
                    subTotalTax = 0;


#line default
#line hidden
                BeginContext(2564, 70, true);
                WriteLiteral("                    <tr class=\"heading\">\r\n                        <td>");
                EndContext();
                BeginContext(2635, 6, false);
#line 91 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                       Write(s.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2641, 443, true);
                WriteLiteral(@"</td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr class=""heading"">
                        <td>Item Name</td>
                        <td>Price</td>
                        <td>Tax</td>
                        <td>Qty</td>
                        <td>Total</td>
                    </tr>
");
                EndContext();
#line 104 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"

                    foreach (var i in s.InvoiceItem)
                    {

#line default
#line hidden
                BeginContext(3163, 75, true);
                WriteLiteral("                        <tr class=\"item\">\r\n                            <td>");
                EndContext();
                BeginContext(3239, 10, false);
#line 108 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                           Write(i.ItemName);

#line default
#line hidden
                EndContext();
                BeginContext(3249, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3289, 11, false);
#line 109 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                           Write(i.ItemPrice);

#line default
#line hidden
                EndContext();
                BeginContext(3300, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3340, 9, false);
#line 110 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                           Write(i.ItemTax);

#line default
#line hidden
                EndContext();
                BeginContext(3349, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3389, 10, false);
#line 111 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                           Write(i.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(3399, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(3440, 24, false);
#line 112 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                            Write(i.ItemPrice * i.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(3465, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 114 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                        subTotal += (i.ItemPrice * i.Quantity);
                        subTotalTax += ((i.ItemPrice * i.Quantity) * ((100 + i.ItemTax ) / 100));
                    }

#line default
#line hidden
                BeginContext(3690, 217, true);
                WriteLiteral("                    <tr class=\"item\">\r\n                        <td></td>\r\n                        <td></td>\r\n                        <td></td>\r\n                        <td>Sub Total:</td>\r\n                        <td>");
                EndContext();
                BeginContext(3908, 8, false);
#line 122 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                       Write(subTotal);

#line default
#line hidden
                EndContext();
                BeginContext(3916, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 124 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                    SumOfSections.Add(subTotal);
                    SumOfSectionsTax.Add(subTotalTax);
                }
            

#line default
#line hidden
                BeginContext(4090, 190, true);
                WriteLiteral("\r\n        <tr class=\"item\">\r\n            <th>Section Name</th>\r\n            <th></th>\r\n            <th>Date</th>\r\n            <th>Sum</th>\r\n            <th>Sum With Tax</th>\r\n        </tr>\r\n");
                EndContext();
#line 136 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
              
                int index = 0;
                foreach (var s in Model.Invoice.InvoiceSections)
                {

#line default
#line hidden
                BeginContext(4413, 70, true);
                WriteLiteral("                    <tr class=\"heading\">\r\n                        <td>");
                EndContext();
                BeginContext(4484, 6, false);
#line 141 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                       Write(s.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4490, 70, true);
                WriteLiteral("</td>\r\n                        <td></td>\r\n                        <td>");
                EndContext();
                BeginContext(4561, 29, false);
#line 143 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                       Write(s.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
                EndContext();
                BeginContext(4590, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(4626, 20, false);
#line 144 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                       Write(SumOfSections[index]);

#line default
#line hidden
                EndContext();
                BeginContext(4646, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(4682, 40, false);
#line 145 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                       Write(SumOfSectionsTax[index].ToString("0.00"));

#line default
#line hidden
                EndContext();
                BeginContext(4722, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 147 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
                    index += 1;
                }
            

#line default
#line hidden
                BeginContext(4823, 139, true);
                WriteLiteral("            <tr class=\"total\">\r\n                <td></td>\r\n                <td></td>\r\n                <td>Total:</td>\r\n                <td>");
                EndContext();
                BeginContext(4963, 19, false);
#line 154 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(SumOfSections.Sum());

#line default
#line hidden
                EndContext();
                BeginContext(4982, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(5010, 39, false);
#line 155 "E:\OneDrive\UniversityOfHertfordshire\Computer Science MSc Project\deploy\invoice\CSMScProject\MScInvoice.UI\Pages\Pdf\Invoice.cshtml"
               Write(SumOfSectionsTax.Sum().ToString("0.00"));

#line default
#line hidden
                EndContext();
                BeginContext(5049, 56, true);
                WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5112, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MScInvoice.UI.Pages.Pdf.InvoiceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Pdf.InvoiceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MScInvoice.UI.Pages.Pdf.InvoiceModel>)PageContext?.ViewData;
        public MScInvoice.UI.Pages.Pdf.InvoiceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591