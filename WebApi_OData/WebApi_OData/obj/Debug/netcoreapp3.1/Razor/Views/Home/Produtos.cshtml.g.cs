#pragma checksum "C:\Users\renan.gobbi\Desktop\Avaliacao_RenanGobbi\App\WebApi_OData\WebApi_OData\Views\Home\Produtos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d60cc42319853f6c4412657a9abb8436bbb09b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Produtos), @"mvc.1.0.view", @"/Views/Home/Produtos.cshtml")]
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
#line 1 "C:\Users\renan.gobbi\Desktop\Avaliacao_RenanGobbi\App\WebApi_OData\WebApi_OData\Views\_ViewImports.cshtml"
using WebApi_OData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renan.gobbi\Desktop\Avaliacao_RenanGobbi\App\WebApi_OData\WebApi_OData\Views\_ViewImports.cshtml"
using WebApi_OData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d60cc42319853f6c4412657a9abb8436bbb09b9", @"/Views/Home/Produtos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac0dbe0ae0d7fafced7148273e5d0e396a017be5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Produtos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApi_OData.Models.PRODUTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\renan.gobbi\Desktop\Avaliacao_RenanGobbi\App\WebApi_OData\WebApi_OData\Views\Home\Produtos.cshtml"
  
    ViewData["Title"] = "Produtos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"

<div class=""row mt-4"">
    <div class=""col-md-12"">
        <table class=""table table-bordered table-striped"" id=""tabela-dados"">
            <tr>
                <th id=""teste"">
                    <a class=""teste"">ID</a>
                </th>
                <th>
                    <a>NOME</a>
                </th>
            </tr>

");
#nullable restore
#line 22 "C:\Users\renan.gobbi\Desktop\Avaliacao_RenanGobbi\App\WebApi_OData\WebApi_OData\Views\Home\Produtos.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "C:\Users\renan.gobbi\Desktop\Avaliacao_RenanGobbi\App\WebApi_OData\WebApi_OData\Views\Home\Produtos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\renan.gobbi\Desktop\Avaliacao_RenanGobbi\App\WebApi_OData\WebApi_OData\Views\Home\Produtos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NOME));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "C:\Users\renan.gobbi\Desktop\Avaliacao_RenanGobbi\App\WebApi_OData\WebApi_OData\Views\Home\Produtos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApi_OData.Models.PRODUTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
