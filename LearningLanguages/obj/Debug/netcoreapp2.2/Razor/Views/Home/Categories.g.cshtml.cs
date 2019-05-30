#pragma checksum "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3cec07be2e606292a941cef81423920adc0eeb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Categories), @"mvc.1.0.view", @"/Views/Home/Categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Categories.cshtml", typeof(AspNetCore.Views_Home_Categories))]
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
#line 1 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
using DAL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3cec07be2e606292a941cef81423920adc0eeb1", @"/Views/Home/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38af786468679fa6d2dbc35b23cd1d4d8ad8a953", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DTO>>
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
#line 3 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
  
    ViewData["Title"] = "Category";

#line default
#line hidden
            BeginContext(88, 28, true);
            WriteLiteral("\r\n<div class=\"categories\">\r\n");
            EndContext();
#line 8 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
            BeginContext(161, 36, true);
            WriteLiteral("    <div class=\"category\">\r\n        ");
            EndContext();
            BeginContext(197, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3cec07be2e606292a941cef81423920adc0eeb13819", async() => {
                BeginContext(255, 17, true);
                WriteLiteral("\r\n            <p>");
                EndContext();
                BeginContext(273, 23, false);
#line 12 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
          Write(category.WordNativeLang);

#line default
#line hidden
                EndContext();
                BeginContext(296, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(299, 22, false);
#line 12 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
                                    Write(category.WordLearnLang);

#line default
#line hidden
                EndContext();
                BeginContext(321, 23, true);
                WriteLiteral(")</p>\r\n            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 344, "\"", 370, 2);
                WriteAttributeValue("", 350, "../", 350, 3, true);
#line 13 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
WriteAttributeValue("", 353, category.Picture, 353, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(371, 25, true);
                WriteLiteral(" width=\"128\" height=\"128\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 396, "\"", 426, 1);
#line 13 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
WriteAttributeValue("", 402, category.WordNativeLang, 402, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(427, 11, true);
                WriteLiteral(">\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 206, "~/Home/Categories/SubCategories?id=", 206, 35, true);
#line 11 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
AddHtmlAttributeValue("", 241, category.Id, 241, 12, false);

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
            BeginContext(442, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 16 "D:\Projects\LearnLang\LearningLanguages\Views\Home\Categories.cshtml"
     }

#line default
#line hidden
            BeginContext(464, 237, true);
            WriteLiteral("</div>\r\n\r\n<style>\r\n    .categories {\r\n        display: flex;\r\n        flex-direction: column;\r\n        text-align: center;\r\n    }\r\n\r\n    .category {\r\n        width: 225px;\r\n        height: 225px; \r\n        margin: auto; \r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
