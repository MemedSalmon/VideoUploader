#pragma checksum "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\Watch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e35efc6cc24c30e8c1c78f72bddc997d4ddf6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VideoUploader.Pages.Pages_Watch), @"mvc.1.0.razor-page", @"/Pages/Watch.cshtml")]
namespace VideoUploader.Pages
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
#line 1 "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\_ViewImports.cshtml"
using VideoUploader;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e35efc6cc24c30e8c1c78f72bddc997d4ddf6b", @"/Pages/Watch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c587f4f0239c0a813b15697c48056dc3c4ae33", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Watch : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\Watch.cshtml"
  
    ViewData["Title"] = Model.Video.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row row-cols-1\">\r\n\r\n    <div class=\"col p-3 p-sm-0 pt-sm-3 pb-sm-3 border-top\">\r\n        <h1 class=\"text-light m-0\">");
#nullable restore
#line 10 "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\Watch.cshtml"
                              Write(Model.Video.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n\r\n    <div class=\"col p-0\">\r\n        <video controls autoplay>\r\n            <source");
            BeginWriteAttribute("src", " src=\"", 347, "\"", 375, 1);
#nullable restore
#line 15 "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\Watch.cshtml"
WriteAttributeValue("", 353, Model.Video.VideoPath, 353, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("type", " type=\"", 376, "\"", 405, 1);
#nullable restore
#line 15 "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\Watch.cshtml"
WriteAttributeValue("", 383, Model.Video.Extension, 383, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </video>\r\n    </div>\r\n\r\n    <div class=\"col p-3 p-sm-0 pt-sm-3 pb-sm-3 border-bottom\">\r\n        <h5 class=\"text-light m-0\">");
#nullable restore
#line 20 "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\Watch.cshtml"
                              Write(Model.Video.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoUploader.Pages.WatchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VideoUploader.Pages.WatchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VideoUploader.Pages.WatchModel>)PageContext?.ViewData;
        public VideoUploader.Pages.WatchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591