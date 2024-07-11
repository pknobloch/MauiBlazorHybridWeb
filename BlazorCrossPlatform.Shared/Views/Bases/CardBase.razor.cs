// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace BlazorCrossPlatform.Shared.Views.Bases
{
    public partial class CardBase : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Height { get; set; } = "100%";

        [Parameter]
        public string Width { get; set; } = "100%";
    }
}
