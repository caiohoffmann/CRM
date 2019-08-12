#pragma checksum "\\Mac\Home\Desktop\Software Engineer\CRM\Source\CRM\CRM\Views\Customer\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec76e229717b6313dbaccd506b48876c91629e75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Edit), @"mvc.1.0.view", @"/Views/Customer/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Edit.cshtml", typeof(AspNetCore.Views_Customer_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec76e229717b6313dbaccd506b48876c91629e75", @"/Views/Customer/Edit.cshtml")]
    public class Views_Customer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRM.Entities.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "\\Mac\Home\Desktop\Software Engineer\CRM\Source\CRM\CRM\Views\Customer\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Master.cshtml";

#line default
#line hidden
            BeginContext(119, 1948, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Customer</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""idCustomer"" />
            <div class=""form-group"">
                <label asp-for=""nmCustomer"" class=""control-label""></label>
                <input asp-for=""nmCustomer"" class=""form-control"" />
                <span asp-validation-for=""nmCustomer"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""nuPhone"" class=""control-label""></label>
                <input asp-for=""nuPhone"" class=""form-control"" />
                <span asp-validation-for=""nuPhone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""adEmail"" class=""control-label""></label>
                <input asp-for=""adEmail"" class=""form-control"" />
                <sp");
            WriteLiteral(@"an asp-validation-for=""adEmail"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""nuCustomer"" class=""control-label""></label>
                <input asp-for=""nuCustomer"" class=""form-control"" />
                <span asp-validation-for=""nuCustomer"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""idAddress"" class=""control-label""></label>
                <select asp-for=""idAddress"" class=""form-control"" asp-items=""ViewBag.idAddress""></select>
                <span asp-validation-for=""idAddress"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRM.Entities.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591