#pragma checksum "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d16f91e42a370d11b02b251dccd75dabd78f9a58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMainPage_AdminMovies), @"mvc.1.0.view", @"/Views/AdminMainPage/AdminMovies.cshtml")]
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
#line 1 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d16f91e42a370d11b02b251dccd75dabd78f9a58", @"/Views/AdminMainPage/AdminMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fd429d129da1b7030d35220f8e50d42701dc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMainPage_AdminMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/AdminMainPage/DeleteMovie"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d16f91e42a370d11b02b251dccd75dabd78f9a584913", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Movies</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d16f91e42a370d11b02b251dccd75dabd78f9a586412", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
Write(await Html.PartialAsync("_admNavbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">All Films</h1>
        <hr>
        <a class=""btn btn-primary btn-sm"" href=""#"">Add Movie</a>
        <table class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td style=""width: 30px;"">Id</td>
                    <td style=""width: 100px;"">Photo</td>
                    <td>Name</td>
                    <td style=""width: 20px;"">Duration</td>
                    <td style=""width: 20px;"">Category</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                 if(Model.Count > 0)
                {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                        foreach (Movie mov in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                               Write(mov.movieId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td><img");
                BeginWriteAttribute("src", " src=\"", 1505, "\"", 1529, 1);
#nullable restore
#line 41 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
WriteAttributeValue("", 1511, mov.moviePhotoUrl, 1511, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"80\"></td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                               Write(mov.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                               Write(mov.movieDuration);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                               Write(mov.movieCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 1806, "\"", 1855, 2);
                WriteAttributeValue("", 1813, "/AdminMainPage/AdminMoviePage/", 1813, 30, true);
#nullable restore
#line 47 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
WriteAttributeValue("", 1843, mov.movieId, 1843, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                                    \r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d16f91e42a370d11b02b251dccd75dabd78f9a5810631", async() => {
                    WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"productId\"");
                    BeginWriteAttribute("value", " value=\"", 2137, "\"", 2157, 1);
#nullable restore
#line 50 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
WriteAttributeValue("", 2145, mov.movieId, 2145, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </td>\r\n                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                         
                }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Movies</h3>\r\n                    </div>\r\n");
#nullable restore
#line 60 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n    ");
#nullable restore
#line 66 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMovies.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"\r\n        integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\"\r\n        crossorigin=\"anonymous\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
