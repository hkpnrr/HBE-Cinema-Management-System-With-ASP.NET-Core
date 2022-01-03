#pragma checksum "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "051bd8e5ce2500d01aa58d397bcf2ee89a6eaad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainPage_CinemaHalls), @"mvc.1.0.view", @"/Views/MainPage/CinemaHalls.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051bd8e5ce2500d01aa58d397bcf2ee89a6eaad1", @"/Views/MainPage/CinemaHalls.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fd429d129da1b7030d35220f8e50d42701dc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_CinemaHalls : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<List<Cinema.Management.System.ViewModels.CinemaHallsViewModel>>>
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051bd8e5ce2500d01aa58d397bcf2ee89a6eaad13641", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Movies </title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"">
    <style>
        #bottomImg {
            height: 50%;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051bd8e5ce2500d01aa58d397bcf2ee89a6eaad15229", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 24 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- CINEMA HALLS AND FILMS ARE ON SHOW IN THAT HALL -->
    <section class=""hallInfo mt-5"">
        <div class=""container"" id=""outerContainer"">
            <h2 class=""fw-bold text-capitalize"">Cinema Halls</h2>
            <br>
            <hr style=""border: 2px solid black;"">
            <br>
");
#nullable restore
#line 33 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
             foreach (List<CinemaHallsViewModel> outerList in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"container\">\r\n                    <!-- CINEMA HALL INFO -->\r\n                <h2><strong>");
#nullable restore
#line 37 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
                       Write(outerList[0].cinemaHallName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></h2>\r\n                    <p><strong>Address: </strong>");
#nullable restore
#line 38 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
                                            Write(outerList[0].cinemaHallAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <br>\r\n                    <h6 class=\"fw-bold\">Films that are showing: </h6>\r\n");
#nullable restore
#line 41 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
                     foreach (CinemaHallsViewModel item in outerList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <!-- SHOWING MOVIES -->\r\n                        <div class=\"card\" style=\"width: 18rem;\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1758, "\"", 1798, 2);
                WriteAttributeValue("", 1765, "/MainPage/MoviePage/", 1765, 20, true);
#nullable restore
#line 45 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
WriteAttributeValue("", 1785, item.movieId, 1785, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img id=\"bottomImg\" class=\"card-img-top\"");
                BeginWriteAttribute("src", "\r\n                            src=", 1840, "", 1893, 1);
#nullable restore
#line 46 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
WriteAttributeValue("", 1874, item.moviePhotoUrl, 1874, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1893, "\"", 1899, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\"><a style=\"text-decoration: none;\"");
                BeginWriteAttribute("href", " href=\"", 2048, "\"", 2055, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
                                                                                            Write(item.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h5>\r\n                            </div>\r\n                        </div>\r\n");
                WriteLiteral("                        <!-- BU KARTLARDAN ALTALTA GELCEK DATABASE\'DEN GELEN VERİLER DOĞRULTUSUNDA-->\r\n");
#nullable restore
#line 53 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    <br>\r\n                    <hr style=\"border: 2px solid black;\">\r\n                    <br>\r\n                </div>\r\n");
#nullable restore
#line 61 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </section>\r\n\r\n    ");
#nullable restore
#line 65 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema.Management.System\Views\MainPage\CinemaHalls.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"\r\n        integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\"\r\n        crossorigin=\"anonymous\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<List<Cinema.Management.System.ViewModels.CinemaHallsViewModel>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
