#pragma checksum "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/SingleUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f69451fe23444cf7d66c9d7f9852db906622811"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingleUser), @"mvc.1.0.view", @"/Views/Home/SingleUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SingleUser.cshtml", typeof(AspNetCore.Views_Home_SingleUser))]
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
#line 1 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/_ViewImports.cshtml"
using ViewModel_Fun;

#line default
#line hidden
#line 2 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/_ViewImports.cshtml"
using ViewModel_Fun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f69451fe23444cf7d66c9d7f9852db906622811", @"/Views/Home/SingleUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d67dacb5d440fdfd5c9974c666c8e8de3a51591", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingleUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel_Fun.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/SingleUser.cshtml"
  
    ViewData["Title"] = "SingleUser";

#line default
#line hidden
            BeginContext(76, 92, true);
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Here is a User!</h1>\n    <h1 class=mt-5>");
            EndContext();
            BeginContext(169, 15, false);
#line 7 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/SingleUser.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(184, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(186, 14, false);
#line 7 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/SingleUser.cshtml"
                               Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(200, 12, true);
            WriteLiteral("</h1>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel_Fun.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
