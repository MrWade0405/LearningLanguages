#pragma checksum "D:\Projects\LearnLang\LearningLanguages\Views\Home\Test01.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "161aa1672a2d2274f29c57f44ae7292b1218bdfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test01), @"mvc.1.0.view", @"/Views/Home/Test01.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Test01.cshtml", typeof(AspNetCore.Views_Home_Test01))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"161aa1672a2d2274f29c57f44ae7292b1218bdfb", @"/Views/Home/Test01.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38af786468679fa6d2dbc35b23cd1d4d8ad8a953", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test01 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DAL.Models.Words>>
    {
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Test01.cshtml"
  
    ViewData["Title"] = "Test01";

#line default
#line hidden
            BeginContext(82, 23, true);
            WriteLiteral("\r\n<div class=\"words\">\r\n");
            EndContext();
#line 8 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Test01.cshtml"
     foreach (var word in Model)
    {

#line default
#line hidden
            BeginContext(146, 32, true);
            WriteLiteral("    <div class=\"word\">\r\n        ");
            EndContext();
            BeginContext(178, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "161aa1672a2d2274f29c57f44ae7292b1218bdfb3753", async() => {
                BeginContext(259, 18, true);
                WriteLiteral("\r\n            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 277, "\"", 308, 2);
                WriteAttributeValue("", 283, "../../../../", 283, 12, true);
#line 12 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Test01.cshtml"
WriteAttributeValue("", 295, word.Picture, 295, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(309, 25, true);
                WriteLiteral(" width=\"256\" height=\"256\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 334, "\"", 350, 1);
#line 12 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Test01.cshtml"
WriteAttributeValue("", 340, word.Name, 340, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(351, 11, true);
                WriteLiteral(">\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 187, "~/Home/Categories/SubCategories/Tests/Test01?id=", 187, 48, true);
#line 11 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Test01.cshtml"
AddHtmlAttributeValue("", 235, ViewBag.subCategoryId, 235, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(366, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 15 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Test01.cshtml"
    }

#line default
#line hidden
            BeginContext(387, 192, true);
            WriteLiteral("</div>\r\n\r\n<style>\r\n    .words {\r\n        display: flex; \r\n        height: 300px; \r\n    }\r\n    .word {\r\n        width: 256px; \r\n        height: 256px;\r\n        margin: auto; \r\n    }\r\n\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DAL.Models.Words>> Html { get; private set; }
    }
}
#pragma warning restore 1591
