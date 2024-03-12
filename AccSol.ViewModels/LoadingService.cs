using Microsoft.JSInterop;

namespace AccSol.ViewModels
{
    public class LoadingService
    {
        private IJSRuntime _jsRuntime { get; set; }

        public LoadingService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }


        public async Task ShowLoading(string message = "Loading.... Please wait...")
        {
            try
            {
                await _jsRuntime.InvokeVoidAsync("eval", $"document.getElementById('loading-overlay-message').innerText = '{message}';");
                await _jsRuntime.InvokeVoidAsync("eval", "document.getElementById('loading-overlay').style.display = 'flex';");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ShowLoading(string message = \"Loading.... Please wait...\"): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
        }

        public async Task HideLoading()
        {
            try
            {
                await _jsRuntime.InvokeVoidAsync("eval", "document.getElementById('loading-overlay').style.display = 'none';");
            }
            catch (Exception ex)
            {
                Console.WriteLine("HideLoading(): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
        }
    }

}
