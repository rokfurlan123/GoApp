#pragma checksum "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d092d61ed0175fc8e49d7062b9d8f02d826b8ee"
// <auto-generated/>
#pragma warning disable 1591
namespace GoWebApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using GoWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using GoWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using GoWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
 if (username != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n        Username: ");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
                   username

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n        <br>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.OpenElement(7, "label");
            __builder.AddMarkupContent(8, "\r\n                Message:\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "size", "50");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
                              messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
                          Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "disabled", 
#nullable restore
#line 20 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
                                            !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    <hr>");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "id", "messagesList");
#nullable restore
#line 25 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
         foreach (var message in messages)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "li");
            __builder.AddContent(22, 
#nullable restore
#line 27 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
                 message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\rocky\Desktop\githubRepos\GoApp\GoWebApp\GoWebApp\Client\Pages\Chat.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string username = null;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        var neki = await _getUser.GetProfileInfo();
        username = neki.Username;
        var token = "token2"; // to se mora ujemat szi tem kar mas pod jwt bearer token
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/gohub"), options =>
            {
            //options.AccessTokenProvider = () => Task.FromResult();
            options.Headers.Add("Authorization", $"Bearer {token}");
            })
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    async Task Send() =>
        await hubConnection.SendAsync("SendMessage", username, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GoWebApp.Client.Services.IGetProfileService _getUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration _iconfig { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
