#pragma checksum "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "265fd03a484f8b802518fb4b9e591de735387940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Edit), @"mvc.1.0.view", @"/Views/Users/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Edit.cshtml", typeof(AspNetCore.Views_Users_Edit))]
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
#line 1 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\_ViewImports.cshtml"
using InvoiceWebApp;

#line default
#line hidden
#line 2 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\_ViewImports.cshtml"
using InvoiceWebApp.Models;

#line default
#line hidden
#line 3 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\_ViewImports.cshtml"
using InvoiceWebApp.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\_ViewImports.cshtml"
using InvoiceWebApp.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
using System.Diagnostics;

#line default
#line hidden
#line 2 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
using InvoiceWebApp.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265fd03a484f8b802518fb4b9e591de735387940", @"/Views/Users/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4685d22e54b1478206bdc34d535b7f798dcf83e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceWebApp.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("indigo-text text-darken-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(123, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
  
    ViewData["Title"] = "Manage User";
    Layout = "~/Views/Shared/_Layout.cshtml";

    AppSettings settings = null;
    if (SessionHelper.IsExists(Context.Session, "Settings")) {
        Debug.WriteLine("Settings exists");
        settings = SessionHelper.Get<AppSettings>(Context.Session, "Settings");
    }
    if (!SessionHelper.IsExists(Context.Session, "Settings")) {
        settings = _context.Settings.FirstOrDefault();
        SessionHelper.Set(Context.Session, "Settings", settings);
    }

#line default
#line hidden
            BeginContext(632, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("HEAD", async() => {
                BeginContext(648, 2, true);
                WriteLiteral("\n\t");
                EndContext();
                BeginContext(650, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "265fd03a484f8b802518fb4b9e591de7353879408440", async() => {
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
                BeginContext(697, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(700, 338, true);
            WriteLiteral(@"
<div class=""container"" id=""edit-user"">

    <div class=""row"">
        <div class=""col s12 col m12 center-align"">
            <h4 style=""margin-top: 0px;"">Manage User</h4>
        </div>
    </div>

    <br />

    <!--Form-->
    <div class=""row"" style=""margin-top: 5px;"">
        <div class=""col s12 col col m10 offset-m1"">
            ");
            EndContext();
            BeginContext(1038, 4428, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "265fd03a484f8b802518fb4b9e591de73538794010248", async() => {
                BeginContext(1114, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(1131, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "265fd03a484f8b802518fb4b9e591de73538794010647", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 39 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1167, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(1184, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "265fd03a484f8b802518fb4b9e591de73538794012480", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 40 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DebtorID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1226, 309, true);
                WriteLiteral(@"

                <fieldset>
                    <legend>Personal Information</legend>

                    <div class=""row"">
                        <div class=""input-field col s12 col m4 offset-m2"">
                            <i class=""material-icons prefix"">person_outline</i>
                            ");
                EndContext();
                BeginContext(1536, 118, false);
#line 48 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Debtor.FirstName, new { @id = "icon_firstname", @disabled = "disabled", @class = "no-submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(1654, 280, true);
                WriteLiteral(@"
                            <label for=""icon_firstname"">First Name</label>
                        </div>
                        <div class=""input-field col s12 col m4"">
                            <i class=""material-icons prefix"">person_outline</i>
                            ");
                EndContext();
                BeginContext(1935, 116, false);
#line 53 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Debtor.LastName, new { @id = "icon_lastname", @disabled = "disabled", @class = "no-submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(2051, 345, true);
                WriteLiteral(@"
                            <label for=""icon_lastname"">Last Name</label>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""input-field col s12 col m4 offset-m2"">
                            <i class=""material-icons prefix"">email</i>
                            ");
                EndContext();
                BeginContext(2397, 102, false);
#line 61 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { @id = "icon_email", @disabled = "disabled", @class = "validate" }));

#line default
#line hidden
                EndContext();
                BeginContext(2499, 361, true);
                WriteLiteral(@"
                            <label for=""icon_email"" data-error=""This email address is not valid.""
							   data-success=""This email address is valid."">Email</label>
                        </div>
                        <div class=""input-field col s12 col m4"">
                            <i class=""material-icons prefix"">lock</i>
                            ");
                EndContext();
                BeginContext(2861, 78, false);
#line 67 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Password, new { @id = "icon_password", type = "text" }));

#line default
#line hidden
                EndContext();
                BeginContext(2939, 444, true);
                WriteLiteral(@"
                            <label for=""icon_password"">Password</label>
                        </div>
                    </div>
                </fieldset>

                <fieldset>
                    <legend>Address</legend>
                    <div class=""row"">
                        <div class=""input-field col s12 col m4 offset-m2"">
                            <i class=""material-icons prefix"">place</i>
                            ");
                EndContext();
                BeginContext(3384, 114, false);
#line 78 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Debtor.Address, new { @id = "icon_address", @disabled = "disabled", @class = "no-submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(3498, 266, true);
                WriteLiteral(@"
                            <label for=""icon_address"">Address</label>
                        </div>
                        <div class=""input-field col s12 col m4"">
                            <i class=""material-icons prefix"">place</i>
                            ");
                EndContext();
                BeginContext(3765, 116, false);
#line 83 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Debtor.PostalCode, new { @id = "icon_postal", @disabled = "disabled", @class = "no-submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(3881, 345, true);
                WriteLiteral(@"
                            <label for=""icon_postal"">Postal Code</label>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""input-field col s12 col m4 offset-m2"">
                            <i class=""material-icons prefix"">place</i>
                            ");
                EndContext();
                BeginContext(4227, 108, false);
#line 91 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Debtor.City, new { @id = "icon_city", @disabled = "disabled", @class = "no-submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(4335, 260, true);
                WriteLiteral(@"
                            <label for=""icon_city"">City</label>
                        </div>
                        <div class=""input-field col s12 col m4"">
                            <i class=""material-icons prefix"">place</i>
                            ");
                EndContext();
                BeginContext(4596, 114, false);
#line 96 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Debtor.Country, new { @id = "icon_country", @disabled = "disabled", @class = "no-submit" }));

#line default
#line hidden
                EndContext();
                BeginContext(4710, 610, true);
                WriteLiteral(@"
                            <label for=""icon_country"">Country</label>
                        </div>
                    </div>
                </fieldset>

                <div class=""row"">
                    <div id=""button-area"">
                        <button id=""edit-user-btn"" type=""submit"" value=""Save""
                                class=""btn-large indigo darken-1 waves-effect waves-light"">
                            <i class=""material-icons left"">save</i>
                            <span>Save</span>
                        </button>

                        <br />

                        ");
                EndContext();
                BeginContext(5320, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "265fd03a484f8b802518fb4b9e591de73538794021286", async() => {
                    BeginContext(5376, 16, true);
                    WriteLiteral("Back to Overview");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5396, 63, true);
                WriteLiteral("\n                    </div>\n                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5466, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5519, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 121 "D:\PROJECT 2019\INVOICE\MVC-Invoice2-master\InvoiceWebApp\Views\Users\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(5587, 121, true);
                WriteLiteral("    \n    <script>\n        $(\"#form\").submit(function() {\n            $(\".no-submit\").remove();\n        });\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(5710, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext _context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceWebApp.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591