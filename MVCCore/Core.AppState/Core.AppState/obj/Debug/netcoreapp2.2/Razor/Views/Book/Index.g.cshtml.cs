#pragma checksum "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d5f2c43e5d68e29bcb80b366a6ca5404c16dc11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
using Core.AppState.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d5f2c43e5d68e29bcb80b366a6ca5404c16dc11", @"/Views/Book/Index.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(59, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(88, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d5f2c43e5d68e29bcb80b366a6ca5404c16dc113378", async() => {
                BeginContext(94, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(188, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(190, 459, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d5f2c43e5d68e29bcb80b366a6ca5404c16dc114652", async() => {
                BeginContext(196, 29, true);
                WriteLiteral("\r\n    <h1>Index book 1</h1>\r\n");
                EndContext();
#line 16 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
      
        var address = ViewData["Address"] as Address;
    

#line default
#line hidden
                BeginContext(295, 8, true);
                WriteLiteral("    <h1>");
                EndContext();
                BeginContext(304, 16, false);
#line 19 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
   Write(ViewData["Gree"]);

#line default
#line hidden
                EndContext();
                BeginContext(320, 15, true);
                WriteLiteral("</h1>\r\n    <h1>");
                EndContext();
                BeginContext(336, 12, false);
#line 20 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
   Write(address.name);

#line default
#line hidden
                EndContext();
                BeginContext(348, 15, true);
                WriteLiteral("</h1>\r\n    <h1>");
                EndContext();
                BeginContext(364, 12, false);
#line 21 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
   Write(address.city);

#line default
#line hidden
                EndContext();
                BeginContext(376, 61, true);
                WriteLiteral("</h1>\r\n    <hr />\r\n    <p>---------------------</p>\r\n    <h1>");
                EndContext();
                BeginContext(438, 16, false);
#line 24 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
   Write(ViewBag.Greeting);

#line default
#line hidden
                EndContext();
                BeginContext(454, 15, true);
                WriteLiteral("</h1>\r\n    <h1>");
                EndContext();
                BeginContext(470, 20, false);
#line 25 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
   Write(ViewBag.Address.name);

#line default
#line hidden
                EndContext();
                BeginContext(490, 15, true);
                WriteLiteral("</h1>\r\n    <h1>");
                EndContext();
                BeginContext(506, 20, false);
#line 26 "F:\Code\2. .Net Core\1. git Learning .Net Core\MVCCore\Core.AppState\Core.AppState\Views\Book\Index.cshtml"
   Write(ViewBag.Address.city);

#line default
#line hidden
                EndContext();
                BeginContext(526, 116, true);
                WriteLiteral("</h1> \r\n    <form action=\"/Book/Index2\" method=\"post\">\r\n        <button type=\"submit\">Next</button>\r\n    </form>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(649, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
