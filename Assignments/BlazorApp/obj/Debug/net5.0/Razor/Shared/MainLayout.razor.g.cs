#pragma checksum "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dac8473d02e0f09681b79ecbb0594263d9aff8b"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\Shared\MainLayout.razor"
using Assignment1.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-d6tdo58m9p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "sidebar");
                __builder2.AddAttribute(7, "b-d6tdo58m9p");
                __builder2.OpenComponent<Assignment1.Shared.NavMenu>(8);
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, " \r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "main");
            __builder.AddAttribute(12, "b-d6tdo58m9p");
            __builder.AddMarkupContent(13, "<login b-d6tdo58m9p></login>\r\n        <div class=\"top-row px-4\" b-d6tdo58m9p></div>\r\n\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "content px-4");
            __builder.AddAttribute(16, "b-d6tdo58m9p");
            __builder.AddContent(17, 
#nullable restore
#line 19 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\Shared\MainLayout.razor"
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
#nullable restore
#line 24 "C:\Users\kaspe\Documents\Git\DNP1_Sessions\Assignments\Assignment1\Shared\MainLayout.razor"
      

    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }

    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login"); // NavigationManager.NavigateTo($"/Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
