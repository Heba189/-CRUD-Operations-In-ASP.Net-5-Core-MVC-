#pragma checksum "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2012984be83c1effdbac79eb1550f967afcd25f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\_ViewImports.cshtml"
using DotNet5CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\_ViewImports.cshtml"
using DotNet5CRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\_ViewImports.cshtml"
using DotNet5CRUD.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2012984be83c1effdbac79eb1550f967afcd25f0", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1501d93b563608b9d3a34e26b0bcbb04e6bf0cf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
   
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>\r\n    <i class=\"bi bi-film\"></i>\r\n    Movies\r\n</h2>\r\n<hr />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2012984be83c1effdbac79eb1550f967afcd25f05542", async() => {
                WriteLiteral(" <i class=\"bi bi-plus-lg\"></i> Add Movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"mt-4\">\r\n");
#nullable restore
#line 13 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
     if (!Model.Any())
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\">\r\n            <i class=\"bi bi-exclamation-triangle\"></i>   A simple warning alert???check it out!\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n");
#nullable restore
#line 24 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                     foreach(var movie in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12\">\r\n                            <div class=\"card mb-3\">\r\n                                <div class=\"row no-gutters\">\r\n                                    <div");
            BeginWriteAttribute("style", " style=\"", 805, "\"", 997, 9);
            WriteAttributeValue("", 813, "background-image:url(data:image\\/*;base64,", 813, 42, true);
#nullable restore
#line 29 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
WriteAttributeValue("", 855, Convert.ToBase64String(movie.Poster), 855, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 894, ")", 894, 1, true);
            WriteAttributeValue(" ", 895, ";background-repeat:no-repeat;", 896, 30, true);
            WriteAttributeValue(" ", 925, "background-position:center", 926, 27, true);
            WriteAttributeValue(" ", 952, "center", 953, 7, true);
            WriteAttributeValue(" ", 959, ";", 960, 2, true);
            WriteAttributeValue(" ", 961, "background-size:100%;", 962, 22, true);
            WriteAttributeValue(" ", 983, "height:200px;", 984, 14, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""col-md-4 poster""> </div>
                                    <div class=""col-md-8"">
                                        <div class=""card-body d-flex flex-column justify-content-between h-100""  >
                                            <div>
                                                <h5 class=""card-title"">");
#nullable restore
#line 33 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                                                                  Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 33 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                                                                                Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(") </h5>\r\n                                                <p class=\"card-text\"> ");
#nullable restore
#line 34 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                                                                  Write(movie.Storeline.Length > 500? $"{movie.Storeline.Substring(0,500)}...":movie.Storeline);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                            <div class=""d-flex justify-content-between align-items-center"">
                                                <p class=""card-text"">
                                                    <i class=""bi bi-star-fill text-warning""></i>
                                                    <small class=""text-muted"">");
#nullable restore
#line 39 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                                                                         Write(movie.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                                </p>\r\n                                                <div >\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2012984be83c1effdbac79eb1550f967afcd25f011285", async() => {
                WriteLiteral("\r\n                                                        <i class=\"bi bi-camera-reels\"></i>\r\n                                                        Details\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                                                                              WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2012984be83c1effdbac79eb1550f967afcd25f013824", async() => {
                WriteLiteral("\r\n                                                        <i class=\"bi bi-pencil\"></i>\r\n                                                        Edit\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                                                                           WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <a href=\"javascript:;\"   class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 50 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                                                                                                                  Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                        <i class=""bi bi-trash""></i>
                                                        Delete
                                                    </a>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                
                            </div>
                        </div>
");
#nullable restore
#line 63 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
                   
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 66 "C:\Users\Ultimate\source\repos\DotNet5CRUD\DotNet5CRUD\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    $(document).ready(function () {
        $('.js-delete').on('click', function () {
            var btn = $(this);
            /*         var result = confirm('');*/
            bootbox.confirm({
                message: ""Are You Sure That You Need To Detete Movie?"",
                buttons: {
                    confirm: {
                        label: 'Yes',
                        className: ' btn-danger'
                    },
                    cancel: {
                        label: 'No',
                        className: 'btn-outline-secondary'
                    }
                },
                callback: function (result) {
                    if (result) {
                        $.ajax({
                            url: '/movies/delete/' + btn.data('id'),
                            success: function () {
                                btn.parents('.col-12').addClass(""animate__animated animate__zoomOut"");
                                toastr.success('");
                WriteLiteral(@"Movies Deleted');
                            },
                            error: function () {
                                toastr.error('Something went wrong !');
                            }
                        });
                    }
                }
            });
       

        });
    });
</script>    
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
