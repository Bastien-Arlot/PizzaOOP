using System;
using System.Collections.Generic;

namespace pizzaEx
{
    public class PizzaCustom : Pizza
    {
        public PizzaCustom() : base("Custom", 5, false, null)
        {
            this.Ingredients = new List<string>();


            while (true)
            {
                Console.Write("Rentrez un ingredient pour la pizza custom ENTER pour terminer");
                string ingredient = Console.ReadLine();

                if (string.IsNullOrEmpty(ingredient))
                {
                    break;
                }

                this.Ingredients.Add(ingredient);
            }
        }
    }
}