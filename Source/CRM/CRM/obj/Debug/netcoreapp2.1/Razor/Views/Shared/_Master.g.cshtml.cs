#pragma checksum "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac291cb69cd5ab240fdb58eff583a378cd7fa1c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CRM.Pages.Shared.Views_Shared__Master), @"mvc.1.0.view", @"/Views/Shared/_Master.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Master.cshtml", typeof(CRM.Pages.Shared.Views_Shared__Master))]
namespace CRM.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac291cb69cd5ab240fdb58eff583a378cd7fa1c6", @"/Views/Shared/_Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc2386f03b626b8abae1218e58c166a57a2f665", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ErrorMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-dark sidebar-expand content-dark navbar-brand-dark right-sidebar-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(98, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(135, 1419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a388a97f32f4a2187eac2742130918e", async() => {
                BeginContext(141, 443, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1,shrink-to-fit=no"">
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/img/favicon.png"">
    <link rel=""stylesheet"" href=""/css/pace.css"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>CRM - ");
                EndContext();
                BeginContext(585, 17, false);
#line 13 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
            Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(602, 945, true);
                WriteLiteral(@"</title>
    <!-- CSS -->
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:200,300,400,500,600%7CRoboto:400"" rel=""stylesheet"" type=""text/css"">
    <link href=""/vendors/material-icons/material-icons.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""/vendors/mono-social-icons/monosocialiconsfont.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""/vendors/feather-icons/feather.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/jquery.perfect-scrollbar/0.7.0/css/perfect-scrollbar.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""/css/style.css"" rel=""stylesheet"" type=""text/css"">
    <!-- Head Libs -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js""></script>
    <script data-pace-options='{ ""ajax"": false, ""selectors"": [ ""img"" ]}' src=""https://cdnjs.cloudflare.com/ajax/libs/pace/1.0.2/pace.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1554, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1558, 9443, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ecd0ad41e54d2bb5fed445acdccb04", async() => {
                BeginContext(1650, 1024, true);
                WriteLiteral(@"
    <div id=""wrapper"" class=""wrapper"">
        <!-- HEADER & TOP NAVIGATION -->
        <nav class=""navbar"">
            <!-- Logo Area -->
            <div class=""navbar-header"">
                <a href=""index.html"" class=""navbar-brand"">
                    <img class=""logo-expand"" alt="""" src=""/img/logo-dark.png"">
                    <img class=""logo-collapse"" alt="""" src=""/img/logo-collapse.png"">
                    <!-- <p>BonVue</p> -->
                </a>
            </div>
            <!-- /.navbar-header -->
            <!-- Left Menu & Sidebar Toggle -->
            <ul class=""nav navbar-nav"">
                <li class=""sidebar-toggle dropdown"">
                    <a href=""javascript:void(0)"" class=""ripple""><i class=""feather feather-menu list-icon fs-20""></i></a>
                </li>
            </ul>
            <!-- /.navbar-left -->
            <div class=""spacer""></div>
            <!-- Right Menu -->
            <ul class=""nav navbar-nav d-none d-lg-flex ml-2 ml-0-rtl"">
");
                EndContext();
#line 49 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
                BeginContext(2747, 67, true);
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        ");
                EndContext();
                BeginContext(2814, 184, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15738c70ce0d42b08af00144a51ad4ec", async() => {
                    BeginContext(2968, 6, true);
                    WriteLiteral("Hello ");
                    EndContext();
                    BeginContext(2975, 18, false);
#line 54 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
                                           Write(User.Identity.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(2993, 1, true);
                    WriteLiteral("!");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2998, 29, true);
                WriteLiteral("\r\n                    </li>\r\n");
                EndContext();
#line 56 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"

                }
                else
                {

#line default
#line hidden
                BeginContext(3089, 67, true);
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        ");
                EndContext();
                BeginContext(3156, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6290349070341e39e987904ce92a21a", async() => {
                    BeginContext(3306, 7, true);
                    WriteLiteral("Sign In");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3317, 29, true);
                WriteLiteral("\r\n                    </li>\r\n");
                EndContext();
#line 65 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
                }

#line default
#line hidden
                BeginContext(3365, 2008, true);
                WriteLiteral(@"
            </ul>
            <!-- /.navbar-right -->
            <!-- User Image with Dropdown -->
            <ul class=""nav navbar-nav"">
                <li class=""dropdown"">
                    <a href=""javascript:void(0);"" class=""dropdown-toggle dropdown-toggle-user ripple"" data-toggle=""dropdown""><span class=""avatar thumb-xs2""><img src=""/demo/users/user1.jpg"" class=""rounded-circle"" alt=""""> <i class=""feather feather-chevron-down list-icon""></i></span></a>
                    <div class=""dropdown-menu dropdown-left dropdown-card dropdown-card-dark dropdown-card-profile animated flipInY"">
                        <div class=""card"">
                            <header class=""card-header d-flex mb-0"">
                                <a href=""javascript:void(0);"" class=""col-md-4 text-center""><i class=""feather feather-user-plus align-middle""></i> </a><a href=""javascript:void(0);"" class=""col-md-4 text-center""><i class=""feather feather-settings align-middle""></i> </a>
                                <a");
                WriteLiteral(@" href=""javascript:void(0);"" class=""col-md-4 text-center"">
                                    <i class=""feather feather-power align-middle""></i>
                                </a>
                            </header>
                            <ul class=""list-unstyled card-body"">
                                <li>
                                    <a href=""page-blank.html#""><span><span class=""align-middle"">Manage Accounts</span></span></a>
                                </li>
                                <li>
                                    <a href=""page-blank.html#""><span><span class=""align-middle"">Change Password</span></span></a>
                                </li>
                                <li>
                                    <a href=""page-blank.html#""><span><span class=""align-middle"">Check Inbox</span></span></a>
                                </li>
                                <li>
                                    ");
                EndContext();
                BeginContext(5373, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e320d297787444083c42bb2d433a3b1", async() => {
                    BeginContext(5423, 55, true);
                    WriteLiteral("<span><span class=\"align-middle\">Sign Out</span></span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5482, 2165, true);
                WriteLiteral(@"
                                </li>
                            </ul>
                            <!-- /.card-body -->
                        </div>
                        <!-- /.card -->
                    </div>
                    <!-- /.dropdown-card-profile -->
                </li>
                <!-- /.dropdown -->
            </ul>
            <!-- /.navbar-nav -->
        </nav>
        <!-- /.navbar -->
        <div class=""content-wrapper"">
            <!-- SIDEBAR -->
            <aside class=""site-sidebar scrollbar-enabled"" data-suppress-scroll-x=""true"">
                <!-- User Details -->
                <div class=""side-user d-none"">
                    <div class=""col-sm-12 text-center p-0 clearfix"">
                        <div class=""d-inline-block pos-relative mr-b-10"">
                            <figure class=""thumb-sm mr-b-0 user--online"">
                                <img src=""/demo/users/user1.jpg"" class=""rounded-circle"" alt="""">
                       ");
                WriteLiteral(@"     </figure><a href=""page-profile.html"" class=""text-muted side-user-link""><i class=""feather feather-settings list-icon""></i></a>
                        </div>
                        <!-- /.d-inline-block -->
                        <div class=""lh-14 mr-t-5"">
                            <a href=""page-profile.html"" class=""hide-menu mt-3 mb-0 side-user-heading fw-500"">Scott Adams</a>
                            <br><small class=""hide-menu"">Developer</small>
                        </div>
                    </div>
                    <!-- /.col-sm-12 -->
                </div>
                <!-- /.side-user -->
                <!-- Call to Action -->
                <div class=""side-content mr-t-30 mr-lr-15"">
                    <a class=""btn btn-block btn-success ripple fw-600"" href=""/Customer/Search""><i class=""fa fa-plus-square-o mr-1 mr-0-rtl ml-1-rtl""></i> New Ticket</a>
                </div>
                <!-- Sidebar Menu -->
                <nav class=""sidebar-nav"">
             ");
                WriteLiteral("       <ul class=\"nav in side-menu\">\r\n                        <li class=\"current-page\">\r\n                            ");
                EndContext();
                BeginContext(7648, 45, false);
#line 134 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
                       Write(Html.ActionLink("Dashboard", "Index", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(7693, 112, true);
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"current-page\">\r\n                            ");
                EndContext();
                BeginContext(7806, 53, false);
#line 137 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
                       Write(Html.ActionLink("Customer List", "Index", "Customer"));

#line default
#line hidden
                EndContext();
                BeginContext(7859, 112, true);
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"current-page\">\r\n                            ");
                EndContext();
                BeginContext(7972, 47, false);
#line 140 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
                       Write(Html.ActionLink("Store List", "Index", "Store"));

#line default
#line hidden
                EndContext();
                BeginContext(8019, 112, true);
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"current-page\">\r\n                            ");
                EndContext();
                BeginContext(8132, 47, false);
#line 143 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
                       Write(Html.ActionLink("Staff List", "Index", "Staff"));

#line default
#line hidden
                EndContext();
                BeginContext(8179, 112, true);
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"current-page\">\r\n                            ");
                EndContext();
                BeginContext(8292, 49, false);
#line 146 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
                       Write(Html.ActionLink("Ticket List", "Index", "Ticket"));

#line default
#line hidden
                EndContext();
                BeginContext(8341, 33, true);
                WriteLiteral("\r\n                        </li>\r\n");
                EndContext();
                BeginContext(9717, 258, true);
                WriteLiteral(@"                    </ul>
                    <!-- /.side-menu -->
                </nav>
                <!-- /.sidebar-nav -->
            </aside>
            <!-- /.site-sidebar -->
            <main class=""main-wrapper clearfix"">
                ");
                EndContext();
                BeginContext(9976, 12, false);
#line 175 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(9988, 227, true);
                WriteLiteral("\r\n            </main>\r\n            <!-- /.main-wrappper -->\r\n        </div>\r\n        <!-- /.content-wrapper -->\r\n        <!-- FOOTER -->\r\n        <footer class=\"footer\">\r\n            <span class=\"heading-font-family\">Copyright ");
                EndContext();
                BeginContext(10216, 706, true);
                WriteLiteral(@"@ 2017. All rights reserved WiseOwl Admin by Unifato</span>
        </footer>
    </div>
    <!--/ #wrapper -->
    <!-- Scripts -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.2/umd/popper.min.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/metisMenu/2.7.0/metisMenu.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.perfect-scrollbar/0.7.0/js/perfect-scrollbar.jquery.js""></script>
    <script src=""/js/theme.js""></script>
    <script src=""/js/custom.js""></script>
    ");
                EndContext();
                BeginContext(10922, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3a9caef2a414b1082e377a0d49c8cf4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(10954, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(10961, 31, false);
#line 195 "C:\Users\ishiva\Desktop\CRM\Source\CRM\CRM\Views\Shared\_Master.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(10992, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11001, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
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
