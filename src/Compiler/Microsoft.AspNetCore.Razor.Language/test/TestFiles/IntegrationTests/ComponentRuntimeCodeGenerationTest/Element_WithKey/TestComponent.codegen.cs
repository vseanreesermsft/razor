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
            __builder.OpenElement(0, "elem");
            __builder.AddAttribute(1, "attributebefore", "before");
            __builder.AddAttribute(2, "attributeafter", "after");
            __builder.SetKey(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                     someObject

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, "Hello");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    private object someObject = new object();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
