#pragma checksum "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a0fad1b10fd0574d2099db9c97fee5c991bd5a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Slideshow), @"mvc.1.0.view", @"/Views/Home/Slideshow.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Slideshow.cshtml", typeof(AspNetCore.Views_Home_Slideshow))]
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
#line 1 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\_ViewImports.cshtml"
using LearningLanguages;

#line default
#line hidden
#line 2 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\_ViewImports.cshtml"
using LearningLanguages.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0fad1b10fd0574d2099db9c97fee5c991bd5a1", @"/Views/Home/Slideshow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38af786468679fa6d2dbc35b23cd1d4d8ad8a953", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Slideshow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DAL.Models.DTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
  
    ViewData["Title"] = "Slideshow";

#line default
#line hidden
            BeginContext(83, 528, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""slidecontainer"">
        Interval: <div id=""valueSlider""></div>
        <input type=""range"" min=""500"" max=""5000"" value=""2250"" class=""slider"" id=""myRange"">
    </div>
    <div class=""row"">
        <div id=""slideshow"" class=""carousel slide container"" data-ride=""carousel"" data-interval=""50"" data-pause=""false"">
            <div class=""carousel-inner border border-success"">
                <div class=""carousel-item active"">
                    <img class=""d-block img-thumbnail""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 611, "\"", 658, 2);
            WriteAttributeValue("", 617, "../../../../", 617, 12, true);
#line 16 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
WriteAttributeValue("", 629, Model.ElementAt(0).Picture, 629, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 659, "\"", 699, 1);
#line 16 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
WriteAttributeValue("", 665, Model.ElementAt(0).WordNativeLang, 665, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(700, 101, true);
            WriteLiteral(">\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h1>");
            EndContext();
            BeginContext(802, 32, false);
#line 18 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
                       Write(Model.ElementAt(0).WordLearnLang);

#line default
#line hidden
            EndContext();
            BeginContext(834, 59, true);
            WriteLiteral("</h1>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 21 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
                 foreach (var word in Model.Skip(1))
                {

#line default
#line hidden
            BeginContext(966, 107, true);
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img class=\"d-block img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1073, "\"", 1104, 2);
            WriteAttributeValue("", 1079, "../../../../", 1079, 12, true);
#line 24 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
WriteAttributeValue("", 1091, word.Picture, 1091, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1105, "\"", 1131, 1);
#line 24 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
WriteAttributeValue("", 1111, word.WordNativeLang, 1111, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1132, 109, true);
            WriteLiteral(">\r\n                        <div class=\"carousel-caption d-none d-md-block\">\r\n                            <h1>");
            EndContext();
            BeginContext(1242, 18, false);
#line 26 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
                           Write(word.WordLearnLang);

#line default
#line hidden
            EndContext();
            BeginContext(1260, 67, true);
            WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 29 "D:\Projects\producthouse_2019_2\WebSpeak v.1\VitaliiMahlona\LearningLanguages\Views\Home\Slideshow.cshtml"
                }

#line default
#line hidden
            BeginContext(1346, 2169, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<style>
    #valueSlider {
        float: right;
    }

    .carousel-caption {
        position: relative;
        left: auto;
        right: auto;
        color: black;
    }

    img {
        height: auto;
        width: auto;
    }

    #slideshow {
        width: 512px;
        height: auto;
    }

    .carousel-item {
        height: auto;
    }

    .slidecontainer {
        width: 25%; /* Width of the outside container */
    }

    /* The slider itself */
    .slider {
        -webkit-appearance: none; /* Override default CSS styles */
        width: 100%; /* Full-width */
        height: 25px; /* Specified height */
        background: #d3d3d3; /* Grey background */
        outline: none; /* Remove outline */
        opacity: 0.7; /* Set transparency (for mouse-over effects on hover) */
        -webkit-transition: .2s; /* 0.2 seconds transition on hover */
        transition: opacity .2s;
    }

    /*");
            WriteLiteral(@" Mouse-over effects */
    .slider:hover {
        opacity: 1; /* Fully shown on mouse-over */
    }

    /* The slider handle (use -webkit- (Chrome, Opera, Safari, Edge) and -moz- (Firefox) to override default look) */
    .slider::-webkit-slider-thumb {
        -webkit-appearance: none; /* Override default look */
        width: 25px; /* Set a specific slider handle width */
        height: 25px; /* Slider handle height */
        background: #4CAF50; /* Green background */
        cursor: pointer; /* Cursor on hover */
    }
</style>

<script>
    var slider = document.getElementById(""myRange"");
    var output = document.getElementById(""valueSlider"");
    var slideshow = document.getElementsByClassName('carousel-item')

    for (let i = 0; i < slideshow.length; i++) {
        slideshow[i].style.transitionDelay = slider.value + ""ms"";
    }

    output.innerHTML = slider.value;

    slider.oninput = function () {
        for (let i = 0; i < slideshow.length; i++) {
            sli");
            WriteLiteral("deshow[i].style.transitionDelay = this.value + \"ms\";\r\n        }\r\n        output.innerHTML = this.value;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DAL.Models.DTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
