#pragma checksum "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ba620ff17436cd1c5b517819ede1e106a20e1f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CRM.Pages.TicketHistory.Views_TicketHistory__List), @"mvc.1.0.view", @"/Views/TicketHistory/_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TicketHistory/_List.cshtml", typeof(CRM.Pages.TicketHistory.Views_TicketHistory__List))]
namespace CRM.Pages.TicketHistory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\_ViewImports.cshtml"
using CRM.Areas.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ba620ff17436cd1c5b517819ede1e106a20e1f4", @"/Views/TicketHistory/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc2386f03b626b8abae1218e58c166a57a2f665", @"/Views/_ViewImports.cshtml")]
    public class Views_TicketHistory__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CRM.Entities.TicketHistory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(135, 51, false);
#line 7 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayNameFor(model => model.idTicketHistory));

#line default
#line hidden
            EndContext();
            BeginContext(186, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(242, 44, false);
#line 10 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayNameFor(model => model.idTicket));

#line default
#line hidden
            EndContext();
            BeginContext(286, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(342, 51, false);
#line 13 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayNameFor(model => model.idStaffAssigned));

#line default
#line hidden
            EndContext();
            BeginContext(393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(449, 50, false);
#line 16 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayNameFor(model => model.idTicketStatus));

#line default
#line hidden
            EndContext();
            BeginContext(499, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(555, 50, false);
#line 19 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayNameFor(model => model.idStaffAssigns));

#line default
#line hidden
            EndContext();
            BeginContext(605, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(661, 46, false);
#line 22 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayNameFor(model => model.dtAssigned));

#line default
#line hidden
            EndContext();
            BeginContext(707, 77, true);
            WriteLiteral("\r\n            </th>\r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(816, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(865, 50, false);
#line 31 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayFor(modelItem => item.idTicketHistory));

#line default
#line hidden
            EndContext();
            BeginContext(915, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(971, 43, false);
#line 34 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayFor(modelItem => item.idTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1070, 50, false);
#line 37 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayFor(modelItem => item.idStaffAssigned));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1176, 49, false);
#line 40 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayFor(modelItem => item.idTicketStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1281, 49, false);
#line 43 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayFor(modelItem => item.idStaffAssigns));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1386, 45, false);
#line 46 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
           Write(Html.DisplayFor(modelItem => item.dtAssigned));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\TicketHistory\_List.cshtml"
}

#line default
#line hidden
            BeginContext(1470, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CRM.Entities.TicketHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
