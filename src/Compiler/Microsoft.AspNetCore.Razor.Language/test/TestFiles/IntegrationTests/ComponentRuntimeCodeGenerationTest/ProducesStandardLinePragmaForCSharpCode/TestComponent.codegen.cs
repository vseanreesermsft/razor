﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
    #line hidden
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Conditional statement</h1>");
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
 for (var i = 0; i < 10; i++)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "p");
#nullable restore
#line (4,9)-(4,10) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(2, i);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 5 "x:\dir\subdir\Test\TestComponent.cshtml"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<h1>Statements inside code block</h1>");
#nullable restore
#line 8 "x:\dir\subdir\Test\TestComponent.cshtml"
  System.Console.WriteLine(1);System.Console.WriteLine(2);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<h1>Full-on code block</h1>");
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    [Parameter]
    public int IncrementAmount { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
