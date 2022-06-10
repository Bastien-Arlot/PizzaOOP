using System.Collections.Generic;
using System;
using System.Linq;

namespace pizzaEx
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Pizza> pizzas =
                new List<Pizza>()
                {
                    new Pizza("bolo", 9.5, false, new List<string>(){"viande", "fromage"}),
                    new Pizza("SaUmOn", 13, true, new List<string>(){"saumon","créme"}),
                    new Pizza("tArTiFlette", 15, false, new List<string>(){"pdt", "creme"})
                };

            Pizza a = new Pizza("4 fromages", 9.5, true, new List<string>(){"fromages"});
            // a.Show();
            pizzas.Add(a);

            // foreach (var pizza in pizzas)
            // {
            //     pizza.Show();
            // }

            List<Pizza> orderedPizza = pizzas.OrderBy(pizza => pizza.Price).ToList();
            // foreach (var VARIABLE in orderedPizza)
            // {
            //     VARIABLE.Show();
            // }

            List<Pizza> orderedDescendingPizza = orderedPizza.OrderByDescending(pizza => pizza.Price).ToList();
            // foreach (var VARIABLE in orderedDescendingPizza)
            // {
            //     VARIABLE.Show();
            // } 
            
            orderedPizza[0].Show();
            orderedDescendingPizza[0].Show();
        }
    }
}