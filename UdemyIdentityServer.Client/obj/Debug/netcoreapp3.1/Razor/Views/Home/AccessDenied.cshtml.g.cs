#pragma checksum "C:\Users\ONUR\source\repos\UdemyIdentityServer\UdemyIdentityServer.Client\Views\Home\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c5aff932064a0c6b07080a6bd30f5e8e58c73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AccessDenied), @"mvc.1.0.view", @"/Views/Home/AccessDenied.cshtml")]
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
#line 1 "C:\Users\ONUR\source\repos\UdemyIdentityServer\UdemyIdentityServer.Client\Views\_ViewImports.cshtml"
using UdemyIdentityServer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ONUR\source\repos\UdemyIdentityServer\UdemyIdentityServer.Client\Views\_ViewImports.cshtml"
using UdemyIdentityServer.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c5aff932064a0c6b07080a6bd30f5e8e58c73f", @"/Views/Home/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f87ca264ce3b193051e14b385e8d71223e01224d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ONUR\source\repos\UdemyIdentityServer\UdemyIdentityServer.Client\Views\Home\AccessDenied.cshtml"
  
    ViewData["Title"] = "AccessDenied";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Erişmeye çalışdığınız sayfaya yetkiniz yoktur.</h1>\n\n<h2>Erişmeye çalıştığınız  sayfa : ");
#nullable restore
#line 7 "C:\Users\ONUR\source\repos\UdemyIdentityServer\UdemyIdentityServer.Client\Views\Home\AccessDenied.cshtml"
                              Write(ViewBag.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
