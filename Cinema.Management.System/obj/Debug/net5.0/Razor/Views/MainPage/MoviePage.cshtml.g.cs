#pragma checksum "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d6be54d902895e627cb253879456cf18801e1f9"
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
#nullable restore
#line 3 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d6be54d902895e627cb253879456cf18801e1f9", @"/Views/MainPage/MoviePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fd429d129da1b7030d35220f8e50d42701dc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_MoviePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema.Management.System.ViewModels.MovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/MainPage/AddToWatchList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-lg btn-dark mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TicketPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChooseSession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("makeComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d6be54d902895e627cb253879456cf18801e1f96378", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Movie Page</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"">
    <style>
        #background {
            background-image: url(https://www.arttablo.com/upload/U-sinema-salonu-fotograf-kanvas-tablo1461331435-800.jpg);
            background-attachment: fixed;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d6be54d902895e627cb253879456cf18801e1f98234", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 29 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- PARTIAL VIEW ILE YAPARSAK -->\r\n    <!--<partial name=\"_navbar\" /> -->\r\n\r\n    <h2 class=\"fw-bold text-capitalize text-center bg-white mt-5\"><strong>");
#nullable restore
#line 34 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                                                     Write(Model.movie.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></h2>
    <!-- AFİŞ VE FRAGMAN -->
    <!-- ROW 2 COLUMN'A BÖLÜNÜYOR -->
    <div class=""row mt-5"" id=""background"">

        <!-- FOTO BÖLÜMÜ -->
        <div class=""col-md-5 col-lg-4 col-xl-3 mx-auto my-4 text-center "">
            <img class=""ms-5 border border-5 rounded img-fluid""");
                BeginWriteAttribute("src", " src=", 1515, "", 1546, 1);
#nullable restore
#line 41 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
WriteAttributeValue("", 1520, Model.movie.moviePhotoUrl, 1520, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1546, "\"", 1552, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"255px\">\r\n        </div>\r\n\r\n        <!-- FRAGMAN BÖLÜMÜ -->\r\n        <div class=\"col-md-7 col-lg-8 col-xl-9 mx-auto my-auto text-center \">\r\n            <iframe class=\"border border-5 rounded\" width=\"560\" height=\"315\"");
                BeginWriteAttribute("src", " src=", 1776, "", 1809, 1);
#nullable restore
#line 46 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
WriteAttributeValue("", 1781, Model.movie.movieTrailerUrl, 1781, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                title=""YouTube video player"" frameborder=""0""
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
#line 57 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                               Write(Model.movie.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <p> <strong>Director: </strong> ");
#nullable restore
#line 58 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                       Write(Model.movie.movieDirector.directorFirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 59 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
           Write(Model.movie.movieDirector.directorLastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>\r\n                <strong>Cast: </strong>\r\n");
#nullable restore
#line 62 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                 foreach (var actor in Model.actors)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                     if (actor.movieId == Model.movie.movieId)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                   Write(actor.actorFirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;");
#nullable restore
#line 66 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                                Write(actor.actorLastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n");
#nullable restore
#line 67 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <div class=\"row\">\r\n                <div class=\"col-3\">\r\n                    <div><strong>Release Date:</strong> ");
#nullable restore
#line 74 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                                   Write(Model.movie.movieReleaseDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <div><strong>Duration:</strong> ");
#nullable restore
#line 75 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                               Write(Model.movie.movieDuration);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Minutes</div>\r\n                    <div><strong>Category:</strong> ");
#nullable restore
#line 76 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                               Write(Model.movie.movieCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    <div>\r\n                        <strong>Summary: </strong>");
#nullable restore
#line 82 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                             Write(Model.movie.movieSummary);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row mb-3\">\r\n               \r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d6be54d902895e627cb253879456cf18801e1f915555", async() => {
                    WriteLiteral("\r\n                    <input name=\"MovieId\" action=\"/MainPage/AddToWatchList\" class=\"form-control\" type=\"number\"\r\n                        placeholder=\"MovieId\"");
                    BeginWriteAttribute("value", " value=\"", 3651, "\"", 3679, 1);
#nullable restore
#line 91 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
WriteAttributeValue("", 3659, Model.movie.movieId, 3659, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" hidden />\r\n\r\n                    <button class=\"btn btn-primary btn-sm mr-2 mt-5\" type=\"submit\">Add To WatchList</button>\r\n                ");
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
                WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 97 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
             if (@TempData["MovieWatcedError"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span style=\"color: red; border: 2px solid red; padding:5px ; border-radius :3px;\">\r\n                    <strong>");
#nullable restore
#line 100 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                       Write(TempData["MovieWatcedError"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                </span>\r\n");
#nullable restore
#line 102 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </section>\r\n\r\n    <br><br>\r\n    <hr style=\"border: 3px solid black;\">\r\n    <br><br>\r\n\r\n    <!-- FİLM VİZYONDAYSA BİLET AL -->\r\n    <!-- BUY TICKET -->\r\n");
#nullable restore
#line 115 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
     if (Model.movie.isShowing)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <h2 class=\"text-center\">Watch Now!</h2>\r\n            <div class=\"btn-lg col-md-12 text-center\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d6be54d902895e627cb253879456cf18801e1f919285", async() => {
                    WriteLiteral("Buy Ticket");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("asp", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                             WriteLiteral(Model.movie.movieId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("        <br><br>\r\n        <hr style=\"border: 3px solid black;\">\r\n        <br>\r\n");
#nullable restore
#line 129 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <h2 class=\"text-center pb-3\">📆 Not In Show - You can\'t buy a ticket ❌</h2>\r\n        </div>\r\n");
                WriteLiteral("        <br>\r\n        <hr style=\"border: 3px solid black;\">\r\n        <br>\r\n");
#nullable restore
#line 139 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- COMMENTS -->\r\n    <!--MAKE COMMENT -->\r\n    <div id=\"makeComment\" class=\"container\">\r\n        <h2>Add a comment</h2>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d6be54d902895e627cb253879456cf18801e1f923324", async() => {
                    WriteLiteral(@"
            <div class=""mb-3"">
                <textarea style=""resize: none;"" class=""form-control"" name=""makeComment"" id=""makeComment"" rows=""3""
                    placeholder=""Your comment..."" maxlength=""2000"" required></textarea>
            </div>
            <div class=""container"">
                <div class=""text-end"">
                    <button class=""btn-lg btn-dark mb-4"" type=""submit"">Post</button>
                </div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5231, "/MainPage/MoviePage/", 5231, 20, true);
#nullable restore
#line 146 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
AddHtmlAttributeValue("", 5251, Model.movie.movieId, 5251, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n\r\n    <br>\r\n\r\n    <!-- READ COMMENTS -->\r\n    <div id=\"readComment\" class=\"container\">\r\n        <h2 class=\"mb-4\">Other comments</h2>\r\n\r\n");
#nullable restore
#line 167 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
         foreach (Comment comment in Model.comments)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row mb-3\">\r\n                <!-- Kullanıcı bilgisi -->\r\n            <div class=\"col-3 text-center\">\r\n                    <i class=\"fas fa-user-circle fa-5x\"></i>\r\n                    <p class=\"mt-3\"><strong>");
#nullable restore
#line 173 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                       Write(comment.userFirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;");
#nullable restore
#line 173 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                                                   Write(comment.userLastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></p>\r\n                </div>\r\n                <!-- Yorum içeriği -->\r\n            <div class=\"col-9\">\r\n                    <p>");
#nullable restore
#line 177 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                  Write(comment.commentContent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n\r\n                <br>\r\n                <hr style=\"border: 1px solid black;\">\r\n                <br>\r\n            </div>\r\n");
#nullable restore
#line 184 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <br><br>\r\n    <hr style=\"border: 3px solid black;\">\r\n    <br><br>\r\n\r\n    ");
#nullable restore
#line 192 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"\r\n        integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\"\r\n        crossorigin=\"anonymous\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Management.System.ViewModels.MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
