#pragma checksum "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a07689ada1911c634f5ceb4f8a62c0a33a1b143"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using TodoProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\_Imports.razor"
using TodoProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Todos</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Filter by User Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                                                        arg => FilterByUserId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\r\n    Filter by completed status:\r\n    ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control selectpicker");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                                                           (arg) => FilterByCompletedStatus(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width:100px");
            __builder.OpenElement(14, "option");
            __builder.AddContent(15, "Both");
            __builder.CloseElement();
            __builder.AddContent(16, " ");
            __builder.OpenElement(17, "option");
            __builder.AddContent(18, "False");
            __builder.CloseElement();
            __builder.AddContent(19, " ");
            __builder.OpenElement(20, "option");
            __builder.AddContent(21, "True");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
 if (todosToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p><em>Loading...</em></p>");
#nullable restore
#line 19 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
}
else if (!todosToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p><em>No ToDo items exist. Please add some.</em></p>");
#nullable restore
#line 25 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.AddMarkupContent(26, "<thead><tr><th>User ID</th> <th>Todo ID</th> <th>Title</th> <th>Completed?</th><th>Remove</th> <th>Edit</th></tr></thead>\r\n        ");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 35 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
         foreach (var item in todosToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 38 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                     item.UserID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 39 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                     item.TodoID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 40 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                     item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "checkbox");
            __builder.AddAttribute(41, "checked", 
#nullable restore
#line 42 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                                                    item.IsCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                                                                                  (arg) => CompletedChange(arg, item)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                                        () => RemoveTodo(item.TodoID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
                                        () => Edit(item.TodoID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\kaspe\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\Assignments\Session04\TodoProject\Pages\Todos.razor"
       

    private IList<Todo> todosToShow;
    private IList<Todo> allTodos;
    private int? filterById;
    private bool? filterByIsCompleted;

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByCompletedStatus(ChangeEventArgs args)
    {
        filterByIsCompleted = null;
        try
        {
            filterByIsCompleted = bool.Parse(args.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        todosToShow = allTodos.Where(t => (filterById != null && t.UserID == filterById || filterById == null) && (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)).ToList();
    }


    protected override async Task OnInitializedAsync()
    {
        allTodos = TodoData.GetTodos();
        todosToShow = allTodos;
    }

    private void RemoveTodo(int todoId)
    {
        Todo todoToRemove = allTodos.First(t => t.TodoID == todoId);
        TodoData.RemoveTodo(todoId);
        allTodos.Remove(todoToRemove);
        todosToShow.Remove(todoToRemove);
    }

    private void CompletedChange(ChangeEventArgs evt, Todo todo)
    {
        todo.IsCompleted = (bool) evt.Value;
        TodoData.Update(todo);
    }

    private void Edit(int id)
    {
        NavMgr.NavigateTo($"Edit/{id}");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoData TodoData { get; set; }
    }
}
#pragma warning restore 1591
