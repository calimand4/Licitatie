#pragma checksum "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bce5d2543d19cf96c754ce585d7e96bd0b7a8c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bce5d2543d19cf96c754ce585d7e96bd0b7a8c82", @"/Views/Items/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aeed63124c827440ed37c269a43369c1c9c66be", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Bid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/bundle/time-calculator.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/bundle/slick.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/bundle/elevatezoom.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/bundle/item-details.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/bundle/slick.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    var isOwner = Model.UserUserName == this.User.Identity.Name ||
        this.User.IsInRole(WebConstants.AdministratorRole);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-12 col-md-8\">\n            <h1 class=\"d-block d-md-none text-wrap-break-word\">");
#nullable restore
#line 11 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            <div>\n                <div class=\"tt-mobile-product-layout text-center\">\n                    <img class=\"zoom-product\"");
            BeginWriteAttribute("src", " src=\"", 493, "\"", 524, 1);
#nullable restore
#line 14 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
WriteAttributeValue("", 499, Model.PrimaryPicturePath, 499, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-zoom-image=\"");
#nullable restore
#line 14 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                                                                          Write(Model.PrimaryPicturePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"max-height:80vh;\"");
            BeginWriteAttribute("alt", " alt=\"", 594, "\"", 600, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                </div>\n                <div class=\"images-carousel ml-0\">\n                    <ul id=\"smallGallery\">\n");
#nullable restore
#line 18 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                         if (Model.Pictures.Count > 1)
                        {
                            foreach (var picture in Model.Pictures)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"#\" class=\"zoom-gallery\" data-image=\"");
#nullable restore
#line 22 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                                                            Write(picture.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-zoom-image=\"");
#nullable restore
#line 22 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                                                                                           Write(picture.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><img");
            BeginWriteAttribute("src", " src=\"", 1029, "\"", 1047, 1);
#nullable restore
#line 22 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
WriteAttributeValue("", 1035, picture.Url, 1035, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1048, "\"", 1054, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a></li>\n");
#nullable restore
#line 23 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
            <div>
                <div class=""card"">
                    <div class=""card-header py-3"">
                        <ul class=""nav nav-pills card-header-tabs"">
                            <li class=""nav-item"">
                                <a class=""nav-link active mb-1"" href=""#"">Details</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""card-body"">
                        <p>");
#nullable restore
#line 38 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <h5 class=\"card-title\">Starting Bid</h5>\n                        <p class=\"card-text\">$");
#nullable restore
#line 40 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                         Write(Model.StartingPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n        </div>\n        <div class=\"col-12 col-md-4\">\n            <h1 class=\"d-none d-md-block text-wrap-break-word\">");
#nullable restore
#line 46 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 47 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
             if (Model.EndTime > DateTime.UtcNow && Model.StartTime < DateTime.UtcNow)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span id=\"identifier\" class=\"float-right\">\n                    Remaining time:\n                    <span id=\"countdown\" class=\"text-red\"></span>\n                </span>\n");
#nullable restore
#line 53 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
            }
            else if (Model.StartTime > DateTime.UtcNow)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span id=\"identifier\" class=\"float-right\">\n                    Time until start:\n                    <span id=\"countdown\" class=\"text-red\"></span>\n                </span>\n");
#nullable restore
#line 60 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"float-right\">\n                    <span class=\"text-red\">Auction ended</span>\n                </span>\n");
#nullable restore
#line 66 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pt-5 pb-5\">\n                <div class=\"card border-dark custom-card-color\">\n                    <div class=\"card-body\">\n                        <p class=\"card-text\">Est. Price: &euro; ");
#nullable restore
#line 70 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                                           Write(Model.StartingPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 70 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                                                                   Write(Model.StartingPrice * 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <div>\n                            <label></label>\n                        </div>\n");
#nullable restore
#line 74 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                         if (Model.EndTime > DateTime.UtcNow && Model.StartTime < DateTime.UtcNow)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"m-2\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce5d2543d19cf96c754ce585d7e96bd0b7a8c8217304", async() => {
                WriteLiteral("\n                                    <span class=\"d-inline d-md-none d-lg-inline\">GO LIVE</span> \n                                    BIDDING\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n");
#nullable restore
#line 82 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""m-2"">
                                <button disabled class=""btn btn-primary btn-lg btn-block"">
                                    <span class=""d-none d-lg-inline"">GO LIVE</span> 
                                    BIDDING
                                </button>
                            </div>
");
#nullable restore
#line 91 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n            \n");
#nullable restore
#line 96 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
             if (isOwner)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card text-center\">\n                    <div class=\"card-header\">Actions</div>\n                    <div class=\"list-group list-group-flush\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce5d2543d19cf96c754ce585d7e96bd0b7a8c8221610", async() => {
                WriteLiteral("\n                            <i class=\"fas fa-pen\"></i> Edit\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
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
            WriteLiteral("\n                    </div>\n                    <div class=\"list-group list-group-flush\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce5d2543d19cf96c754ce585d7e96bd0b7a8c8224062", async() => {
                WriteLiteral("\n                            <i class=\"fas fa-trash\"></i> Delete\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
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
            WriteLiteral("\n                    </div>\n                </div>\n");
#nullable restore
#line 113 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n\n");
            WriteLiteral("<input type=\"hidden\" id=\"end-time-id-for-calculator\"");
            BeginWriteAttribute("value", " value=\"", 5231, "\"", 5267, 1);
#nullable restore
#line 119 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
WriteAttributeValue("", 5239, Model.EndTime.ToString("O"), 5239, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n<input type=\"hidden\" id=\"start-time-id-for-calculator\"");
            BeginWriteAttribute("value", " value=\"", 5326, "\"", 5364, 1);
#nullable restore
#line 120 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
WriteAttributeValue("", 5334, Model.StartTime.ToString("O"), 5334, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce5d2543d19cf96c754ce585d7e96bd0b7a8c8227752", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 123 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce5d2543d19cf96c754ce585d7e96bd0b7a8c8229721", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 124 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce5d2543d19cf96c754ce585d7e96bd0b7a8c8231690", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#nullable restore
#line 125 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("CustomCss", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bce5d2543d19cf96c754ce585d7e96bd0b7a8c8233815", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#nullable restore
#line 129 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bce5d2543d19cf96c754ce585d7e96bd0b7a8c8235855", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#nullable restore
#line 130 "C:\Users\COREi7\Desktop\lucrare\Licitatie\Web\AuctionSystem.Web\Views\Items\Details.cshtml"
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
