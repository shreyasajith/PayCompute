#pragma checksum "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9fa6a0c6459fde853b512e069b3e343377364b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pay_PaySlip), @"mvc.1.0.view", @"/Views/Pay/PaySlip.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pay/PaySlip.cshtml", typeof(AspNetCore.Views_Pay_PaySlip))]
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
#line 1 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#line 2 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9fa6a0c6459fde853b512e069b3e343377364b1", @"/Views/Pay/PaySlip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a17a92ca28dc354efe5ab80300d7aa4b038b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pay_PaySlip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentRecordDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
   ViewBag.Title = "Payslip";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
   Layout = null;

#line default
#line hidden
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(95, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9fa6a0c6459fde853b512e069b3e343377364b14446", async() => {
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
            BeginContext(166, 549, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""container-fluid d-flex justify-content-between"">
                    <div class=""col-md-3 pl-0"">
                        <p class=""mt-5 mb-2""><b>PayCompute Ltd</b></p>
                        <p>11 Downing Street<br />London<br />W1C 2XB</p>
                    </div>
                    <div class=""col-md-3 pr-0"">
                        <p class=""mt-5 mb-2 text-right""><b>Pay Date: ");
            EndContext();
            BeginContext(716, 36, false);
#line 19 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                                                                Write(Model.PayDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(752, 66, true);
            WriteLiteral("</b></p>\r\n                        <p class=\"text-right\">Tax Code: ");
            EndContext();
            BeginContext(819, 13, false);
#line 20 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                                                   Write(Model.TaxCode);

#line default
#line hidden
            EndContext();
            BeginContext(832, 12, true);
            WriteLiteral("<br />Year: ");
            EndContext();
            BeginContext(845, 10, false);
#line 20 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                                                                             Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(855, 191, true);
            WriteLiteral("<br />HMRC</p>\r\n                    </div>\r\n                </div><br /><br />\r\n\r\n                <div class=\"col-md-12 row\">\r\n                    <div class=\"col-md-8\"><h5>Employee\'s Name : ");
            EndContext();
            BeginContext(1047, 14, false);
#line 25 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                                                           Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1061, 87, true);
            WriteLiteral("</h5></div>\r\n                    <div class=\"col-md-4\"><h5>National Insurance Number : ");
            EndContext();
            BeginContext(1149, 10, false);
#line 26 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                                                                     Write(Model.NiNo);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 819, true);
            WriteLiteral(@"</h5></div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12 table-responsive-md"">
                    <table class=""table table-striped"">
                        <thead class=""table-dark"">
                            <tr>
                                <th>Earnings</th>
                                <th>Hours</th>
                                <th>Rates</th>
                                <th>Amount</th>
                                <th>Deductions</th>
                                <th>Amount</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><b>Basic :</b></td>
                                <td>");
            EndContext();
            BeginContext(1979, 36, false);
#line 45 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.ContractualHours.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(2015, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2059, 30, false);
#line 46 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.HourlyRate.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2133, 39, false);
#line 47 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.ContractualEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2172, 98, true);
            WriteLiteral("</td>\r\n                                <td><b>Tax :</b></td>\r\n                                <td>");
            EndContext();
            BeginContext(2271, 23, false);
#line 49 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.Tax.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2294, 172, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Overtime :</b></td>\r\n                                <td>");
            EndContext();
            BeginContext(2467, 33, false);
#line 53 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.OvertimeHours.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(2500, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2544, 33, false);
#line 54 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.OvertimeRate.ToString("f2"));

#line default
#line hidden
            EndContext();
            BeginContext(2577, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2621, 36, false);
#line 55 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.OvertimeEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2657, 98, true);
            WriteLiteral("</td>\r\n                                <td><b>NIC :</b></td>\r\n                                <td>");
            EndContext();
            BeginContext(2756, 23, false);
#line 57 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.NIC.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2779, 341, true);
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><b>Union :</b></td>
                                <td>");
            EndContext();
            BeginContext(3121, 34, false);
#line 65 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.UnionFee.Value.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3155, 339, true);
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><b>SLC :</b></td>
                                <td>");
            EndContext();
            BeginContext(3495, 29, false);
#line 73 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.SLC.Value.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3524, 169, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Total :</b></td>\r\n                                <td>");
            EndContext();
            BeginContext(3694, 17, false);
#line 77 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.HoursWorked);

#line default
#line hidden
            EndContext();
            BeginContext(3711, 86, true);
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td>");
            EndContext();
            BeginContext(3798, 33, false);
#line 79 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.TotalEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3831, 86, true);
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td>");
            EndContext();
            BeginContext(3918, 34, false);
#line 81 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                               Write(Model.TotalDeduction.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3952, 448, true);
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class=""table-dark""><b>NET PAY :</b></td>
                                <td class=""table-dark"">");
            EndContext();
            BeginContext(4401, 30, false);
#line 91 "E:\Projects\ASP Dot NET Core MVC\Paycompute\Paycompute\Views\Pay\PaySlip.cshtml"
                                                  Write(Model.NetPayment.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4431, 184, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tfoot>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentRecordDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
