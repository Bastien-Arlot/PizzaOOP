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
                    new Pizza("tArTiFlette", 15, false, new List<string>(){"pdt", "creme"}),
                    // new PizzaCustom()
                };

            Pizza a = new Pizza("4 fromages", 9.5, true, new List<string>(){"fromages"});
            // a.Show();
            pizzas.Add(a);

            double maxPrize = 0;
            string nameMaxPrize = "";

            foreach (var VARIABLE in pizzas)
            {
                if (VARIABLE.Price > maxPrize)
                {
                     maxPrize = VARIABLE.Price;
                     nameMaxPrize = VARIABLE.Name;

                }
            }
            
            Console.WriteLine($"La pizza la plus chère est la {nameMaxPrize} qui est à {maxPrize}");

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
            
            // orderedPizza[0].Show();
            // orderedDescendingPizza[0].Show();

            List<Pizza> vegetarianPizzas = pizzas.Where(pizza => pizza.IsVege).ToList();

            // foreach (var VARIABLE in vegetarianPizzas)
            // {
            //     VARIABLE.Show();
            //     
            // }

            List<Pizza> pizzaWithFromage = pizzas.Where(pizza => pizza.Ingredients.Contains("fromages") || pizza.Ingredients.Contains("fromage")).ToList();

            // foreach (var VARIABLE in pizzaWithFromage)
            // {
            //     VARIABLE.Show();
            // }
        }
    }
}