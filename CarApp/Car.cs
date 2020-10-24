using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    //public enum TypeEnum {Car, SuperCar };
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public int ConstructionYear { get; set; }
        public string Color { get; set; }

        

        public Car (string type, string brand, string name, int constructionYear, string color)
        {
            this.Model = type;
            this.Brand = brand;
            this.Name = name;
            this.ConstructionYear = constructionYear;
            this.Color = color;
        }

        public virtual void Drive()
        {
            Console.WriteLine("I am driving");

        }

        override public string ToString()
        {
            return "Type: " + Model + " - Marke: " + Brand + " - Variante: " + Name + " - Baujahr: " + ConstructionYear + " - Farbe: " + Color + "\n";
        }
    }
}
