﻿#pragma checksum "Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87d8a07c5693b48e5469d0cbc37b8ccc95b4cce2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/Views/Home/Index.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    internal sealed class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "Views/Home/Index.cshtml"
   var msg = "What's up"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>console.log(\'");
#nullable restore
#line (2,23)-(2,26) 6 "Views/Home/Index.cshtml"
Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');</script>\r\n<div>console.log(\'");
#nullable restore
#line (3,20)-(3,23) 6 "Views/Home/Index.cshtml"
Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');</div>\r\n<script>console.log(\'No variable\');</script>\r\n<div>console.log(\'No variable\');</div>\r\n<script>\r\n    console.log(\'");
#nullable restore
#line (7,19)-(7,22) 6 "Views/Home/Index.cshtml"
Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n</script>\r\n<div>\r\n    console.log(\'");
#nullable restore
#line (10,19)-(10,22) 6 "Views/Home/Index.cshtml"
Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n</div>\r\n<script>\r\n    console.log(\'No variable\');\r\n</script>\r\n<div>\r\n    console.log(\'No variable\');\r\n</div>\r\n");
#nullable restore
#line (18,3)-(18,78) 6 "Views/Home/Index.cshtml"
Write(await Html.RenderComponentAsync<MyApp.Shared.Component1>(RenderMode.Static));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
