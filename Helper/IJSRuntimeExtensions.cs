using Microsoft.JSInterop;

namespace BlazorEcommerce.Helper;

public static  class IJSRuntimeExtensions
{
    public static async Task ToastSuccess(this IJSRuntime jsRuntime, string message)
    {
        await jsRuntime.InvokeVoidAsync("showToastr","success", message);
    }

    public static async Task ToastError(this IJSRuntime jsRuntime, string message)
    {
        await jsRuntime.InvokeVoidAsync("showToastr", "error", message);
    }
}