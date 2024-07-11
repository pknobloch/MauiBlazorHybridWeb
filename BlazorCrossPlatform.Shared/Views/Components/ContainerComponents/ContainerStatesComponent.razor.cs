// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using BlazorCrossPlatform.Shared.Models.Components.ComponentStates;
using Microsoft.AspNetCore.Components;

namespace BlazorCrossPlatform.Shared.Views.Components.ContainerComponents
{
    public partial class ContainerStatesComponent : ComponentBase
    {
        [Parameter]
        public ComponentState State { get; set; }

    }
}
