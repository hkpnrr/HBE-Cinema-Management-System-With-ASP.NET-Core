#pragma checksum "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6d04f753ae08c36a3d4e34c5c26b6beb157d74b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainPage_MoviePage), @"mvc.1.0.view", @"/Views/MainPage/MoviePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d04f753ae08c36a3d4e34c5c26b6beb157d74b", @"/Views/MainPage/MoviePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b2ab5b483ddc53d150517cfefb6c5dcf999151", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_MoviePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
  
    string movieName = Model.movieName;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6d04f753ae08c36a3d4e34c5c26b6beb157d74b3612", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Movie Page</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6d04f753ae08c36a3d4e34c5c26b6beb157d74b5119", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 24 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n    <!-- PARTIAL VIEW ILE YAPARSAK -->\r\n    <!--<partial name=\"_navbar\" /> -->\r\n\r\n\r\n    <!-- AFİŞ VE FRAGMAN -->\r\n    <!-- ROW 2 COLUMN\'A BÖLÜNÜYOR -->\r\n    <h2 class=\"fw-bold text-capitalize text-center bg-white mt-5\">");
#nullable restore
#line 32 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                                             Write(movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
    <div class=""row mt-5"" style=""background-image: url(sinemaSalonuÖn.jpg);"">

        <!-- FOTO BÖLÜMÜ -->
        <div class=""col-md-5 col-lg-4 col-xl-3 mx-auto my-4 text-center "">
            <img class=""ms-5 border border-5 rounded"" src=""SpiderManNoWayHome_Poster_Main_y.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 1216, "\"", 1222, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        </div>

        <!-- FRAGMAN BÖLÜMÜ -->
        <!-- RESPONSIVE YAPAMADIM FRAGMANI,çok az bi OVERFLOW OLUYO EKRANI KÜÇÜLTÜNCE -->
        <div class=""col-md-7 col-lg-8 col-xl-9 mx-auto my-auto text-center "">
            <iframe class=""border border-5 rounded"" width=""560"" height=""315""
                    src=""https://www.youtube.com/embed/JfVOs4VSpmA"" title=""YouTube video player"" frameborder=""0""
                    allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture""
                    allowfullscreen></iframe>
        </div>
    </div>
    <!-- ROW 2 COLUMN'A BÖLÜNÜYOR -->
    <!-- AFİŞ VE FRAGMAN -->
    <!-- FİLM INFO -->
    <section class=""filmInfo mt-5"">
        <div class=""container"">
            <h2 class=""text-center"">");
#nullable restore
#line 54 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                               Write(Model.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
            <p> <strong>Yönetmen: </strong> Jon Watts</p>
            <p>
                <strong>Oyuncular: </strong> Willem Dafoe, Tom Holland, Zendaya, Benedict Cumberbatch, Marisa Tomei
            </p>
            <div class=""row"">
                <div class=""col-3"">
                    <div><strong>Vizyon Tarihi:</strong> ");
#nullable restore
#line 61 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                                    Write(Model.movieReleaseDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <div><strong>Süre:</strong> ");
#nullable restore
#line 62 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                           Write(Model.movieDuration);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Dakika</div>\r\n                    <div><strong>Tür:</strong> Aksiyon</div>\r\n\r\n\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    <div>\r\n                        <strong>Özet: </strong>");
#nullable restore
#line 69 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                          Write(Model.movieSummary);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>

    <br><br>
    <hr style=""border: 3px solid black;"">
    <br><br>

    <!-- FİLM VİZYONDAYSA BİLET AL -->
    <!--
        <a asp-controller=""Home""  asp-action=""Register"">
                        <button style=""background-color: orange;"">Sign Up</button>

                    </a>
    -->
    <!-- BUY TICKET -->
");
#nullable restore
#line 88 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
     if (Model.isShowing)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <h2 class=\"text-center\">Watch Now!</h2>\r\n            <div class=\"btn-lg col-md-12 text-center\">\r\n                <button class=\"btn-lg btn-dark mb-4\">Buy Ticket</button>\r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("        <br>\r\n        <hr style=\"border: 3px solid black;\">\r\n        <br>\r\n");
#nullable restore
#line 100 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <h2 class=\"text-center pb-3\">📆 Not In Show - You can\'t buy a ticket ❌</h2>\r\n        </div>\r\n");
                WriteLiteral("        <br>\r\n        <hr style=\"border: 3px solid black;\">\r\n        <br>\r\n");
