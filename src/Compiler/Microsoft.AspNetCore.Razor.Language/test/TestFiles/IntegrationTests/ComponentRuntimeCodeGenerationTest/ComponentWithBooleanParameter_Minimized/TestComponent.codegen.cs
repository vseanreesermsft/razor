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
            __builder.OpenElement(0, "strong");
#nullable restore
#line (1,10)-(1,18) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(1, TestBool);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<global::Test.TestComponent>(3);
            __builder.AddComponentParameter(4, "TestBool", true);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    [Parameter]
    public bool TestBool { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
