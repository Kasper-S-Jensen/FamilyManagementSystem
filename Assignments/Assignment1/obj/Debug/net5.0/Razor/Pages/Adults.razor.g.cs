#pragma checksum "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e266422672c9300b6d0ec1b22f889f446370d25"
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
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Filter by name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                                   arg => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:200px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 20 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>No adults exist. Please add some.</em></p>");
#nullable restore
#line 26 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-hover table-striped thead-dark");
            __builder.AddMarkupContent(11, "<thead><tr><th>Person ID</th> <th>Firstname</th> <th>Lastname</th> <th>Haircolor</th><th>Eyecolor</th><th>Age</th> <th>Weight</th><th>Height</th><th>Sex</th><th>Job</th><th>Salary</th></tr></thead>\r\n        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 36 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
         foreach (var adult in adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 39 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 40 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 41 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 42 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 43 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 44 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 45 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 46 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 47 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.AddMarkupContent(41, "<td><button data-toggle=\"collapse\" data-target=\"#demo\">Collapsible</button></td>\r\n\r\n\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 54 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                     adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                 ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 55 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                      adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                                        () => RemoveAdult(adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
                    () => AddPerson()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddContent(55, " Add adult ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.AddMarkupContent(57, "<div><div id=\"demo\" class=\"collapse\">Lorem ipsum dolor text....</div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Assignments\Assignment1\Pages\Adults.razor"
       

    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;
    private string? filterByString;


    protected override async Task OnInitializedAsync()
    {
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
        adultsToShow = allAdults.Where(A => (filterByString != null && A.FirstName.ToLower().StartsWith(filterByString.ToLower()) || A.LastName.ToLower().StartsWith(filterByString.ToLower()) || filterByString == null)).ToList();
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