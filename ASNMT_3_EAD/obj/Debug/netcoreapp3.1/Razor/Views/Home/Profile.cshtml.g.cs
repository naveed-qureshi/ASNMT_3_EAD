#pragma checksum "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc66c2b2a25f019002a02dd5b3ffcb863bd68f0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc66c2b2a25f019002a02dd5b3ffcb863bd68f0f", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASNMT_3_EAD.Models.UserData>
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
#nullable restore
#line 1 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Profile.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"width:50%;margin:2% auto\">\r\n   <div class=\"row mb-5\">\r\n       <div class=\"col-sm-2 mr-5\">\r\n           <img");
            BeginWriteAttribute("src", " src=\"", 208, "\"", 233, 1);
#nullable restore
#line 8 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Profile.cshtml"
WriteAttributeValue("", 214, Model.ImageAddress, 214, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" height=\"100px\" style=\"border-radius:50%\" />\r\n       </div>\r\n       <div>\r\n           <h3>");
#nullable restore
#line 11 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Profile.cshtml"
          Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n       </div>\r\n   </div>\r\n   <div>\r\n       <h6>Profile</h6>\r\n   </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc66c2b2a25f019002a02dd5b3ffcb863bd68f0f4045", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleInputEmail1\">Username*</label>\r\n            <input class=\"form-control\" type=\"text\" placeholder=\"username...\"");
                BeginWriteAttribute("value", " value=\"", 618, "\"", 641, 1);
#nullable restore
#line 20 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Profile.cshtml"
WriteAttributeValue("", 626, Model.UserName, 626, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <small id=\"emailHelp\" class=\"form-text text-muted\">Require 150 characters of fewer. Letters,digits and ");
                WriteLiteral(@"@,/,+,-,. only </small>
        </div>
        <div class=""form-group"">
            <label for=""exampleInputEmail1"">Email*</label>
            <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Enter email""");
                BeginWriteAttribute("value", " value=\"", 1027, "\"", 1047, 1);
#nullable restore
#line 25 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Profile.cshtml"
WriteAttributeValue("", 1035, Model.Email, 1035, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <label for=\"exampleInputEmail1\">Image*</label><br />\r\n        <label for=\"exampleInputEmail1\">Currently: <span style=\"color:blue\">");
#nullable restore
#line 28 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Profile.cshtml"
                                                                       Write(Model.ImageAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></label>
        <div class=""form-group"">
            <label for=""exampleFormControlFile1"">Change:</label>
            <input type=""file"" class=""form-control-file"" id=""exampleFormControlFile1"">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputPassword1"">Old Password*</label>
            <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputPassword1"">New Password*</label>
            <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
        </div>
        <button type=""submit"" class=""btn btn-outline-info"">Update</button>
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASNMT_3_EAD.Models.UserData> Html { get; private set; }
    }
}
#pragma warning restore 1591
