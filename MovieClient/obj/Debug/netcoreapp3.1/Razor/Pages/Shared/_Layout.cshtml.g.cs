#pragma checksum "C:\Users\kodokuna\source\repos\MoviePageSolution\MovieClient\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de3a37a490d8863781389305b5348fba295297e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MovieClient.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace MovieClient.Pages.Shared
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
#line 1 "C:\Users\kodokuna\source\repos\MoviePageSolution\MovieClient\Pages\_ViewImports.cshtml"
using MovieClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de3a37a490d8863781389305b5348fba295297e", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abefc77ffe77b06364f5661a665adb43e13240f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/grid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4de3a37a490d8863781389305b5348fba295297e4338", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>
        Flix
    </title>
    <!-- GOOGLE FONTS -->
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Cairo:wght@200;300;400;600;700;900&display=swap"" rel=""stylesheet"">
    <!-- OWL CAROUSEL -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.min.css"" integrity=""sha512-tS3S5qG0BlhnQROyJXvNjeEM4UpMXHrQfTGmbQ1gKmelCxlSEBUaxhRBj/EFTzpbP4RVSrpEikbmdJobCvhE3g=="" crossorigin=""anonymous"" />
    <!-- BOX ICONS -->
    <link href='https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css' rel='stylesheet'>
    <!-- APP CSS -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4de3a37a490d8863781389305b5348fba295297e5462", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4de3a37a490d8863781389305b5348fba295297e6641", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <meta name=""google-signin-scope"" content=""profile email"">
    <meta name=""google-signin-client_id"" content=""955843831367-86b893sur6in71b686r63l4f6pv3dohb.apps.googleusercontent.com"">
    <script src=""https://apis.google.com/js/platform.js"" async defer></script>
    <style>
        #changecolor:hover {
            color: red;
        }
    </style>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4de3a37a490d8863781389305b5348fba295297e8899", async() => {
                WriteLiteral("\r\n\r\n    <!-- NAV -->\r\n    <div class=\"nav-wrapper\">\r\n        <div class=\"container\">\r\n            <div class=\"nav\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1497, "\"", 1504, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""logo"">
                    <i class='bx bx-movie-play bx-tada main-color'></i>Fl<span class=""main-color"">i</span>x
                </a>
                <!-- MOBILE MENU TOGGLE -->
                <div class=""hamburger-menu"" id=""hamburger-menu"">
                    <div class=""hamburger""></div>
                </div>
            </div>
        </div>
    </div>
    <!-- END NAV -->
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 50 "C:\Users\kodokuna\source\repos\MoviePageSolution\MovieClient\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <!-- FOOTER SECTION -->
    <footer class=""section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-4 col-md-6 col-sm-12"">
                    <div class=""content"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 2284, "\"", 2291, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""logo"">
                            <i class='bx bx-movie-play bx-tada main-color'></i>Fl<span class=""main-color"">i</span>x
                        </a>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aut veniam ex quos hic id nobis beatae earum sapiente! Quod ipsa exercitationem officiis non error illum minima iusto et. Dolores, quibusdam?
                        </p>
                        <div class=""social-list"">
                            <a href=""#"" class=""social-item"">
                                <i class=""bx bxl-facebook""></i>
                            </a>
                            <a href=""#"" class=""social-item"">
                                <i class=""bx bxl-twitter""></i>
                            </a>
                            <a href=""#"" class=""social-item"">
                                <i class=""bx bxl-instagram""></i>
                            </a>
                        </div>
       ");
                WriteLiteral(@"             </div>
                </div>
                <div class=""col-8 col-md-6 col-sm-12"">
                    <div class=""row"">
                        <div class=""col-3 col-md-6 col-sm-6"">
                            <div class=""content"">
                                <p><b>Flix</b></p>
                                <ul class=""footer-menu"">
                                    <li><a href=""#"">About us</a></li>
                                    <li><a href=""#"">My profile</a></li>
                                    <li><a href=""#"">Pricing plans</a></li>
                                    <li><a href=""#"">Contacts</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-3 col-md-6 col-sm-6"">
                            <div class=""content"">
                                <p><b>Browse</b></p>
                                <ul class=""footer-menu"">
                                    ");
                WriteLiteral(@"<li><a href=""#"">About us</a></li>
                                    <li><a href=""#"">My profile</a></li>
                                    <li><a href=""#"">Pricing plans</a></li>
                                    <li><a href=""#"">Contacts</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-3 col-md-6 col-sm-6"">
                            <div class=""content"">
                                <p><b>Help</b></p>
                                <ul class=""footer-menu"">
                                    <li><a href=""#"">About us</a></li>
                                    <li><a href=""#"">My profile</a></li>
                                    <li><a href=""#"">Pricing plans</a></li>
                                    <li><a href=""#"">Contacts</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-");
                WriteLiteral(@"3 col-md-6 col-sm-6"">
                            <div class=""content"">
                                <p><b>Download app</b></p>
                                <ul class=""footer-menu"">
                                    <li>
                                        <a href=""#"">
                                            <img src=""./images/google-play.png""");
                BeginWriteAttribute("alt", " alt=\"", 5731, "\"", 5737, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <img src=""./images/app-store.png""");
                BeginWriteAttribute("alt", " alt=\"", 6003, "\"", 6009, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- END FOOTER SECTION -->
    <!-- COPYRIGHT SECTION -->
    <div class=""copyright"">
        Copyright 2021 <a href=""https://www.facebook.com/kodokunaxx/"" target=""_blank"">
            Đỗ Mạnh Hà
        </a>
    </div>
    <!-- END COPYRIGHT SECTION -->
    <!-- SCRIPT -->
    <!-- JQUERY -->
    <!-- APP SCRIPT -->
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
    ");
#nullable restore
#line 148 "C:\Users\kodokuna\source\repos\MoviePageSolution\MovieClient\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Styles", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 149 "C:\Users\kodokuna\source\repos\MoviePageSolution\MovieClient\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
