#pragma checksum "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55ecc1f38c0cbf6633fdc93589dae8ee9dbfc198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingModel_Search), @"mvc.1.0.view", @"/Views/BookingModel/Search.cshtml")]
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
#nullable restore
#line 1 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ecc1f38c0cbf6633fdc93589dae8ee9dbfc198", @"/Views/BookingModel/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_BookingModel_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelDb.WebUI.Models.BookingViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55ecc1f38c0cbf6633fdc93589dae8ee9dbfc1984355", async() => {
                WriteLiteral(@"
    <div class=""form-actions no-color input-group"">
        <div class=""input-group mb-3"">
            <input type=""text"" class=""form-control"" name=""SearchString"" placeholder=""Enter any valid information"" aria-describedby=""basic-addon2"">
            <div class=""input-group-append"">
                <input type=""submit"" value=""Show"" class=""btn btn-light btn-sm"" />
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55ecc1f38c0cbf6633fdc93589dae8ee9dbfc1986429", async() => {
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.BookingId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Client.ClientFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.OrderDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.DayFrom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.DayTill));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.WithKids));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Invoice.TotalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th>\r\n                    ");
#nullable restore
#line 48 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.Info));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n    </table>\r\n    <div style=\"height: 600px; overflow-y: scroll; overflow-x:hidden\">\r\n        <table class=\"table\">\r\n            <tbody>\r\n");
#nullable restore
#line 56 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Booking.BookingId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Client.ClientFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Booking.OrderDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Booking.DayFrom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Booking.DayTill));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Booking.WithKids));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Invoice.TotalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 81 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Booking.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <span class=\"badge badge-light\">\r\n                                ");
#nullable restore
#line 85 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { id = item.Booking.BookingId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </span>\r\n                            <span class=\"badge badge-light\">\r\n                                ");
#nullable restore
#line 88 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                           Write(Html.ActionLink("Invoice", "Invoice", "ClientModel", new { id = item.Booking.BookingId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </span>\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Booking.Info));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 95 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelDb.WebUI.Models.BookingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591