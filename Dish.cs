using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab_9
{
    internal class Dish
    {
        public double proteins;
        public double fats;
        public double carbohydrations;
        public double calories;
        public double Calories()
        {
           double result = 4 * proteins + 9 * fats + 4 * carbohydrations;
            return result;
        }
        public Dish(double proteins, double fats, double carbohydrations)
        {
            this.proteins = proteins;
            this.fats = fats;
            this.carbohydrations = carbohydrations;

            calories = Calories();
        }
        public Dish()
        {
            calories = 0; 
        }
        public void Print()
        {
            Console.WriteLine($"при {proteins} белка, {fats} жиров, {carbohydrations} углеводах каллорийность равна: ");
            Console.Write(calories);
        }
    }
}
