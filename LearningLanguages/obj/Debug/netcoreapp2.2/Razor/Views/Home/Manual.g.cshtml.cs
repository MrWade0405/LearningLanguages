#pragma checksum "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a57d3a37b198f69c07ed804158ab8f31ac8fcd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Manual), @"mvc.1.0.view", @"/Views/Home/Manual.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Manual.cshtml", typeof(AspNetCore.Views_Home_Manual))]
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
#line 1 "D:\Projects\LearnLang\LearningLanguages\Views\_ViewImports.cshtml"
using LearningLanguages;

#line default
#line hidden
#line 2 "D:\Projects\LearnLang\LearningLanguages\Views\_ViewImports.cshtml"
using LearningLanguages.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a57d3a37b198f69c07ed804158ab8f31ac8fcd0", @"/Views/Home/Manual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38af786468679fa6d2dbc35b23cd1d4d8ad8a953", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Manual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<dynamic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
  
    ViewData["Title"] = "Manual";

#line default
#line hidden
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(808, 308, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div id=""slideshow"" class=""carousel slide container"" data-ride=""carousel"" data-interval=""false"">
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img class=""d-block w-100 img-thumbnail""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1116, "\"", 1163, 2);
            WriteAttributeValue("", 1122, "../../../../", 1122, 12, true);
#line 28 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
WriteAttributeValue("", 1134, Model.ElementAt(0).Picture, 1134, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1164, "\"", 1194, 1);
#line 28 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
WriteAttributeValue("", 1170, Model.ElementAt(0).Name, 1170, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1195, 101, true);
            WriteLiteral(">\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h1>");
            EndContext();
            BeginContext(1298, 23, false);
#line 30 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
                        Write(Model.ElementAt(0).Name);

#line default
#line hidden
            EndContext();
            BeginContext(1322, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1326, 24, false);
#line 30 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
                                                    Write(Model.ElementAt(0).Learn);

#line default
#line hidden
            EndContext();
            BeginContext(1351, 60, true);
            WriteLiteral(")</h1>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 33 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
                 foreach (dynamic word in Model.Skip(1))
                {

#line default
#line hidden
            BeginContext(1488, 113, true);
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img class=\"d-block w-100 img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1601, "\"", 1626, 2);
            WriteAttributeValue("", 1607, "../../", 1607, 6, true);
#line 36 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
WriteAttributeValue("", 1613, word.Picture, 1613, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1627, "\"", 1643, 1);
#line 36 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
WriteAttributeValue("", 1633, word.Name, 1633, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1644, 109, true);
            WriteLiteral(">\r\n                        <div class=\"carousel-caption d-none d-md-block\">\r\n                            <h1>");
            EndContext();
            BeginContext(1754, 9, false);
#line 38 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
                           Write(word.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1763, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1766, 10, false);
#line 38 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
                                       Write(word.Learn);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 68, true);
            WriteLiteral(")</h1>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 41 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Manual.cshtml"
                }

#line default
#line hidden
            BeginContext(1863, 706, true);
            WriteLiteral(@"            </div>
            <a class=""carousel-control-prev"" href=""#slideshow"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#slideshow"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
</div>
<style>
    .carousel-caption {
        position: relative;
        left: auto;
        right: auto;
        color: black;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<dynamic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