#nullable restore
#line 110 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- YORUMLAR (yorum yapması için giriş yapması gereksin mi?) -->
    <!--YORUM YAP -->
    <div id=""makeComment"" class=""container"">
        <h2>Add a comment</h2>
        <div class=""mb-3"">
            <label for=""makeComment"" class=""form-label"">Your comment:</label>
            <textarea style=""resize: none; height: 200px;"" class=""form-control"" id=""makeComment"" rows=""3""
                      placeholder=""Your comment..."" maxlength=""500""></textarea>
        </div>
        <div class=""container"">
            <div class=""text-end"">
                <button class=""btn-lg btn-danger mb-4"">Spoiler</button>
                <button class=""btn-lg btn-dark mb-4"">Post</button>
            </div>
        </div>
    </div>

    <br>

    <!-- YORUM OKU -->
    <div id=""readComment"" class=""container"">
        <h2 class=""mb-4"">Other comments</h2>
        <div class=""row"">
            <!-- Kullanıcı bilgisi -->
            <div class=""col-3 text-center"">
                <i class=""fas fa-user");
                WriteLiteral(@"-circle fa-5x""></i>
                <p class=""mt-3""><strong>Ekin Uzunbaz</strong></p>
            </div>
            <!-- Yorum içeriği -->
            <div class=""col-9"">
                <p>
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima perspiciatis aspernatur fugiat hic
                    nesciunt quos, optio numquam! Quae reiciendis voluptatum labore itaque exercitationem atque ipsum,
                    dolore nisi, fugiat nihil debitis doloribus amet, ab culpa voluptatibus animi minus? Pariatur
                    accusantium placeat, enim aliquid dolore laboriosam ex numquam assumenda libero architecto unde
                    expedita animi voluptates quos cum praesentium asperiores itaque cumque. Veniam nesciunt eveniet
                    dolorum veritatis earum dolores eligendi et quis odio aut perspiciatis aliquid consequatur esse odit
                    assumenda, velit quidem explicabo expedita! Reprehenderit assumenda ea, excepturi voluptas qu");
                WriteLiteral(@"ibusdam
                    itaque praesentium nostrum necessitatibus nisi architecto neque porro eos, voluptatibus suscipit
                    explicabo autem.
                </p>
            </div>
        </div>
        <br>
        <hr style=""border: 1px solid black;"">
        <br>

        <div class=""row"">
            <!-- Kullanıcı bilgisi -->
            <div class=""col-3 text-center"">
                <i class=""fas fa-user-circle fa-5x""></i>
                <p class=""mt-3""><strong>Ekin Uzunbaz</strong></p>
            </div>
            <!-- Yorum içeriği -->
            <div class=""col-9"">
                <p>
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima perspiciatis aspernatur fugiat hic
                    nesciunt quos, optio numquam! Quae reiciendis voluptatum labore itaque exercitationem atque ipsum,
                    dolore nisi, fugiat nihil debitis doloribus amet, ab culpa voluptatibus animi minus? Pariatur
                    a");
                WriteLiteral(@"ccusantium placeat, enim aliquid dolore laboriosam ex numquam assumenda libero architecto unde
                    expedita animi voluptates quos cum praesentium asperiores itaque cumque. Veniam nesciunt eveniet
                    dolorum veritatis earum dolores eligendi et quis odio aut perspiciatis aliquid consequatur esse odit
                    assumenda, velit quidem explicabo expedita! Reprehenderit assumenda ea, excepturi voluptas quibusdam
                    itaque praesentium nostrum necessitatibus nisi architecto neque porro eos, voluptatibus suscipit
                    explicabo autem.
                </p>
            </div>
        </div>
    </div>

    <br><br>
    <hr style=""border: 3px solid black;"">
    <br><br>

    <!-- BENZER FİLMLER (sorguda LIKE dicez falan) -->

    <section class=""benzerFilmler container"">
        <h2>May you interested in...</h2>
        <div id=""slider-benzerFilmler"" class=""carousel slide carousel-fade my-3"" data-bs-ride=""carousel"">
          ");
                WriteLiteral(@"  <div class=""carousel-indicators"">
                <button type=""button"" data-bs-target=""#slider-benzerFilmler"" data-bs-slide-to=""0"" class=""active""
                        aria-current=""true"" aria-label=""Slide 1""></button>
                <button type=""button"" data-bs-target=""#slider-benzerFilmler"" data-bs-slide-to=""1""
                        aria-label=""Slide 2""></button>
                <button type=""button"" data-bs-target=""#slider-benzerFilmler"" data-bs-slide-to=""2""
                        aria-label=""Slide 3""></button>
            </div>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <!-- Afişine tıklayınca film'in sayfasına gitsin burda-->
                    <!-- YAZSINI ALTA ALAMADIM -->
                    <a href=""promo1.png""><img class=""d-block w-100 img-fluid"" src=""promo1.png""");
                BeginWriteAttribute("alt", " alt=\"", 8740, "\"", 8746, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    <div class=""carousel-caption carousel-caption2 d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100 img-fluid"" src=""promo2.png""");
                BeginWriteAttribute("alt", " alt=\"", 9428, "\"", 9434, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100 img-fluid"" src=""promo3.png""");
                BeginWriteAttribute("alt", " alt=\"", 9837, "\"", 9843, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#slider-benzerFilmler""
                    data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#slider-benzerFilmler""
                    data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>

    </section>

    <br><br>
    <hr style=""border: 3px solid black");
                WriteLiteral(";\">\r\n    <br>\r\n\r\n    ");
#nullable restore
#line 247 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"\r\n            integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\"\r\n            crossorigin=\"anonymous\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591