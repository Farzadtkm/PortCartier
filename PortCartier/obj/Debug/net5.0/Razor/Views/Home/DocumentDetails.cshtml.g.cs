#pragma checksum "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Home\DocumentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f7430143aae93640f91cde7b13b31d436c37699"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DocumentDetails), @"mvc.1.0.view", @"/Views/Home/DocumentDetails.cshtml")]
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
#line 1 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\_ViewImports.cshtml"
using PortCartier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\_ViewImports.cshtml"
using PortCartier.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\_ViewImports.cshtml"
using PortCartier.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7430143aae93640f91cde7b13b31d436c37699", @"/Views/Home/DocumentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1bf4108d874d46cc09c4c5d79e8956499af24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DocumentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Document>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Home\DocumentDetails.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n   <h1>");
#nullable restore
#line 8 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Home\DocumentDetails.cshtml"
  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-5 col-12\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 187, "\"", 205, 1);
#nullable restore
#line 13 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Home\DocumentDetails.cshtml"
WriteAttributeValue("", 193, Model.Image, 193, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 206, "\"", 224, 1);
#nullable restore
#line 13 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Home\DocumentDetails.cshtml"
WriteAttributeValue("", 212, Model.Title, 212, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\" />\r\n    </div>\r\n    <div class=\"col-md-7 col-12\">\r\n        <div class=\"text\">\r\n            ");
#nullable restore
#line 17 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Home\DocumentDetails.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mt-4\">\r\n            <button type=\"button\" class=\"btn btn-primary\">Request Document</button>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Document> Html { get; private set; }
    }
}
#pragma warning restore 1591