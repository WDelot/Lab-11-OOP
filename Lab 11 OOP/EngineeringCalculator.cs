using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Lab_11_OOP
{
    public class EngineeringCalculator : ICloneable, IComparable
    {

        public string Model { get; set; }
        public double Price { get; set; }

        public EngineeringCalculator(string model, double price)
        {
            Model = model;
            Price = price;
        }

        public object Clone()
        {
            return new EngineeringCalculator(this.Model, this.Price);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            EngineeringCalculator otherCalculator = obj as EngineeringCalculator;
            if (otherCalculator == null)
                throw new ArgumentException("Об'єкт для порівняння не є EngineeringCalculator.");

            return this.Price.CompareTo(otherCalculator.Price);
        }

        public override string ToString()
        {
            return $"Модель: {Model}, Ціна: {Price:C}";
        }
    }
}