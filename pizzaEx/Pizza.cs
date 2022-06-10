using System;

namespace pizzaEx
{
    public class Pizza
    {
        //Fields/Members
        private string name;
        private double price;
        private bool isVege;
        
        //Properties
        public string Name { get; private set; }
        public double Price { get; private set; }
        
        public bool IsVege { get; private set; }
        
        //Constructor
        public Pizza(string name, double price, bool isVege)
        {
            this.Name = name;
            this.Price = price;
            this.IsVege = isVege;
        }

        public void Show()
        {
            string vege = IsVege ? "(V) " : "";
            string nameMin = Name.ToLower();
            string nameMaj = Name.ToUpper();
            string nameFin = nameMaj[0] + nameMin.Substring(1);
         
            Console.WriteLine($"{nameFin} {vege}- {Price} euros");
        }
    }
}