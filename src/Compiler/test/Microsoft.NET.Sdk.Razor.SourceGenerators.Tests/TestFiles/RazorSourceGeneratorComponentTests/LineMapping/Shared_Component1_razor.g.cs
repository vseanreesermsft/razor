﻿#pragma checksum "Shared/Component1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89de16bbebf2501ef65f4cee8afed77b404a301"
// <auto-generated/>
#pragma warning disable 1591
namespace MyApp.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
    #line hidden
    public partial class Component1 : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "The solution to all problems is: ");
#nullable restore
#line (1,39)-(1,50) 24 "Shared/Component1.razor"
__builder.AddContent(2, RaiseHere());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "Shared/Component1.razor"
 
    private int magicNumber = RaiseHere();
    private static int RaiseHere()
    {
        return 42;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
