#pragma checksum "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e3b76ce32919ea7c4258538c6f33b54a1463ddf"
// <auto-generated/>
#pragma warning disable 1591
namespace GoWebApp.Client.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "top-row pl-4 navbar navbar-dark");
                __builder2.AddAttribute(4, "b-s4lr4fs2zn");
                __builder2.AddMarkupContent(5, "<a class=\"navbar-brand\" href b-s4lr4fs2zn>GoWebApp</a>\r\n            ");
                __builder2.OpenElement(6, "button");
                __builder2.AddAttribute(7, "class", "navbar-toggler");
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\NavMenu.razor"
                                                     ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "b-s4lr4fs2zn");
                __builder2.AddMarkupContent(10, "<span class=\"navbar-toggler-icon\" b-s4lr4fs2zn></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", 
#nullable restore
#line 14 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "b-s4lr4fs2zn");
                __builder2.OpenElement(16, "ul");
                __builder2.AddAttribute(17, "class", "nav flex-column");
                __builder2.AddAttribute(18, "b-s4lr4fs2zn");
                __builder2.OpenElement(19, "li");
                __builder2.AddAttribute(20, "class", "nav-item px-3");
                __builder2.AddAttribute(21, "b-s4lr4fs2zn");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
                __builder2.AddAttribute(23, "class", "nav-link");
                __builder2.AddAttribute(24, "href", "/profile");
                __builder2.AddAttribute(25, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 17 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\NavMenu.razor"
                                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-s4lr4fs2zn></span> Profile\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "nav-item px-3");
                __builder2.AddAttribute(31, "b-s4lr4fs2zn");
                __builder2.OpenElement(32, "a");
                __builder2.AddAttribute(33, "class", "nav-link");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\NavMenu.razor"
                                                  Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "style", "cursor:pointer");
                __builder2.AddAttribute(36, "b-s4lr4fs2zn");
                __builder2.AddMarkupContent(37, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-s4lr4fs2zn></span>Logout        \r\n                    ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(38, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private async void Logout()
    {
        await _localStorage.RemoveItemAsync("authToken");
        await _authStateProvider.GetAuthenticationStateAsync();
        _navManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService _localStorage { get; set; }
    }
}
#pragma warning restore 1591
