#pragma checksum "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Thankscshtml.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aadb9f2bedef6a595a2debce5b187d9890cd401e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thankscshtml), @"mvc.1.0.view", @"/Views/Home/Thankscshtml.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aadb9f2bedef6a595a2debce5b187d9890cd401e", @"/Views/Home/Thankscshtml.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thankscshtml : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASNMT_3_EAD.Models.UserData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<img");
            BeginWriteAttribute("src", " src=", 45, "", 69, 1);
#nullable restore
#line 4 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Thankscshtml.cshtml"
WriteAttributeValue("", 50, Model.ImageAddress, 50, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\nUser Name: ");
#nullable restore
#line 5 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Thankscshtml.cshtml"
      Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nEmail: ");
#nullable restore
#line 6 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Thankscshtml.cshtml"
  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nPassword: ");
#nullable restore
#line 7 "C:\Users\Muhammad Naveed\source\repos\ASNMT_3_EAD\ASNMT_3_EAD\Views\Home\Thankscshtml.cshtml"
     Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
