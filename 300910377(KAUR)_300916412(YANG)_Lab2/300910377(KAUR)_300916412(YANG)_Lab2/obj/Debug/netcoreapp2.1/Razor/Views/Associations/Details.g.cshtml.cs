#pragma checksum "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43628db53e2976cc15de07c4d8f70071bcc522c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Associations_Details), @"mvc.1.0.view", @"/Views/Associations/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Associations/Details.cshtml", typeof(AspNetCore.Views_Associations_Details))]
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
#line 1 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\_ViewImports.cshtml"
using _300910377_KAUR__300916412_YANG__Lab2;

#line default
#line hidden
#line 2 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\_ViewImports.cshtml"
using _300910377_KAUR__300916412_YANG__Lab2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43628db53e2976cc15de07c4d8f70071bcc522c9", @"/Views/Associations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1867e91a375f3da73f87f7b717640d5c8e354a7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Associations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_300910377_KAUR__300916412_YANG__Lab2.Models.Association>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(110, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Association</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(236, 42, false);
#line 14 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(278, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(322, 38, false);
#line 17 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(360, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(404, 43, false);
#line 20 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VideoId));

#line default
#line hidden
            EndContext();
            BeginContext(447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(491, 39, false);
#line 23 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml"
       Write(Html.DisplayFor(model => model.VideoId));

#line default
#line hidden
            EndContext();
            BeginContext(530, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(574, 45, false);
#line 26 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CommentId));

#line default
#line hidden
            EndContext();
            BeginContext(619, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(663, 41, false);
#line 29 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml"
       Write(Html.DisplayFor(model => model.CommentId));

#line default
#line hidden
            EndContext();
            BeginContext(704, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(751, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f12c42c82d4aa0b3108f4b44764255", async() => {
                BeginContext(808, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "E:\FW2018 - 2019\COMP 306\Assignment\A2\Team Version\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Associations\Details.cshtml"
                           WriteLiteral(Model.AssociationId);

#line default
#line hidden
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
            EndContext();
            BeginContext(816, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(824, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa9e01f38b9b4a8ea8e45db4ab0e8486", async() => {
                BeginContext(846, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(862, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_300910377_KAUR__300916412_YANG__Lab2.Models.Association> Html { get; private set; }
    }
}
#pragma warning restore 1591
