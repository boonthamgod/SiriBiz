#pragma checksum "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e7c38d6b801d0bf067bae2356c35d18f07868d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\_ViewImports.cshtml"
using SiriBiz.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\_ViewImports.cshtml"
using SiriBiz.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e7c38d6b801d0bf067bae2356c35d18f07868d6", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc585eeaf7308658e2a79d95c55d0a94bd74cf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 9 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 11 "C:\Users\boontham\source\repos\boonthamgod\SiriBiz\SiriBizWeb\SiriBiz.App\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container d-flex flex-column justify-content-center pt-5 mt-n6"" style=""flex: 1 0 auto;"">
    <div class=""pt-7 pb-5"">
        <div class=""text-center mb-2 pb-4"">
            <h1 class=""mb-5"">
                <img class=""d-inline-block"" src=""img/pages/404/404-text.svg"" alt=""Error 404"" /><span class=""sr-only"">Error 404</span>
            </h1>
            <h2>Page not found!</h2>
            <p class=""pb-2"">It seems we can’t find the page you are looking for.</p><a class=""btn btn-translucent-primary mr-3"" href=""index.html"">Go to homepage</a><span>Or try</span>
        </div>
        <div class=""input-group-overlay mx-auto"" style=""max-width: 390px;"">
            <div class=""input-group-prepend-overlay""><span class=""input-group-text""><i class=""fe-search""></i></span></div>
            <input class=""form-control prepended-form-control"" type=""text"" placeholder=""Search"">
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591