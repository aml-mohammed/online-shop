#pragma checksum "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e517873b8ad7e546c98d34942848c399a19866dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Categories), @"mvc.1.0.view", @"/Views/Admin/Categories.cshtml")]
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
#line 1 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\_ViewImports.cshtml"
using AmlShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\_ViewImports.cshtml"
using AmlShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e517873b8ad7e546c98d34942848c399a19866dd", @"/Views/Admin/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c485602977c1d028d79af45d567f3504bebd02f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AmlShop.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\Categories.cshtml"
  
    ViewData["Title"] = "Categories";
    Layout = "~/Views/Shared/_AdminLayout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Tables</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""index.html"">Dashboard</a></li>
        <li class=""breadcrumb-item active"">Categories</li>
    </ol>
    <div class=""card mb-4"">
       
    </div>
    <div class=""card mb-4"">
        <div class=""card-header"">
            <i class=""fas fa-table mr-1""></i>
           Category Details
            <a href=""../Admin/AddCategory"" class=""btn btn-info pull-right fa-table fa-plus"">Add New</a>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Sr.No</th>
                            <th>Category Name</th>
                            <th>Action</th>
                           
                        </tr>
                    </thead>
 ");
            WriteLiteral(@"                   <tfoot>
                        <tr>
                            <th>Name</th>
                            <th>Position</th>
                            <th>Office</th>
                          
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 41 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\Categories.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 44 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\Categories.cshtml"
                            Write(Model.IndexOf(item)+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\Categories.cshtml"
                           Write(item.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 46 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\Categories.cshtml"
                            Write(Html.ActionLink("Edit", "CategoryEdit", new { CatId = item.CatId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 49 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\Categories.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       \r\n                    </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AmlShop.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
