#pragma checksum "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19ea039f09387b5d216eafbe34bc97e7d8a43485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\_ViewImports.cshtml"
using FirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\_ViewImports.cshtml"
using FirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ea039f09387b5d216eafbe34bc97e7d8a43485", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b951a5d3431184d260cd5fa679540aa680aa4c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"
 foreach (var people in Model)
{
    var color = "";
    if (people.Id%2==0 && people.FirstName.Length <=6)
    {
        color = "Red";
    }
    else
    {
        color = "Blue";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>ID: <span");
            BeginWriteAttribute("style", " style=\"", 239, "\"", 259, 2);
            WriteAttributeValue("", 247, "color:", 247, 6, true);
#nullable restore
#line 14 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"
WriteAttributeValue("", 253, color, 253, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"
                                  Write(people.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> , LastName: ");
#nullable restore
#line 14 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"
                                                                 Write(people.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", FirstName: <span");
            BeginWriteAttribute("style", " style=\"", 326, "\"", 346, 2);
            WriteAttributeValue("", 334, "color:", 334, 6, true);
#nullable restore
#line 14 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"
WriteAttributeValue("", 340, color, 340, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"
                                                                                                                         Write(people.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> , MiddleName: ");
#nullable restore
#line 14 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"
                                                                                                                                                                Write(people.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" DateTime: <span style=\"color: orangered\">");
#nullable restore
#line 14 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"
                                                                                                                                                                                                                            Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </h5>\r\n");
#nullable restore
#line 15 "C:\Users\User\source\repos\FirstApp\FirstApp\Views\Person\Index.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
