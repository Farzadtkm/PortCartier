#pragma checksum "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5eab29bf873eff7735f8b5aaa120e85df979a44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_List), @"mvc.1.0.view", @"/Views/Request/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5eab29bf873eff7735f8b5aaa120e85df979a44", @"/Views/Request/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1bf4108d874d46cc09c4c5d79e8956499af24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortCartier.Models.Entities.Request>>
    {
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Requests List</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Document));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Document.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 42 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
                     switch (item.Status)
                    {
                        case PortCartier.Models.Enums.RequestStatus.Waiting:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"btn btn-success\" type=\"button\" data-toggle=\"modal\" data-target=\"#confirm-modal\" data-requestId=\"");
#nullable restore
#line 45 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
                                                                                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">confirm</button>\r\n                            <button class=\"btn btn-danger\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1446, "\"", 1479, 3);
            WriteAttributeValue("", 1456, "RejectRequest(", 1456, 14, true);
#nullable restore
#line 46 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
WriteAttributeValue("", 1470, item.Id, 1470, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1478, ")", 1478, 1, true);
            EndWriteAttribute();
            WriteLiteral(">reject</button>\r\n");
#nullable restore
#line 47 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
                            break;
                        case PortCartier.Models.Enums.RequestStatus.Confirmed:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-success\">confirmed</span>\r\n");
#nullable restore
#line 50 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
                            break;
                        case PortCartier.Models.Enums.RequestStatus.Rejected:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-danger\">rejected</span>\r\n");
#nullable restore
#line 53 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
                            break;
                        default:
                            break;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\ITCITY\source\repos\PortCartier\PortCartier\Views\Request\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""confirm-modal"" tabindex=""-1"" aria-labelledby=""confirm-modal-label"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""confirm-modal-label"">Confirm Request</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5eab29bf873eff7735f8b5aaa120e85df979a449817", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""requestId"" />
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">Recipient:</label>
                        <input type=""date"" class=""form-control"" id=""returned-date"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""ConfirmRequest()"">Save changes</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function ConfirmRequest() {
            var date = $(""#returned-date"").val();

            var requestId = $(""#requestId"").val();

            $.ajax({
                url: ""/request/changerequeststatus"",
                data: { status: true, returnedDate: date, requestId: requestId },
                type: ""POST"",
                success: function () {
                    location.reload();
                }
            })
        }

        function RejectRequest(requestId) {
            
            $.ajax({
                url: ""/request/changerequeststatus"",
                data: { status: false, requestId: requestId },
                type: ""POST"",
                success: function () {
                    location.reload();
                }
            })
        }

        $('#confirm-modal').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var recipient = button.attr('data-requestId');
          ");
                WriteLiteral("  var modal = $(this);\r\n            modal.find(\'#requestId\').val(recipient);\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortCartier.Models.Entities.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
