using Microsoft.AspNetCore.Components.Builder;
using Microsoft.JSInterop;
using System.Globalization;

namespace Blazored.Localisation
{
    public static class UseBrowserLocalisationExtension
    {
        public static void UseBlazoredLocalisation(this IComponentsApplicationBuilder app)
        {
            var jsRuntime = app.Services.GetService(typeof(IJSRuntime));
            var browserLocale = ((IJSInProcessRuntime)jsRuntime).Invoke<string>("Blazored.Localisation.GetBrowserLocale");
            var culture = new CultureInfo(browserLocale);

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;
        }
    }
}
