#pragma checksum "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\SefcomEnvironment\SefcomEnvironment\SefcomEnvironmentSite\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf655b5c2c67020a0eea93091e6e26696e00443f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf655b5c2c67020a0eea93091e6e26696e00443f", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\SefcomEnvironment\SefcomEnvironment\SefcomEnvironmentSite\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact Us";

#line default
#line hidden
            BeginContext(46, 1446, true);
            WriteLiteral(@"
<div class=""About"" style=""height:100vh;padding-top: 30px;"">
    <div class=""container text-white pt-5"">
        <h1 class=""h1-responsive font-weight-bold text-center my-4 mb-1"">CONTACT US</h1>
        <div class=""row"">
            <!--Grid column-->
            <div class=""col-md-4 col-xl-3"">
                <div class=""contact-icons"">
                    <div>
                        <i class=""fa fa-map-marker fa-2x""></i>
                        <p>
                            10 OFFIN STREET, KWABENYA, ACCRA, GHANA.
                        </p>
                        <p>
                            P.O. BOX TF330, ACCRA, GHANA.
                        </p>
                    </div>

                    <div>
                        <i class=""fa fa-phone fa-2x""></i>
                        <p>+233 245142414, +27 632947083, +233 594203383</p>
                    </div>

                    <div>
                        <i class=""fa fa-envelope fa-2x""></i>
                        <p");
            WriteLiteral(@">
                            <a class=""text-white"" href=""mailto:info@sefcomenvironment.com"">
                                info@info@sefcomenvironment.com
                            </a>
                        </p>
                    </div>
                </div>
            </div>
            <!--Grid column-->
            <!--Grid column-->
            <div class=""col-md-8 col-xl-9"">
                ");
            EndContext();
            BeginContext(1492, 2348, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf655b5c2c67020a0eea93091e6e26696e00443f6184", async() => {
                BeginContext(1568, 2265, true);
                WriteLiteral(@"
                    <!--Grid row-->
                    <div class=""row"">
                        <!--Grid column-->
                        <div class=""col-md-6"">
                            <div class=""md-form"">
                                <div class=""md-form"">
                                    <input type=""text"" id=""name"" name=""name"" class=""form-control"">
                                    <label for=""name"" class="""">Name*</label>
                                </div>
                            </div>
                        </div>
                        <!--Grid column-->
                        <!--Grid column-->
                        <div class=""col-md-6"">
                            <div class=""md-form"">
                                <div class=""md-form"">
                                    <input type=""text"" id=""email"" name=""email"" class=""form-control"">
                                    <label for=""email"" class="""">Email*</label>
                                </div>");
                WriteLiteral(@"
                            </div>
                        </div>
                        <!--Grid column-->
                    </div>
                    <!--Grid row-->
                    <!--Grid row-->
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""md-form"">
                                <input type=""text"" id=""subject"" name=""subject"" class=""form-control"">
                                <label for=""subject"" class="""">Subject*</label>
                            </div>
                        </div>
                    </div>
                    <!--Grid row-->
                    <!--Grid row-->
                    <div class=""row"">
                        <!--Grid column-->
                        <div class=""col-md-12"">
                            <div class=""md-form"">
                                <textarea type=""text"" id=""message"" name=""message"" style=""width: 100%; height: 130px;""></textarea>
   ");
                WriteLiteral("                             <label for=\"message\">Message*</label>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!--Grid row-->\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3840, 297, true);
            WriteLiteral(@"

                <div class=""center-on-small-only"">
                    <a class=""btn btn-primary"" onclick=""document.getElementById('contact-form').submit();"">Send</a>
                </div>
            </div>
            <!--Grid column-->

        </div>
        
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
