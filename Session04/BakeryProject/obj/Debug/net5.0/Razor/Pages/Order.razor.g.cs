#pragma checksum "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f13f544f8738981e60d357cb2276bad73a45458"
// <auto-generated/>
#pragma warning disable 1591
namespace BakeryProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using BakeryProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\_Imports.razor"
using BakeryProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
using BakeryProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
using BakeryProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Order")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/order/{Id:int}")]
    public partial class Order : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<ol id=\"orderProcess\"><li><span class=\"step-number\">1</span>Choose Item</li>\r\n    <li class=\"current\"><span class=\"step-number\">2</span>Details &amp; Submit</li>\r\n    <li><span class=\"step-number\">3</span>Receipt</li></ol>\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, "Place Your Order: ");
            __builder.AddContent(3, 
#nullable restore
#line 16 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                       Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                  shippingValidationModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                                                                HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-3");
                __builder2.OpenElement(14, "img");
                __builder2.AddAttribute(15, "src", "Images/Products/Thumbnails/" + (
#nullable restore
#line 21 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                  Product.ImageName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "class", "img-fluid img-thumbnail");
                __builder2.AddAttribute(17, "alt", "Image" + " of" + " " + (
#nullable restore
#line 21 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                                                                                    Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(23);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "ul");
                __builder2.AddAttribute(26, "class", "orderPageList");
                __builder2.AddAttribute(27, "data-role", "listview");
                __builder2.OpenElement(28, "li");
                __builder2.OpenElement(29, "div");
                __builder2.OpenElement(30, "p");
                __builder2.AddAttribute(31, "class", "description");
                __builder2.AddContent(32, 
#nullable restore
#line 29 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "li");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "\r\n                        Email address:<br>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                shippingValidationModel.OrderEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shippingValidationModel.OrderEmail = __value, shippingValidationModel.OrderEmail))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => shippingValidationModel.OrderEmail));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenElement(43, "li");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "\r\n                        Shipping adress:<br>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(47);
                __builder2.AddAttribute(48, "rows", "4");
                __builder2.AddAttribute(49, "class", "form-control form-control-sm");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                                                                  shippingValidationModel.OrderShipping

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shippingValidationModel.OrderShipping = __value, shippingValidationModel.OrderShipping))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => shippingValidationModel.OrderShipping));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.OpenElement(54, "li");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "\r\n                        Quantity:\r\n                        ");
                __Blazor.BakeryProject.Pages.Order.TypeInference.CreateInputNumber_0(__builder2, 58, 59, 
#nullable restore
#line 47 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                  shippingValidationModel.OrderQuantity

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shippingValidationModel.OrderQuantity = __value, shippingValidationModel.OrderQuantity)), 61, () => shippingValidationModel.OrderQuantity);
                __builder2.AddMarkupContent(62, "\r\n                        x\r\n                        ");
                __builder2.OpenElement(63, "span");
                __builder2.AddAttribute(64, "class", "order-calc");
                __builder2.AddAttribute(65, "id", "orderPrice");
                __builder2.AddContent(66, 
#nullable restore
#line 49 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                                  Product.Price.ToString("f")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                        =\r\n                        ");
                __builder2.OpenElement(68, "span");
                __builder2.AddAttribute(69, "class", "order-calc");
                __builder2.AddAttribute(70, "id", "orderTotal");
                __builder2.AddContent(71, 
#nullable restore
#line 51 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
                                                                   (shippingValidationModel.OrderQuantity * Product.Price).ToString("f")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                        <span asp-validation-for=\"OrderQuantity\"></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.AddMarkupContent(74, "<p class=\"actions\"><button class=\"btn btn-danger order-button\" type=\"submit\">Place Order</button></p>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Kasper\OneDrive - ViaUC\Diplomingenioer\3.sem\DNP\Solutions\DNP1\Session04\BakeryProject\Pages\Order.razor"
       

    [Parameter]
    public int Id { get; set; }

    public Product Product { get; set; }


    private ShippingValidationModel shippingValidationModel = new ShippingValidationModel();

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            Product = ProductsService.Products.First(p => p.Id == Id);
        }
    }

    private void HandleInvalidSubmit()
    {
        Console.WriteLine("Invalid");
    }

    private void HandleValidSubmit() {
        NavigationManager.NavigateTo("/ordersuccess");
    }


    private class ShippingValidationModel
    {
        [EmailAddress, Required, Display(Name = "Email Address")]
        public string OrderEmail { get; set; }

        [Required(ErrorMessage = "Please supply a shipping address"), Display(Name = "Shipping Address")]
        public string OrderShipping { get; set; }

        [Display(Name = "Quantity")]
        [Range(1, 10)]
        public int OrderQuantity { get; set; } = 1;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IproductsService ProductsService { get; set; }
    }
}
namespace __Blazor.BakeryProject.Pages.Order
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
