#pragma checksum "C:\Users\there\source\repos\API Practice\API Practice\Views\Home\GetRandomJoke.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99125e6c5390908287d192448bef3a8a1ec3448"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetRandomJoke), @"mvc.1.0.view", @"/Views/Home/GetRandomJoke.cshtml")]
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
#line 1 "C:\Users\there\source\repos\API Practice\API Practice\Views\_ViewImports.cshtml"
using API_Practice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\there\source\repos\API Practice\API Practice\Views\_ViewImports.cshtml"
using API_Practice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a99125e6c5390908287d192448bef3a8a1ec3448", @"/Views/Home/GetRandomJoke.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca64fbd2d3963a677c47a646b3559c7ad69c927", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetRandomJoke : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API_Practice.Models.ViewModels.RandomJokeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    <h3>");
#nullable restore
#line 5 "C:\Users\there\source\repos\API Practice\API Practice\Views\Home\GetRandomJoke.cshtml"
   Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 6 "C:\Users\there\source\repos\API Practice\API Practice\Views\Home\GetRandomJoke.cshtml"
   Write(Model.Setup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 7 "C:\Users\there\source\repos\API Practice\API Practice\Views\Home\GetRandomJoke.cshtml"
   Write(Model.Punchline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API_Practice.Models.ViewModels.RandomJokeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
