#pragma checksum "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\DatabaseTutorials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb9f76246ad732066e86a6d8fc516db3e82912db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesInz.Pages.Pages_DatabaseTutorials), @"mvc.1.0.razor-page", @"/Pages/DatabaseTutorials.cshtml")]
namespace RazorPagesInz.Pages
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
#line 1 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\_ViewImports.cshtml"
using RazorPagesInz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\_ViewImports.cshtml"
using RazorPagesInz.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\_ViewImports.cshtml"
using Razor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb9f76246ad732066e86a6d8fc516db3e82912db", @"/Pages/DatabaseTutorials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44147cc95ed45304c46364814cbd6e7d3dff5b92", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DatabaseTutorials : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top-thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\DatabaseTutorials.cshtml"
  
    ViewData["Title"] = "DatabaseTutorials";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DatabaseTutorials</h1>\r\n\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 10 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\DatabaseTutorials.cshtml"
     foreach (var res in Model.resPages.Where(n=> n.resCat==Razor.Models.ResCategory.Database))
    {
     var imgpath =  res.Img_path;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card m-3\" style=\"min-width:18rem; max-width:30.5%;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb9f76246ad732066e86a6d8fc516db3e82912db4555", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\DatabaseTutorials.cshtml"
      WriteLiteral(imgpath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\DatabaseTutorials.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\DatabaseTutorials.cshtml"
                              Write(res.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 559, "\"", 575, 1);
#nullable restore
#line 17 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\DatabaseTutorials.cshtml"
WriteAttributeValue("", 566, res.Link, 566, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary m1 text-center\">Przejdz do materiału</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Ashu\source\repos\RazorPagesInz\RazorPagesInz\Pages\DatabaseTutorials.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesInz.Pages.DatabaseTutorialsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesInz.Pages.DatabaseTutorialsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesInz.Pages.DatabaseTutorialsModel>)PageContext?.ViewData;
        public RazorPagesInz.Pages.DatabaseTutorialsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591