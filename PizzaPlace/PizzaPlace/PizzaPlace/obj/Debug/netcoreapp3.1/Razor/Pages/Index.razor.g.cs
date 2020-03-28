#pragma checksum "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "849ecea676c137baad119918a484a139c6337a75"
// <auto-generated/>
#pragma warning disable 1591
namespace PizzaPlace.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using PizzaPlace;

#line default
#line hidden
#line 9 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\_Imports.razor"
using PizzaPlace.Shared;

#line default
#line hidden
#line 2 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
using static System.Console;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Our Selection of Pizzas</h1>\r\n");
#line 6 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
 foreach(var pizza in State.Menu.Pizzas)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddContent(8, 
#line 10 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
             pizza.Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddContent(14, 
#line 14 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
             pizza.Price

#line default
#line hidden
            );
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", 
#line 18 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                       SpicinessImage(pizza.Spiciness)

#line default
#line hidden
            );
            __builder.AddAttribute(22, "alt", 
#line 18 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                                                              pizza.Spiciness

#line default
#line hidden
            );
            __builder.AddAttribute(23, "style", "max-height: 3rem; object-fit: contain;");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-success");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 22 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                                                        () => AddToBasket(pizza)

#line default
#line hidden
            ));
            __builder.AddContent(32, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#line 25 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n");
#line 29 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
 if(State.Basket.Orders.Any())
{

#line default
#line hidden
            __builder.AddContent(37, "    ");
            __builder.AddMarkupContent(38, "<h1>You current order</h1>\r\n");
#line 32 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
     foreach(var(pizza, pos) in State.Basket.Orders.Select((id, pos) => (State.Menu.GetPizza(id), pos)))
    {

#line default
#line hidden
            __builder.AddContent(39, "        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row mb-1");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddContent(46, 
#line 36 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                 pizza.Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col");
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.AddContent(52, 
#line 39 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                 pizza.Price

#line default
#line hidden
            );
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col");
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-danger");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                                                           () => RemoveFromBasket(pos)

#line default
#line hidden
            ));
            __builder.AddContent(61, "Remove");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#line 46 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
    }

#line default
#line hidden
            __builder.AddContent(65, "    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row mt-1");
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.AddMarkupContent(69, "<div class=\"col\">Total: </div>\r\n        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col");
            __builder.AddContent(72, 
#line 50 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                          State.TotalPrice

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        <div class=\"col\"></div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#line 53 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(75, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(76, "<h1>Please enter your details below</h1>\r\n");
            __builder.OpenElement(77, "fieldset");
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.OpenElement(79, "p");
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.AddMarkupContent(81, "<label for=\"name\">Name: </label>\r\n        ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "id", "name");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 61 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                                 State.Basket.Customer.Name

#line default
#line hidden
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => State.Basket.Customer.Name = __value, State.Basket.Customer.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#line 62 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
         if (State.Basket.Customer.GetErrors(nameof(Customer.Name)).Any())
        {

#line default
#line hidden
            __builder.AddContent(87, "            ");
            __builder.OpenElement(88, "ul");
            __builder.AddAttribute(89, "class", "validation-error");
            __builder.AddMarkupContent(90, "\r\n");
#line 65 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                 foreach(string error in State.Basket.Customer.GetErrors(nameof(Customer.Name)))
                {

#line default
#line hidden
            __builder.AddContent(91, "                    ");
            __builder.OpenElement(92, "li");
            __builder.AddContent(93, 
#line 67 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                         error

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#line 68 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                }

#line default
#line hidden
            __builder.AddContent(95, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#line 70 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
        }

#line default
#line hidden
            __builder.AddContent(97, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n    ");
            __builder.OpenElement(99, "p");
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.AddMarkupContent(101, "<label for=\"street\">Street:</label>\r\n        ");
            __builder.OpenElement(102, "input");
            __builder.AddAttribute(103, "id", "street");
            __builder.AddAttribute(104, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 75 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                                   State.Basket.Customer.Street

#line default
#line hidden
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => State.Basket.Customer.Street = __value, State.Basket.Customer.Street));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.OpenElement(108, "p");
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.AddMarkupContent(110, "<label for=\"city\">City:</label>\r\n        ");
            __builder.OpenElement(111, "input");
            __builder.AddAttribute(112, "id", "city");
            __builder.AddAttribute(113, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 79 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                                 State.Basket.Customer.City

#line default
#line hidden
            ));
            __builder.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => State.Basket.Customer.City = __value, State.Basket.Customer.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n    ");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "class", "btn btn-primary");
            __builder.AddAttribute(119, "disabled", 
#line 82 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                                               State.Basket.Customer.HasErrors

#line default
#line hidden
            );
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 82 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
                                                                                           PlaceOrder

#line default
#line hidden
            ));
            __builder.AddContent(121, "Checkout");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 90 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
       
    private State State { get; } = new State()
    {
        Menu = new Menu
        {
            Pizzas = new List<Pizza>
            {
                new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy ),
new Pizza(2, "Margarita", 7.99M, Spiciness.None ),
new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot )
            }
        }
    };

    private string SpicinessImage(Spiciness spiciness) => $"images/{spiciness.ToString().ToLower()}.png";

    private void AddToBasket(Pizza pizza)
    {
        WriteLine($"Added Pizza {pizza.Name}");
        State.Basket.Add(pizza.Id);

    }

    public void RemoveFromBasket(int pos)
    {
        Console.WriteLine($"Removing pizza at pos {pos}");
        State.Basket.RemoveAt(pos);
    }

    private void PlaceOrder()
    {
        Console.WriteLine("Placing Order");
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
