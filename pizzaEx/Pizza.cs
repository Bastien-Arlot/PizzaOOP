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

            Console.WriteLine($"{nameFin} {vege}- {Price} euros");
            Console.WriteLine($"{String.Join(", ", Ingredients)}");
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