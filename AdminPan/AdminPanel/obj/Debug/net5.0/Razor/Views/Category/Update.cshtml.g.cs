#pragma checksum "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32572ed6e26b35db0b53e5755f60b6e5b7950825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Update), @"mvc.1.0.view", @"/Views/Category/Update.cshtml")]
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
#line 1 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\_ViewImports.cshtml"
using AdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\_ViewImports.cshtml"
using AdminPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32572ed6e26b35db0b53e5755f60b6e5b7950825", @"/Views/Category/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc3c934630a6b03ff300871b08203750eeff685", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KatmanAdmin.Entity.Entities.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Kategori Güncelle</h1>\n<br />\n");
#nullable restore
#line 9 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Update.cshtml"
 using (Html.BeginForm("Update", "Category", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 12 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Update.cshtml"
   Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 13 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Update.cshtml"
   Write(Html.TextBoxFor(x=>x.Name/*, new { @class = "form-control" }*/));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 14 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Update.cshtml"
   Write(Html.ValidationMessageFor(x=>x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <br /><br />\n        <button class=\"btn btn-outline-success\">Güncelle</button>\n    </div>\n");
#nullable restore
#line 18 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Update.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KatmanAdmin.Entity.Entities.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
