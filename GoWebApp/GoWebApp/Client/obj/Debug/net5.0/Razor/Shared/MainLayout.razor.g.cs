#pragma checksum "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2329e0b7cb3e4275777d918b5bdf159b417c67f"
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
#nullable restore
#line 2 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page");
            __builder.AddAttribute(4, "b-b8yeb2ou7x");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "sidebar");
            __builder.AddAttribute(7, "b-b8yeb2ou7x");
            __builder.OpenComponent<GoWebApp.Client.Shared.NavMenu>(8);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "main");
            __builder.AddAttribute(12, "b-b8yeb2ou7x");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "top-row px-4");
            __builder.AddAttribute(15, "b-b8yeb2ou7x");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(16);
            __builder.AddAttribute(17, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "<a href=\"/login\" b-b8yeb2ou7x>Login</a>\r\n                    ");
                __builder2.AddMarkupContent(19, "<a href=\"/register\" b-b8yeb2ou7x>register</a>");
            }
            ));
            __builder.AddAttribute(20, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(21, "p");
                __builder2.AddAttribute(22, "b-b8yeb2ou7x");
                __builder2.AddContent(23, "hi, ");
                __builder2.AddContent(24, 
#nullable restore
#line 19 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\MainLayout.razor"
                            context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "content px-4");
            __builder.AddAttribute(28, "b-b8yeb2ou7x");
            __builder.AddContent(29, 
#nullable restore
#line 25 "D:\Namizje\githubstuff\GoWebApp\GoApp\GoWebApp\GoWebApp\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
