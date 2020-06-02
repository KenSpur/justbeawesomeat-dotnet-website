using System.Threading.Tasks;
using Application.Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Application.Client.Pages
{
    public class ContactPageBase : ComponentBase
    {
        [Inject] public INavigationService NavigationService { get; set; }
        [Inject] public IJSRuntime Js { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await Js.InvokeVoidAsync("window.initContact");

            await base.OnAfterRenderAsync(firstRender);
        }

        protected override async Task OnInitializedAsync()
        {
            NavigationService.AnimatePageRemovalAsync = AnimatePageRemovalAsync;

            await base.OnInitializedAsync();
        }

        private async Task AnimatePageRemovalAsync()
        {
            await Js.InvokeVoidAsync("testAnimationFunction", 20);

            await Task.Delay(300);
        }
    }
}