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
            __builder.OpenComponent<global::Test.ComponentWithNullableAction>(0);
            __builder.AddComponentParameter(1, "NullableAction", (global::System.Action)(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                              NullableAction

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
       
	[Parameter]
	public Action NullableAction { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
