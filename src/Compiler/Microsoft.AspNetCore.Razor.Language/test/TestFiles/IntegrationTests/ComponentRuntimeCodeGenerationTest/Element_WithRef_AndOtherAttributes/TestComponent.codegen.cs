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
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "data-slider-min", 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                     Min

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(3, (__value) => {
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                 _element = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
        private ElementReference _element;

        [Parameter] public int Min { get; set; }
        public void Foo() { System.GC.KeepAlive(_element); }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
