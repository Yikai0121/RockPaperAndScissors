#pragma checksum "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c248b24109c465988c6fa5f8ee0385a6297f1dde"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RockPaperAndScissors.Pages
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
#line 2 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\Pages\Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\Pages\Index.razor"
using RockPaperAndScissors.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\Pages\Index.razor"
using RockPaperAndScissors.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\k2lairrol\Documents\GitHub\RockPaperAndScissors\RockPaperAndScissors\Pages\Index.razor"
 
    Confirmation confirmation;

    List<Hand> hands = new List<Hand>()
    {
        new Hand{Selection = OptionRPS.Paper, LosesAgainst = OptionRPS.Scissors,
            WinAgainst= OptionRPS.Rock, Image="paper.jpg"},

        new Hand{Selection = OptionRPS.Rock, LosesAgainst = OptionRPS.Paper,
            WinAgainst= OptionRPS.Scissors, Image="rock.jpg"},

        new Hand{Selection = OptionRPS.Scissors, LosesAgainst = OptionRPS.Rock,
            WinAgainst= OptionRPS.Paper, Image="scissors.jpg"},
    };
    //List<Hand> hands2 = new List<Hand>()
    //{
    //      new Hand{Selection = OptionRPS.Paper, LosesAgainst = OptionRPS.Scissors,
    //        WinAgainst= OptionRPS.Rock}
    //};

    Timer timer;
    Hand opponentHand;
    string resultMessage = string.Empty;
    string resultMessageColor = string.Empty;
    protected override void OnInitialized()
    {
        opponentHand = hands[0];
        timer = new Timer();
        timer.Interval = 100;
        timer.Elapsed += TimeOnElapsed;
        timer.Start();
    }
    int indexOpponentHand = 0;
    private void TimeOnElapsed(object sender, ElapsedEventArgs e)
    {
        indexOpponentHand = (indexOpponentHand + 1) % hands.Count;
        opponentHand = hands[indexOpponentHand];
        StateHasChanged();
    }
    private void SelectHand(Hand hand)
    {

        timer.Stop();
        confirmation.Show();
        var result = hand.PlayAgainst(opponentHand);
        if (result == GameStatus.Victory)
        {
            resultMessage =  "獲勝!!!!";
            resultMessageColor = "red";
        }
        else if (result == GameStatus.Loss)
        {
            resultMessage = "失敗Q _ Q";
            resultMessageColor = "green";
        }
        else
        {
            resultMessage = "平手!再接再厲!";
            resultMessageColor = "blue";
        }
    }
    void onConfirm()
    {
        confirmation.Hide();

    }
    private void PlayAgain()
    {
        timer.Start();
        confirmation.Hide();
        resultMessage = string.Empty;
    }
    public void Dispose()
    {
        if (timer != null)
        {
            timer.Dispose();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
