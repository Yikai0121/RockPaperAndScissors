#pragma checksum "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\Shared\Confirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b31aa3ac69dd9d9ef41880194a0c869a20019c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RockPaperAndScissors.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using RockPaperAndScissors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\_Imports.razor"
using RockPaperAndScissors.Shared;

#line default
#line hidden
#nullable disable
    public partial class Confirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\Shared\Confirmation.razor"
       
    private bool DisplayConfirmation = false;
    [Parameter] public string Title { get; set; } = "遊戲結果";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public EventCallback onConfirm { get; set; }
    [Parameter] public EventCallback playAgain { get; set; }


    public void Show() => DisplayConfirmation = true;
    public void Hide() => DisplayConfirmation = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
