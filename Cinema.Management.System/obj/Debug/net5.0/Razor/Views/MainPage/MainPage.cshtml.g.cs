#pragma checksum "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a1c95e81c2f3dc1943dfa2662599e1a729da46b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainPage_MainPage), @"mvc.1.0.view", @"/Views/MainPage/MainPage.cshtml")]
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
#line 1 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a1c95e81c2f3dc1943dfa2662599e1a729da46b", @"/Views/MainPage/MainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b2ab5b483ddc53d150517cfefb6c5dcf999151", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("me-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a1c95e81c2f3dc1943dfa2662599e1a729da46b3976", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Main Page</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"">

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a1c95e81c2f3dc1943dfa2662599e1a729da46b5482", async() => {
                WriteLiteral("\r\n    <!-- NAVBAR -->\r\n    <nav class=\"navbar bg-light navbar-light navbar-expand-sm \">\r\n\r\n        <a href=\"#\" class=\"navbar-brand ps-5\"><img src=\"HBE.png\" style=\"max-width: 165px;\"");
                BeginWriteAttribute("alt", " alt=\"", 760, "\"", 766, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>

        <!-- pencere küçülünce collapsible (TOGGLE'DA SIKINTI VAR AW)-->
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#collapsibleNavbar"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <!-- collapsible -->
        <div class=""collapse navbar-collapse"" id=""collapsibleNavbar"">

            <ul class=""navbar-nav me-auto"">
                <!-- filmleri listelicek ayrı bir sayfada -->
                <li class=""nav-item ps-5"">
                    <a href=""#"" class=""nav-link"">Filmler</a>
                </li>
                <!-- sinema salonlarını listelicek ayrı bir sayfada -->
                <li class=""nav-item ps-5"">
                    <a href=""#"" class=""nav-link"">Sinema Salonları</a>
                </li>

            </ul>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a1c95e81c2f3dc1943dfa2662599e1a729da46b6966", async() => {
                    WriteLiteral("\r\n                <input class=\"form-control\" type=\"text\" placeholder=\"Search Movie\" title=\"Search Now!\">\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

            <nav class=""navbar-nav me-5"">
                <!-- profile'e gitcek -->
                <a href=""#"" class=""nav-link me-5"">Profile</a>
                <a href=""#"" class=""nav-link me-5"">Sign Out</a>

            </nav>
        </div>
    </nav>
    <!-- NAVBAR -->

    <section class=""promo"">
        <div id=""slider-promo"" class=""carousel slide carousel-fade my-3"" data-bs-ride=""carousel"">
            <div class=""carousel-indicators"">
                <button type=""button"" data-bs-target=""#slider-promo"" data-bs-slide-to=""0"" class=""active""
                        aria-current=""true"" aria-label=""Slide 1""></button>
                <button type=""button"" data-bs-target=""#slider-promo"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
                <button type=""button"" data-bs-target=""#slider-promo"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
            </div>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                   ");
                WriteLiteral(" <img class=\"d-block w-100 img-fluid\" src=\"promo1.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2844, "\"", 2850, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100 img-fluid"" src=""promo2.png""");
                BeginWriteAttribute("alt", " alt=\"", 3253, "\"", 3259, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100 img-fluid"" src=""promo3.png""");
                BeginWriteAttribute("alt", " alt=\"", 3662, "\"", 3668, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#slider-promo"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#slider-promo"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>

    </section>

    <br>
    <hr style=""border-top: 5px solid red;"">
    <br>


    <div class=""container"" style=""backgro");
                WriteLiteral(@"und-image: url(sinemaSalonuÖn.jpg);"">
        <div style=""color: white;"">
            <a href=""#"" class=""navbar-brand "">HBE CINEMA HALL</a>
            <p>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Qui soluta maiores exercitationem omnis.
                Commodi
                totam dolor doloribus rerum nam autem eius voluptatum natus id molestiae culpa aliquid, dolorum
                consequuntur
                rem, odit sapiente vitae fugiat nihil ipsam iste distinctio iusto eligendi repellat. Nobis nemo corrupti
                facere quod necessitatibus, assumenda impedit laborum!
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Qui soluta maiores exercitationem omnis.
                Commodi
                totam dolor doloribus rerum nam autem eius voluptatum natus id molestiae culpa aliquid, dolorum
                consequuntur
                rem, odit sapiente vitae fugiat nihil ipsam iste distinctio iusto eligendi repellat. Nob");
                WriteLiteral(@"is nemo corrupti
                facere quod necessitatibus, assumenda impedit laborum!
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Qui soluta maiores exercitationem omnis.
                Commodi
                totam dolor doloribus rerum nam autem eius voluptatum natus id molestiae culpa aliquid, dolorum
                consequuntur
                rem, odit sapiente vitae fugiat nihil ipsam iste distinctio iusto eligendi repellat. Nobis nemo corrupti
                facere quod necessitatibus, assumenda impedit laborum!
            </p>
        </div>

    </div>

    <br>
    <hr style=""border-top: 5px solid red;"">
    <br>

    <section class=""vizyonda"">
        <div class=""container"">
            <div class=""row"">
                <h2>Vizyonda</h2>
            </div>
        </div>


        <div id=""slider-vizyonda"" class=""carousel slide carousel-fade my-3"" data-bs-ride=""carousel"">
            <div class=""carousel-indicators"">
                <but");
                WriteLiteral(@"ton type=""button"" data-bs-target=""#slider-vizyonda"" data-bs-slide-to=""0"" class=""active""
                        aria-current=""true"" aria-label=""Slide 1""></button>
                <button type=""button"" data-bs-target=""#slider-vizyonda"" data-bs-slide-to=""1""
                        aria-label=""Slide 2""></button>
                <button type=""button"" data-bs-target=""#slider-vizyonda"" data-bs-slide-to=""2""
                        aria-label=""Slide 3""></button>
            </div>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <!-- Afişine tıklayınca film'in sayfasına gitsin burda-->
                    <!-- YAZSINI ALTA ALAMADIM -->
                    <a href=""promo1.png""><img class=""d-block w-100 img-fluid"" src=""promo1.png""");
                BeginWriteAttribute("alt", " alt=\"", 7545, "\"", 7551, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    <div class=""carousel-caption carousel-caption2 d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <a href=""promo2.png""><img class=""d-block w-100 img-fluid"" src=""promo2.png""");
                BeginWriteAttribute("alt", " alt=\"", 7997, "\"", 8003, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    <div class=""carousel-caption carousel-caption2 d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <a href=""promo3.png""><img class=""d-block w-100 img-fluid"" src=""promo3.png""");
                BeginWriteAttribute("alt", " alt=\"", 8449, "\"", 8455, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    <div class=""carousel-caption carousel-caption2 d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#slider-promo"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#slider-promo"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>

    </section>

    <!-- FOOTER -->
    <footer class=""text-center text-lg-start bg-light text-muted"">");
                WriteLiteral(@"

        <section>
            <p class=""text-center mt-5""><strong>WHO ARE WE</strong></p>
        </section>

        <!-- BİLGİLER -->
        <section>
            <div class=""container text-center text-md-start mt-5"">
                <!-- ROW 3 COLUMN'A BÖLÜNÜYOR -->
                <div class=""row mt-3"">
                    <!-- NAME BÖLÜMÜ -->
                    <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            <i class=""fas fa-user-circle me-3""></i>Name
                        </h6>
                        <p class=""mb-3"">
                            Halil Akpınar

                        </p>
                        <p class=""mb-3"">
                            Ekin Uzunbaz

                        </p>
                        <p class=""mb-3"">
                            Burak Konuk

                        </p>
                    </div>

                    <!-- LINKEDIN BÖL");
                WriteLiteral(@"ÜMÜ -->
                    <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mb-4"">
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Linkedin
                        </h6>
                        <p>
                            <a href=""https://www.linkedin.com/in/ekin-uzunbaz-626042180/"" class=""text-reset"">
                                <i class=""fab fa-linkedin fa-lg ps-4""></i>
                            </a>
                        </p>
                        <p>
                            <a href=""https://www.linkedin.com/in/ekin-uzunbaz-626042180/"" class=""text-reset"">
                                <i class=""fab fa-linkedin fa-lg ps-4""></i>
                            </a>
                        </p>
                        <p>
                            <a href=""https://www.linkedin.com/in/ekin-uzunbaz-626042180/"" class=""text-reset"">
                                <i class=""fab fa-linkedin fa-lg ps-4""></i>
                            <");
                WriteLiteral(@"/a>
                        </p>
                    </div>

                    <!-- CONTACT BÖLÜMÜ -->
                    <div class=""col-md-7 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Contact
                        </h6>
                        <p>
                            <i class=""fas fa-envelope me-2""></i><i class=""fas fa-phone me-2""></i>
                            ekinuzunbaz@gmail.com, +90 (507) 095 7974
                        </p>
                        <p>
                            <i class=""fas fa-envelope me-2""></i><i class=""fas fa-phone me-2""></i>
                            ekinuzunbaz@gmail.com, +90 (507) 095 7974
                        </p>
                        <p>
                            <i class=""fas fa-envelope me-2""></i><i class=""fas fa-phone me-2""></i>
                            ekinuzunbaz@gmail.com, +90 (507) 095 7974
                        </p>
          ");
                WriteLiteral(@"          </div>
                </div>
                <!-- ROW 3 COLUMN'A BÖLÜNÜYOR -->
            </div>
        </section>

        <!-- COPYRIGHT -->
        <div class=""text-center p-4"" style=""background-color: rgba(0, 0, 0, 0.05);"">
            © 2021 Copyright HBE CINEMA HALL
        </div>
    </footer>


    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p""
            crossorigin=""anonymous""></script>
");
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
