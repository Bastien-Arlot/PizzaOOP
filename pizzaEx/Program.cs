using System.Collections.Generic;
using System;

namespace pizzaEx
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Pizza> pizzas =
                new List<Pizza>()
                {
                    new Pizza("Bolo", 11.5, false),
                    new Pizza("Saumon", 13, true),
                    new Pizza("Tartiflette", 15, false)
                };

            Pizza a = new Pizza("4 fromages", 11.5, true);
            a.Show();
            pizzas.Add(a);

            foreach (var pizza in pizzas)
            {
                pizza.Show();
            }
        }
    }
}