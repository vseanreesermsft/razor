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
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
  
  var myValue = "Expression value";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "elem");
            __builder.AddAttribute(1, "data-abc", "Literal value");
            __builder.AddAttribute(2, "data-def", 
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
                                          myValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591