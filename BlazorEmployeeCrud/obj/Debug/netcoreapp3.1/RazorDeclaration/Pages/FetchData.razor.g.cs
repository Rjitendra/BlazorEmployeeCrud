#pragma checksum "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f289db2551002afc2ac6c0bfc3d0046ef906d12"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorEmployeeCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using BlazorEmployeeCrud;

#line default
#line hidden
#line 9 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\_Imports.razor"
using BlazorEmployeeCrud.Shared;

#line default
#line hidden
#line 3 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\Pages\FetchData.razor"
using BlazorEmployeeCrud.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 39 "C:\Jitendra\Workplace\jitendra project\Blazor\BlazorEmployeeCrud\BlazorEmployeeCrud\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
