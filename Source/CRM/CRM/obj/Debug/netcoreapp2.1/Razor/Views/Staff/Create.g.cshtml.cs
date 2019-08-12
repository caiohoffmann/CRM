#pragma checksum "\\Mac\Home\Desktop\Software Engineer\CRM\Source\CRM\CRM\Views\Staff\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8209f3ade95504d397e74de4acf9e62720218a35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Create), @"mvc.1.0.view", @"/Views/Staff/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staff/Create.cshtml", typeof(AspNetCore.Views_Staff_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8209f3ade95504d397e74de4acf9e62720218a35", @"/Views/Staff/Create.cshtml")]
    public class Views_Staff_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRM.Entities.Staff>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "\\Mac\Home\Desktop\Software Engineer\CRM\Source\CRM\CRM\Views\Staff\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Master.cshtml";

#line default
#line hidden
            BeginContext(118, 1803, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Staff</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""nameStaff"" class=""control-label""></label>
                <input asp-for=""nameStaff"" class=""form-control"" />
                <span asp-validation-for=""nameStaff"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""nuPhone"" class=""control-label""></label>
                <input asp-for=""nuPhone"" class=""form-control"" />
                <span asp-validation-for=""nuPhone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""adEmail"" class=""control-label""></label>
                <input asp-for=""adEmail"" class=""form-control"" />
                <span asp-validation-for=""adEmail"" class=""text-danger""></span>");
            WriteLiteral(@"
            </div>
            <div class=""form-group"">
                <label asp-for=""adEmailPersonal"" class=""control-label""></label>
                <input asp-for=""adEmailPersonal"" class=""form-control"" />
                <span asp-validation-for=""adEmailPersonal"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""dtRegistration"" class=""control-label""></label>
                <input asp-for=""dtRegistration"" class=""form-control"" />
                <span asp-validation-for=""dtRegistration"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <div class=""checkbox"">
                    <label>
                        <input asp-for=""isAdmin"" /> ");
            EndContext();
            BeginContext(1922, 43, false);
#line 44 "\\Mac\Home\Desktop\Software Engineer\CRM\Source\CRM\CRM\Views\Staff\Create.cshtml"
                                               Write(Html.DisplayNameFor(model => model.isAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 788, true);
            WriteLiteral(@"
                    </label>
                </div>
            </div>
            <div class=""form-group"">
                <label asp-for=""idStore"" class=""control-label""></label>
                <select asp-for=""idStore"" class =""form-control"" asp-items=""ViewBag.idStore""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""idAddress"" class=""control-label""></label>
                <select asp-for=""idAddress"" class =""form-control"" asp-items=""ViewBag.idAddress""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRM.Entities.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591
