#pragma checksum "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1ea8604d98883da79ff1b40ba73fb759981668"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Delete), @"mvc.1.0.view", @"/Views/Items/Delete.cshtml")]
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
#line 1 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\_ViewImports.cshtml"
using AuctionSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\_ViewImports.cshtml"
using AuctionSystem.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\_ViewImports.cshtml"
using AuctionSystem.Web.ViewModels.Item;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\_ViewImports.cshtml"
using AuctionSystem.Web.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\_ViewImports.cshtml"
using AuctionSystem.Web.ViewModels.Category;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1ea8604d98883da79ff1b40ba73fb759981668", @"/Views/Items/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aeed63124c827440ed37c269a43369c1c9c66be", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Items_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/bundle/item-details.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
  
    ViewData["Title"] = "Delete " + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"text-center w-md-75 w-lg-50 mx-auto my-4\">\n        <h2>");
#nullable restore
#line 9 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n        <div class=\"text-left\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1ea8604d98883da79ff1b40ba73fb7599816687737", async() => {
                WriteLiteral("\n                <i class=\"fas fa-chevron-left\"></i>\n                Back to ");
#nullable restore
#line 14 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1ea8604d98883da79ff1b40ba73fb75998166810588", async() => {
                WriteLiteral("\n            <hr/>\n            <div class=\"images-carousel ml-0\">\n                <ul class=\"d-flex no-bullets\">\n");
#nullable restore
#line 22 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                     if (Model.Pictures.Any())
                    {
                        var pictures = Model.Pictures.ToList();

                        foreach (var picture in pictures)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\n                                <a class=\"zoomGalleryActive\" href=\"#\" data-image=\"");
#nullable restore
#line 29 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                                                                             Write(picture.Url);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\n                                   data-zoom-image=\"");
#nullable restore
#line 30 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                                               Write(picture.Url);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1102, "\"", 1120, 1);
#nullable restore
#line 31 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 1108, picture.Url, 1108, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1121, "\"", 1139, 1);
#nullable restore
#line 31 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 1127, Model.Title, 1127, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                                </a>\n                            </li>\n");
#nullable restore
#line 34 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\n                            <a class=\"zoomGalleryActive\" href=\"#\" data-image=\"");
#nullable restore
#line 39 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                                                                         Write(WebConstants.DefaultPictureUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\n                               data-zoom-image=\"");
#nullable restore
#line 40 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                                           Write(WebConstants.DefaultPictureUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1567, "\"", 1604, 1);
#nullable restore
#line 41 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 1573, WebConstants.DefaultPictureUrl, 1573, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1605, "\"", 1623, 1);
#nullable restore
#line 41 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 1611, Model.Title, 1611, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                            </a>\n                        </li>\n");
#nullable restore
#line 44 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\n            </div>\n            <div class=\"form-group\">\n                <label>Title</label>\n                <input class=\"form-control\" disabled=\"disabled\"");
                BeginWriteAttribute("value", " value=\"", 1890, "\"", 1910, 1);
#nullable restore
#line 49 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 1898, Model.Title, 1898, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n            </div>\n            <div class=\"form-group\">\n                <label>Description</label>\n                <textarea class=\"form-control\" disabled=\"disabled\">");
#nullable restore
#line 53 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                                                              Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
            </div>
            <div class=""form-group"">
                <label>Start time</label>
                <input id=""startTime"" class=""form-control"" disabled=""disabled""/>
                <input id=""startTimeValue"" type=""hidden"" disabled=""disabled""");
                BeginWriteAttribute("value", "\n                       value=\"", 2365, "\"", 2426, 1);
#nullable restore
#line 59 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 2396, Model.StartTime.ToString("O"), 2396, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n            </div>\n            <div class=\"form-group\">\n                <label>End time</label>\n                <input id=\"endTime\" class=\"form-control\" disabled=\"disabled\"/>\n                <input id=\"endTimeValue\" type=\"hidden\" disabled=\"disabled\"");
                BeginWriteAttribute("value", "\n                       value=\"", 2679, "\"", 2738, 1);
#nullable restore
#line 65 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 2710, Model.EndTime.ToString("O"), 2710, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n            </div>\n            <div class=\"form-group\">\n                <label>Starting price</label>\n                <input class=\"form-control\" type=\"number\" disabled=\"disabled\"");
                BeginWriteAttribute("value", " value=\"", 2921, "\"", 2949, 1);
#nullable restore
#line 69 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 2929, Model.StartingPrice, 2929, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n            </div>\n            <div class=\"form-group\">\n                <label>Minimal price increase allowed</label>\n                <input class=\"form-control\" type=\"number\" disabled=\"disabled\"");
                BeginWriteAttribute("value", " value=\"", 3148, "\"", 3174, 1);
#nullable restore
#line 73 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 3156, Model.MinIncrease, 3156, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n            </div>\n            <div class=\"form-group\">\n                <label>Category</label>\n                <select class=\"form-control custom-select\" disabled=\"disabled\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1ea8604d98883da79ff1b40ba73fb75998166819020", async() => {
#nullable restore
#line 78 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
                                           Write(Model.SubCategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </select>\n            </div>\n            <div class=\"form-group\">\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3562, "\"", 3579, 1);
#nullable restore
#line 82 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
WriteAttributeValue("", 3570, Model.Id, 3570, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n");
            DefineSection("CustomCss", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e1ea8604d98883da79ff1b40ba73fb75998166822649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 91 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        (function() {
            function setFieldDate(field, isoDate) {
                field.val(getFormattedDate(moment.utc(isoDate).local()));
            }

            setFieldDate($('#startTime'), $(""#startTimeValue"").val());
            setFieldDate($('#endTime'), $(""#endTimeValue"").val());
        })();
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
