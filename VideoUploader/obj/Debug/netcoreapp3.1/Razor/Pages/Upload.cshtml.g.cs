#pragma checksum "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4192f646c6c0fdcf7044849ec0d23153fb8583fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VideoUploader.Pages.Pages_Upload), @"mvc.1.0.razor-page", @"/Pages/Upload.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4192f646c6c0fdcf7044849ec0d23153fb8583fb", @"/Pages/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c587f4f0239c0a813b15697c48056dc3c4ae33", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Upload : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Gamer\source\repos\VideoUploader\VideoUploader\Pages\Upload.cshtml"
  
    ViewData["Title"] = "Upload";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4192f646c6c0fdcf7044849ec0d23153fb8583fb4522", async() => {
                WriteLiteral(@"

        <div class=""row row-cols-1 mb-1"">
            <div class=""col""><h3 class=""h3 float-left text-light"">Title:</h3></div>
            <div class=""col input-group mb-3"">
                <input class=""form-control text-light border-info border-0 card-shadow"" placeholder=""Title..."" type=""text"" name=""title"" />
            </div>
        </div>

        <div class=""row row-cols-1 mb-3"">
            <div class=""col""><h5 class=""h5 float-left text-light"">Description:</h5></div>
            <div class=""col input-group mb-3"">
                <input class=""d-none"" type=""text"" name=""description"" id=""description"" />
                <textarea class=""form-control text-light border-0 card-shadow"" placeholder=""Description..."" id=""textArea"" oninput=""ConvertText()""></textarea>
            </div>

            <script type=""text/javascript"">
                function ConvertText() {
                    document.getElementById(""description"").value = document.getElementById(""textArea"").value;
               ");
                WriteLiteral(@" }

            </script>
        </div>

        <div class=""row row-cols-1 row-cols-sm-2 mb-5"">

            <div class=""col text-center mb-3 mb-sm-0"">
                <input class=""d-none"" accept=""video/*"" type=""file"" name=""videoFile"" id=""videoFile"" oninput=""OnChange('videoFile', 'videoFilePath')"" />
                <div class=""m-3"">
                    <label class=""file-input"" for=""videoFile"" data-toggle=""tooltip"" data-placement=""top"" title=""Video"">
                        <i class=""fa fa-film fa-3x""></i>
                    </label>
                </div>
                <small class=""text-light"" id=""videoFilePath""></small>
            </div>

            <div class=""col text-center"">
                <input class=""d-none"" accept=""image/*"" type=""file"" name=""thumbnailFile"" id=""thumbnailFile"" oninput=""OnChange('thumbnailFile', 'thumbnailFilePath')"" />
                <div class=""m-3"">
                    <label class=""file-input"" for=""thumbnailFile"" data-toggle=""tooltip"" data-placement=");
                WriteLiteral(@"""top"" title=""Thumbnail"">
                        <i class=""fa fa-image fa-3x""></i>
                    </label>
                </div>
                <small class=""text-light"" id=""thumbnailFilePath"" ></small>
            </div>   

        </div>
        <div class=""row row-cols-1 row-cols-sm-2"">
            <div class=""col p-0""><button class=""btn btn-dark position-relative rounded-0 w-100"" type=""submit"">Upload</button></div>
            <div class=""col p-0""><button class=""btn btn-danger position-relative rounded-0 w-100"" type=""reset"" onclick=""OnReset()"">Reset</button></div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <script type=""text/javascript"">
        function OnChange(file, filePath) {
            document.getElementById(filePath).textContent = (document.getElementById(file).value).replace(/^.*[\\\/]/, '');
        }

        function OnReset() {
            document.getElementById(""videoFilePath"").textContent = null;
            document.getElementById(""thumbnailFilePath"").textContent = null;
        }
    </script>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UploadModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UploadModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UploadModel>)PageContext?.ViewData;
        public UploadModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
