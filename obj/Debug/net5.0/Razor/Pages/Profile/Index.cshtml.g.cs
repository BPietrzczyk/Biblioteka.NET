#pragma checksum "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5fd0fa6a289aa1038e316a17fe293036254108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Projekt_Biblioteka.Pages.Profile.Pages_Profile_Index), @"mvc.1.0.razor-page", @"/Pages/Profile/Index.cshtml")]
namespace Projekt_Biblioteka.Pages.Profile
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
#line 1 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\_ViewImports.cshtml"
using Projekt_Biblioteka;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5fd0fa6a289aa1038e316a17fe293036254108", @"/Pages/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f54d69dc2d60d9d84ed18497b92c0910102d655", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml"
  

    var userId = "";
    var userLogin = "";
    var userEmail = "";
    byte[] valueID;
    byte[] valueLogin;
    byte[] valueEmail;

    HttpContext.Session.TryGetValue("UserId", out valueID);
    HttpContext.Session.TryGetValue("UserLogin", out valueLogin);
    HttpContext.Session.TryGetValue("UserEmail", out valueEmail);
    try
    {
        userId = System.Text.Encoding.UTF8.GetString(valueID);
        userLogin = System.Text.Encoding.UTF8.GetString(valueLogin);
        userEmail = System.Text.Encoding.UTF8.GetString(valueEmail);
    }
    catch (Exception e) { }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html lang=\"pl\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb5fd0fa6a289aa1038e316a17fe2930362541085138", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>Biblioteka - Profil</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb5fd0fa6a289aa1038e316a17fe2930362541085476", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral(@"
<div class=""row gutters-sm"">
    <div class=""col-md-4 mb-3"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex flex-column align-items-center text-center"">
                    <div class=""mt-3"">
                        <h4>");
#nullable restore
#line 38 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml"
                        Write(userLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p class=\"text-secondary mb-1\">Email</p>\r\n                        <p class=\"text-muted font-size-sm\">");
#nullable restore
#line 40 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml"
                                                       Write(userEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb5fd0fa6a289aa1038e316a17fe2930362541088299", async() => {
                WriteLiteral("\r\n                            <button name=\"profile\" value=\"Edit\" class=\"btn btn-primary\">Edytuj</button>\r\n                            <button name=\"profile\" value=\"Logout\" class=\"btn btn-outline-primary\">Wyloguj</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""card mt-3"">
            <ul class=""list-group list-group-flush"">
                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-globe mr-2 icon-inline""><circle cx=""12"" cy=""12"" r=""10""></circle><line x1=""2"" y1=""12"" x2=""22"" y2=""12""></line><path d=""M12 2a15.3 15.3 0 0 1 4 10 15.3 15.3 0 0 1-4 10 15.3 15.3 0 0 1-4-10 15.3 15.3 0 0 1 4-10z""></path></svg>Website</h6>
                    <span class=""text-secondary"">https://bootdey.com</span>
                </li>
                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                    <h6 class=""mb-0""><svg xmlns=""http://ww");
            WriteLiteral(@"w.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-github mr-2 icon-inline""><path d=""M9 19c-5 1.5-5-2.5-7-3m14 6v-3.87a3.37 3.37 0 0 0-.94-2.61c3.14-.35 6.44-1.54 6.44-7A5.44 5.44 0 0 0 20 4.77 5.07 5.07 0 0 0 19.91 1S18.73.65 16 2.48a13.38 13.38 0 0 0-7 0C6.27.65 5.09 1 5.09 1A5.07 5.07 0 0 0 5 4.77a5.44 5.44 0 0 0-1.5 3.78c0 5.42 3.3 6.61 6.44 7A3.37 3.37 0 0 0 9 18.13V22""></path></svg>Github</h6>
                    <span class=""text-secondary"">bootdey</span>
                </li>
                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-twitter mr-2 icon-inline text-info""><path d=""M23 3a10");
            WriteLiteral(@".9 10.9 0 0 1-3.14 1.53 4.48 4.48 0 0 0-7.86 3v1A10.66 10.66 0 0 1 3 4s-4 9 5 13a11.64 11.64 0 0 1-7 2c9 5 20 0 20-11.5a4.5 4.5 0 0 0-.08-.83A7.72 7.72 0 0 0 23 3z""></path></svg>Twitter</h6>
                    <span class=""text-secondary"">span bootdey</span>
                </li>
                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-instagram mr-2 icon-inline text-danger""><rect x=""2"" y=""2"" width=""20"" height=""20"" rx=""5"" ry=""5""></rect><path d=""M16 11.37A4 4 0 1 1 12.63 8 4 4 0 0 1 16 11.37z""></path><line x1=""17.5"" y1=""6.5"" x2=""17.51"" y2=""6.5""></line></svg>Instagram</h6>
                    <span class=""text-secondary"">bootdey</span>
                </li>
                <li class=""list-group-item d-flex justify-conte");
            WriteLiteral(@"nt-between align-items-center flex-wrap"">
                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-facebook mr-2 icon-inline text-primary""><path d=""M18 2h-3a5 5 0 0 0-5 5v3H7v4h3v8h4v-8h3l1-4h-4V7a1 1 0 0 1 1-1h3z""></path></svg>Facebook</h6>
                    <span class=""text-secondary"">bootdey</span>
                </li>
            </ul>
        </div>
    </div>






    <!-- to po prawej -->
    <!-- tutaj mogą być wypożyczone książki -->

    <div class=""col-md-8"">


        
");
#nullable restore
#line 87 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml"
             foreach (Models.Book book in Model.borriwedBooks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card mb-3"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Tytuł</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
#nullable restore
#line 96 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml"
                           Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <h6 class=""mb-0"">Autor</h6>
                            </div>
                            <div class=""col-sm-9 text-secondary"">
                                ");
#nullable restore
#line 105 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml"
                           Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <hr>\r\n                        <div class=\"row\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb5fd0fa6a289aa1038e316a17fe29303625410815724", async() => {
                WriteLiteral("\r\n                                <div class=\"col-sm-12\">\r\n                                    <button name=\"returnBookId\"");
                BeginWriteAttribute("value", " value=\"", 6513, "\"", 6529, 1);
#nullable restore
#line 112 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml"
WriteAttributeValue("", 6521, book.Id, 6521, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger\">Oddaj</button>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 118 "C:\Users\paswi\Source\Repos\Biblioteka.NET\Pages\Profile\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        



        <!--

        <div class=""card mb-3"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <h6 class=""mb-0"">Tytuł</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                        Kenneth Valdez
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <h6 class=""mb-0"">Autor</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                        fip@jukmuh.al
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <form method=""post"">
                        <button name=""returnBook"" value=""bookId"" class=""btn btn-outline-danger"">Oddaj</button>
                    </form>
                </div>
            </d");
            WriteLiteral(@"iv>
        </div>









        <div class=""card mb-3"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <h6 class=""mb-0"">Full Name</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                        Kenneth Valdez
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <h6 class=""mb-0"">Email</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                        fip@jukmuh.al
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <h6 class=""mb-0"">Phone</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                        (23");
            WriteLiteral(@"9) 816-9029
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <h6 class=""mb-0"">Mobile</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                        (320) 380-4539
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <h6 class=""mb-0"">Address</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                        Bay Area, San Francisco, CA
                    </div>
                </div>
            </div>
        </div>

        -->

    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projekt_Biblioteka.Pages.Profile.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projekt_Biblioteka.Pages.Profile.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projekt_Biblioteka.Pages.Profile.IndexModel>)PageContext?.ViewData;
        public Projekt_Biblioteka.Pages.Profile.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591