#pragma checksum "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\UpdateCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528d8c6cbfb7e37c3e0ae8e3486c63633bc42f16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateCategory), @"mvc.1.0.view", @"/Views/Admin/UpdateCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528d8c6cbfb7e37c3e0ae8e3486c63633bc42f16", @"/Views/Admin/UpdateCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c485602977c1d028d79af45d567f3504bebd02f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AmlShop.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\UpdateCategory.cshtml"
  
    ViewData["Title"] = "UpdateCategory";
    Layout = "~/Views/Shared/_AdminLayout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Tables</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""index.html"">Dashboard</a></li>
        <li class=""breadcrumb-item "">Categories</li>
        <li class=""breadcrumb-item active"">Add New Category</li>
    </ol>
    <div class=""card mb-4"">

    </div>
    <div class=""card mb-4"">
        <div class=""card-header"">
            <i class=""fas fa-table mr-1""></i>
            Add New Category
        </div>
        <div class=""card-body"">
");
#nullable restore
#line 23 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\UpdateCategory.cshtml"
             using (Html.BeginForm("UpdateCategory", "Admin", FormMethod.Post, new { enctype = "multipart/form.data" }))
            {  
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\UpdateCategory.cshtml"
           Write(Html.HiddenFor(m => m.CatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label class=\"control-label\"> category name</label>\r\n                ");
#nullable restore
#line 28 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\UpdateCategory.cshtml"
           Write(Html.TextBoxFor(m => m.CatName, new { @class = "form-control", placeholder = "enter category name", required = "required", atuofocus = "autofocus" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n         \r\n         ");
#nullable restore
#line 30 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\UpdateCategory.cshtml"
    Write(Html.ValidationMessageFor(m => m.CatName, "", new { @class = "text danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <a OnClick=\"window.history.back();\" class=\"btn btn-danger\">cancel</a>\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Save\" />\r\n");
#nullable restore
#line 34 "G:\.net core\amlshopping\AmlShop\AmlShop\Views\Admin\UpdateCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AmlShop.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
