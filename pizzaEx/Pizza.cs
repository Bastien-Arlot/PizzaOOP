using System;
using System.Collections.Generic;
using System.Linq;

namespace pizzaEx
{
    public class Pizza
    {
        //Fields/Members
        private string name;
        private double price;
        private bool isVege;
        private List<string> ingredients;

        //Properties
        public string Name { get; private set; }
        public double Price { get; private set; }

        public bool IsVege { get; private set; }

        public List<string> Ingredients { get; private set; }

        //Constructor
        public Pizza(string name, double price, bool isVege, List<string> ingredients)
        {
            this.Name = name;
            this.Price = price;
            this.IsVege = isVege;
            this.Ingredients = ingredients;
        }

        public void Show()
        {
            string vege = IsVege ? "(V) " : "";

            string nameFin = FormattingFirstLetter(Name);
            List<string> formatedIng = FormatingIng(Ingredients);

            Console.WriteLine($"{nameFin} {vege}- {Price} euros");
            Console.WriteLine($"{String.Join(", ", formatedIng)}");
            Console.WriteLine("\n");
        }

        private static List<string> FormatingIng(List<string> ingToFormat)
        {
            // List<string> formatedIng = new List<string>();
            // foreach (var ing in ingToFormat)
            // {
            //     formatedIng.Add(FormattingFirstLetter(ing));
            // }

            var formatedIng = ingToFormat.Select(i => FormattingFirstLetter(i)).ToList();

            return formatedIng;
        }

        private static string FormattingFirstLetter(string nameToFormat)
        {
            if (string.IsNullOrEmpty(nameToFormat))
            {
                return nameToFormat;
            }

            string nameMin = nameToFormat.ToLower();
            string nameMaj = nameToFormat.ToUpper();
            string result = nameMaj[0] + nameMin.Substring(1);
            return result;
        }
    }
}