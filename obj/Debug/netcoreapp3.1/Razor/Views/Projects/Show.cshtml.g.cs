#pragma checksum "C:\Users\Martin\Documents\testMVC\Views\Projects\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef50c79881c01a7ed8995c767d6a1ee99ff551db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Show), @"mvc.1.0.view", @"/Views/Projects/Show.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Martin\Documents\testMVC\Views\_ViewImports.cshtml"
using testMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Martin\Documents\testMVC\Views\_ViewImports.cshtml"
using testMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef50c79881c01a7ed8995c767d6a1ee99ff551db", @"/Views/Projects/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b15ed2c62f2af19a1c6de1f2e477cb216ce9fe6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<html>
    <h1> --Project Name-- </h1>
    <div id=""document-base-content"">
        --Document Base Content / Description--
    </div>

    <div id=""project-contents"">
         <div id=""stories"">
            --Stories Partial Go Here--
        </div>

        <div id=""documentation"">
            --Documentation Partial Goes Here--
        </div>
    </div>
    
</html>");
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
