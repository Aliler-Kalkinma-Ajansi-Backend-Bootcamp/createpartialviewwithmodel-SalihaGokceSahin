#pragma checksum "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20ce00be1505fe66808c59fce590a34cc571825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialView), @"mvc.1.0.view", @"/Views/Shared/_PartialView.cshtml")]
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
#line 1 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\_ViewImports.cshtml"
using PartialViewUsage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\_ViewImports.cshtml"
using PartialViewUsage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20ce00be1505fe66808c59fce590a34cc571825", @"/Views/Shared/_PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07cb38077caa28117a1504368bdc5bb568b3cf1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-hover"">
    <tr>
        <th><label>Name</label></th>
        <th><label>Surname</label></th>
        <th><label>Age</label></th>
        <th><label>Address</label></th>
        <th><label>Phone</label></th>
        <th><label>Status</label></th>

    </tr>
");
#nullable restore
#line 11 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml"
           Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml"
           Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml"
            Write(item.CustomerStatus==true?"Customer active":"Customer Passive");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\gb141\source\repos\PartialViewUsage\PartialViewUsage\Views\Shared\_PartialView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
