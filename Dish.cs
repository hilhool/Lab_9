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
        private double proteins;
        private double fats;
        private double carbohydrations;
        private double calories;
        private static int count = 0;

#region свойства
        public double Proteins
        {
            get
            {
                return proteins;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Белки не могут быть отрицательными");
                else
                    proteins = value;
            }
        }
        public double Fats
        {
            get
            {
                return fats;
            }
            set
            {
                if (value < 0)
                    throw new Exception("жиры не могут быть отрицательными");
                else
                    fats = value;
            }
        }
        public double Carbohydrations
        {
            get
            {
                return carbohydrations;
            }
            set
            {
                if (value < 0)
                    throw new Exception("углеводы не могут быть отрицательными");
                else
                    carbohydrations = value;
            }
        }
        public static int GetCount()
        {
            return count;
        }

        #endregion свойства

#region конструкторы
        public Dish(double proteins, double fats, double carbohydrations) //Конструктор с параметром 
        {
            this.proteins = proteins;
            this.fats = fats;
            this.carbohydrations = carbohydrations;

            calories = Calories();
            count++;
        }
        public Dish()  //Конструктор без параметра 
        {
            proteins = 0;
            fats = 0;
            carbohydrations = 0;

            calories = 0;
            count++;
        }
        public Dish(Dish defaultDish)  //Конструктор копирования 
        {
            this.proteins = defaultDish.proteins;
            this.fats = defaultDish.fats;
            this.carbohydrations = defaultDish.carbohydrations;

            calories = Calories();
            count++;
        }
        #endregion конструкторы

#region методы
        public double Calories()
        {
            double result = Math.Round(4 * proteins + 9 * fats + 4 * carbohydrations, 2);
            return result;
        }
        public static double Calories(Dish dish)
        {
            return Math.Round(4 * dish.proteins + 9 * dish.fats + 4 * dish.carbohydrations, 2);
        }
        public void Print()
        {
            Console.Write($"при {proteins} белка, {fats} жиров, {carbohydrations} углеводах каллорийность равна ");
            Console.WriteLine(calories);
        }
        #endregion методы
    }
}
