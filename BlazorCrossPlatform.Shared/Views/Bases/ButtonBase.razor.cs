// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.FluentUI.AspNetCore.Components;

namespace BlazorCrossPlatform.Shared.Views.Bases
{
    public partial class ButtonBase : ComponentBase
    {

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter]
        public bool IsDisabled { get; set; }
        
        [Parameter]
        public Appearance Appearance { get; set; }

      
    }
}
