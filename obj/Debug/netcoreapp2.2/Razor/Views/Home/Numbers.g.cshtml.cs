#pragma checksum "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/Numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc2bf9afd469a23591e64de90408c12b5f380f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Numbers), @"mvc.1.0.view", @"/Views/Home/Numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Numbers.cshtml", typeof(AspNetCore.Views_Home_Numbers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc2bf9afd469a23591e64de90408c12b5f380f6", @"/Views/Home/Numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d67dacb5d440fdfd5c9974c666c8e8de3a51591", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/Numbers.cshtml"
  
    ViewData["Title"] = "Numbers";

#line default
#line hidden
            BeginContext(53, 80, true);
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Here are some numbers!</h1>\n");
            EndContext();
#line 7 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/Numbers.cshtml"
     foreach(var numbers in Model){

#line default
#line hidden
            BeginContext(169, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(181, 7, false);
#line 8 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/Numbers.cshtml"
      Write(numbers);

#line default
#line hidden
            EndContext();
            BeginContext(188, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 9 "/Users/Andrew/CodingDojo/c#/ViewModel_Fun/Views/Home/Numbers.cshtml"
    }

#line default
#line hidden
            BeginContext(199, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591