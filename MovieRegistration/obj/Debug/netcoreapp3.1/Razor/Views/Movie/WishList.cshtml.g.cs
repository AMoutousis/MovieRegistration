#pragma checksum "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e824a7c543490ede2e31a7f160219306aa26e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_WishList), @"mvc.1.0.view", @"/Views/Movie/WishList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/WishList.cshtml", typeof(AspNetCore.Views_Movie_WishList))]
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
#line 1 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#line 2 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e824a7c543490ede2e31a7f160219306aa26e6", @"/Views/Movie/WishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_WishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml"
  
    ViewData["Title"] = "WishList";

#line default
#line hidden
            BeginContext(46, 115, true);
            WriteLiteral("\r\n\r\n\r\n<h1>WishList</h1>\r\n<p>We don\'t have the movie you\'re looking for.. but if you wish upon a star...</p>\r\n\r\n\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml"
  

    foreach (var item in ViewBag.wish)
    {

#line default
#line hidden
            BeginContext(214, 29, true);
            WriteLiteral("    <ul>\r\n        <li>Title: ");
            EndContext();
            BeginContext(244, 10, false);
#line 18 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml"
              Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(254, 26, true);
            WriteLiteral("</li>\r\n        <li>Genre: ");
            EndContext();
            BeginContext(281, 10, false);
#line 19 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml"
              Write(item.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(291, 25, true);
            WriteLiteral("</li>\r\n        <li>Date: ");
            EndContext();
            BeginContext(317, 29, false);
#line 20 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml"
             Write(item.Year.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(346, 26, true);
            WriteLiteral("</li>\r\n        <li>Actor: ");
            EndContext();
            BeginContext(373, 11, false);
#line 21 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml"
              Write(item.Actors);

#line default
#line hidden
            EndContext();
            BeginContext(384, 30, true);
            WriteLiteral("</li>\r\n        <li>Directors: ");
            EndContext();
            BeginContext(415, 14, false);
#line 22 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml"
                  Write(item.Directors);

#line default
#line hidden
            EndContext();
            BeginContext(429, 18, true);
            WriteLiteral("</li>\r\n    </ul>\r\n");
            EndContext();
#line 24 "C:\Users\Andoni\source\repos\MovieRegistration\MovieRegistration\Views\Movie\WishList.cshtml"

    }

    

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
