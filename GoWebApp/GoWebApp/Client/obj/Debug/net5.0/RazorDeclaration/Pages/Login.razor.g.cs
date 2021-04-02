// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoWebApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using GoWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using GoWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using GoWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Pages\Login.razor"
       
    private ProfileLogIn user = new ProfileLogIn();

    private async void HandleLogin()
    {
        var result = await _authService.Login(user);
        if(result.Success)
        {
            await _localStorage.SetItemAsync<string>("authToken", result.Data);
            await _authStateProvider.GetAuthenticationStateAsync();
        }
        else
        {
            _toastService.ShowError(result.Message);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GoWebApp.Client.Services.IAuthService _authService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService _localStorage { get; set; }
    }
}
#pragma warning restore 1591
