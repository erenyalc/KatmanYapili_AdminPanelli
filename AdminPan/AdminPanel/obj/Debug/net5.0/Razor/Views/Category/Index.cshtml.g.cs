#pragma checksum "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49739016ef5f2484189849a4d96b222ca61d04dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml"
using KatmanAdmin.Entity.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49739016ef5f2484189849a4d96b222ca61d04dd", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc3c934630a6b03ff300871b08203750eeff685", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Ana Sayfa";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kategoriler Listesi</h1>

<a href=""/Category/Add"" class=""btn btn-outline-info mb-2"">Yeni Kategori Ekle</a>

<table class=""table table-hover"">
    <tr>
        <th>Kategoriler No</th>
        <th>Kategoriler Adı</th>
        <th>Düzenle</th>
        
    </tr>
    <tbody class=""table-group-devider"""">
");
#nullable restore
#line 19 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml"
         foreach (var Category in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 22 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml"
               Write(Category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml"
               Write(Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td> <a class=\"btn btn-outline-success\"");
            BeginWriteAttribute("href", " href=\"", 607, "\"", 643, 2);
            WriteAttributeValue("", 614, "/Category/Update/", 614, 17, true);
#nullable restore
#line 24 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml"
WriteAttributeValue("", 631, Category.Id, 631, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a> \n                <a class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("href", " href=\"", 708, "\"", 744, 2);
            WriteAttributeValue("", 715, "/Category/Delete/", 715, 17, true);
#nullable restore
#line 25 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml"
WriteAttributeValue("", 732, Category.Id, 732, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Sil</a> </td>\n            </tr>\n");
#nullable restore
#line 27 "C:\Users\mehme\source\repos\KatmanAdmin\AdminPanel\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
