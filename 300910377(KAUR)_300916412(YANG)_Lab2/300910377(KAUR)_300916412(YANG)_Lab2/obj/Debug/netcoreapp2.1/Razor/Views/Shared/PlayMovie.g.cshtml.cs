#pragma checksum "E:\Professional\Projects\COMP306_CloudComputingAPI\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Shared\PlayMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b31b4f73fff56c50e51f5012c8e470f2a10bdbb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PlayMovie), @"mvc.1.0.view", @"/Views/Shared/PlayMovie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PlayMovie.cshtml", typeof(AspNetCore.Views_Shared_PlayMovie))]
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
#line 1 "E:\Professional\Projects\COMP306_CloudComputingAPI\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\_ViewImports.cshtml"
using _300910377_KAUR__300916412_YANG__Lab2;

#line default
#line hidden
#line 2 "E:\Professional\Projects\COMP306_CloudComputingAPI\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\_ViewImports.cshtml"
using _300910377_KAUR__300916412_YANG__Lab2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b31b4f73fff56c50e51f5012c8e470f2a10bdbb5", @"/Views/Shared/PlayMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1867e91a375f3da73f87f7b717640d5c8e354a7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PlayMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_300910377_KAUR__300916412_YANG__Lab2.Models.PlayMovie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Professional\Projects\COMP306_CloudComputingAPI\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Shared\PlayMovie.cshtml"
  
    ViewData["Title"] = "PlayMovie";
    ViewData["BasePath"] = "~/movies/";

#line default
#line hidden
            BeginContext(149, 73, true);
            WriteLiteral("\r\n<h2>PlayMovie</h2>\r\n\r\n<div id=\"Container\">\r\n    <video id=\"videoPlayer\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 222, "\"", 285, 1);
#line 10 "E:\Professional\Projects\COMP306_CloudComputingAPI\comp306_lab2\300910377(KAUR)_300916412(YANG)_Lab2\300910377(KAUR)_300916412(YANG)_Lab2\Views\Shared\PlayMovie.cshtml"
WriteAttributeValue("", 228, Url.Content( ViewData["BasePath"]+ Model.movie.FileName), 228, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(286, 56, true);
            WriteLiteral(" height=\"400\" width=\"700\" controls ></video>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_300910377_KAUR__300916412_YANG__Lab2.Models.PlayMovie> Html { get; private set; }
    }
}
#pragma warning restore 1591