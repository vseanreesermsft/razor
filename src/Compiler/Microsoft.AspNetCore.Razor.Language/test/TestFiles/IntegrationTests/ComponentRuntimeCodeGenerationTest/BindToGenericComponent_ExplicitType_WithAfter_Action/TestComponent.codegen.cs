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
            __builder.OpenComponent<global::Test.MyComponent<int>>(0);
            __builder.AddComponentParameter(1, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                           ParentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentParameter(2, "ValueChanged", (global::System.Action<int>)( __value => { ParentValue = __value; global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.InvokeSynchronousDelegate(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                           Update

#line default
#line hidden
#nullable disable
            ); }));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    public int ParentValue { get; set; } = 42;

    public void Update() { }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
