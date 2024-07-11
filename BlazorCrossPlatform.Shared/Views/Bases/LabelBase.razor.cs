// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using BlazorCrossPlatform.Shared.Models.Components.LabelBaseTypographies;
using Microsoft.AspNetCore.Components;

namespace BlazorCrossPlatform.Shared.Views.Bases
{
    public partial class LabelBase : ComponentBase
    {
        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public LabelBaseTypography Typo { get; set; }

        [Parameter]
        public bool IsVisible { get; set; } = true;
    }
}
