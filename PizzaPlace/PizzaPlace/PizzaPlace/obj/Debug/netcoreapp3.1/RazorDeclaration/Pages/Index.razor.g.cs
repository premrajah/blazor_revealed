#pragma checksum "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66732a4681ad2ac7fe3ad17fd45e6cc3e971d119"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#line 108 "C:\_programming\blazor\blazor_revealed\PizzaPlace\PizzaPlace\PizzaPlace\Pages\Index.razor"
       
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