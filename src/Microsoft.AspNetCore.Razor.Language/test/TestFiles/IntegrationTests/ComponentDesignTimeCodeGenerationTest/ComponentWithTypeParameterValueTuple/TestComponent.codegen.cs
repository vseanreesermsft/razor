// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class TestComponent<TItem1, TItem2> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
global::System.Object TItem1 = null!;

#line default
#line hidden
#nullable disable
        }
        ))();
        ((System.Action)(() => {
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
global::System.Object TItem2 = null!;

#line default
#line hidden
#nullable disable
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = ChildContent(Item1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "x:\dir\subdir\Test\TestComponent.cshtml"
 foreach (var item in Items2)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "x:\dir\subdir\Test\TestComponent.cshtml"
  __o = ChildContent(item);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "x:\dir\subdir\Test\TestComponent.cshtml"
                              
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    [Parameter] public (TItem1, TItem2) Item1 { get; set; }
    [Parameter] public List<(TItem1, TItem2)> Items2 { get; set; }
    [Parameter] public RenderFragment<(TItem1, TItem2)> ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
