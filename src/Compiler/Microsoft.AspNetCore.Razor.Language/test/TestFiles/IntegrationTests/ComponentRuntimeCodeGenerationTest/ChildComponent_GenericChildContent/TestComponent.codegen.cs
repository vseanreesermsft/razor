// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Test.MyComponent<string>>(0);
            __builder.AddAttribute(1, "Item", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                  "hi"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<string>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
#nullable restore
#line (2,9)-(2,26) 25 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder2.AddContent(4, context.ToLower());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591