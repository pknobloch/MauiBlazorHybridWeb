// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using BlazorCrossPlatform.Shared.Models.Components.IconNames;
using Microsoft.AspNetCore.Components;

namespace BlazorCrossPlatform.Shared.Views.Bases
{
    public partial class NavLinkBase : ComponentBase
    {
        [Parameter]
        public string Href { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public IconName Icon { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public bool MatchAll { get; set; }

        
    }
}
