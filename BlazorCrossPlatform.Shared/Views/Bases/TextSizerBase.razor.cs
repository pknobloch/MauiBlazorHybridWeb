using Microsoft.AspNetCore.Components;

namespace BlazorCrossPlatform.Shared.Views.Bases
{
    public partial class TextSizerBase : ComponentBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            _fontSize = int.Parse((FontSize.Value ?? "14px")[..^2]);
        }
    }
}