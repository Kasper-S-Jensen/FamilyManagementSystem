#pragma checksum "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f33a517508735d39e5f5391d1bad2186eb36728"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
using Assignment1.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "background: url(https://dk-flow-cdn.clio.me/5418e57a8149ad827325ea9a963d5a10b84afb32/6698e2547f55088c75945db92b9269e5a6969d6f.jpg) ");
            __builder.AddAttribute(2, "class", "page-holder bg-cover");
            __builder.AddMarkupContent(3, "<h2>Adults</h2>\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, " Filter by name: ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                                   arg => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "width:200px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<p><em>Loading...</em></p>");
#nullable restore
#line 20 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p><em>No adults exist. Please add some.</em></p>");
#nullable restore
#line 26 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "container");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-sm-8 justify-content-center");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-hover table-striped thead-dark table-light table-bordered");
            __builder.AddMarkupContent(20, "<thead><tr><th>Person ID</th> <th>Firstname</th> <th>Lastname</th><th>Age</th><th>Job</th><th>Salary</th></tr></thead>\r\n                    ");
            __builder.OpenElement(21, "tbody");
#nullable restore
#line 56 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     foreach (var adult in adultsToShow)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 61 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                 adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 62 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                 adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 63 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                 adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 64 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                 adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 65 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                 adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 66 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                 adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                                    () => RemoveAdult(adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(46);
            __builder.AddAttribute(47, "Policy", "SecurityLevel5");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-sm-4");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                    () => AddPerson()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "class", "btn btn-primary");
                __builder2.AddContent(54, " Add adult ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
       

    private IList<Family> familiesToShow;
    private IList<Family> allFamilies;
    FileContext familyfile;
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;
    private string? filterByString;


    protected override async Task OnInitializedAsync()
    {
    // allFamilies = FileContext.Families;
    //familiesToShow = allFamilies;

        allAdults = AdultData.GetAdults();
        adultsToShow = allAdults;
    }

    private void FilterByName(ChangeEventArgs changeEventArgs)
    {
        filterByString = null;
        try
        {
            filterByString = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(A => (filterByString != null && A.FirstName.ToLower().StartsWith(filterByString.ToLower()) ||
                                             A.LastName.ToLower().StartsWith(filterByString.ToLower()) || filterByString == null)).ToList();
    }


    private void RemoveAdult(int adultId)
    {
        Adult adultToRemove = allAdults.First(a => a.Id == adultId);
        AdultData.RemoveAdult(adultId);
        allAdults.Remove(adultToRemove);
        adultsToShow.Remove(adultToRemove);
    }

    private void AddPerson()
    {
        NavigationManager.NavigateTo("/AddPerson");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
