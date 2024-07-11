// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------


using BlazorCrossPlatform.Shared.Models.Components.ComponentStates;
using Microsoft.AspNetCore.Components;

namespace BlazorCrossPlatform.Shared.Views.Components.ContainerComponents
{
    public partial class ContainerComponent : ComponentBase
    {
        [Parameter]
        public ComponentState State { get; set; }

        [Parameter]
        public RenderFragment Loading { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public string Error { get; set; }
    }
}
