using System;

namespace Lab_9
{
    class Program
    {
        private static void Main(string[] args)
        {
            Dish dish1 = new Dish(54, 65, 76);
            dish1.Print();

            Dish dish2 = new Dish(dish1); // Использование конструктора копирования
            dish2.Print();

            Console.WriteLine($"Общее количество созданных объектов: {Dish.GetCount()}");

            double calories = dish1.Calories();
            Console.WriteLine($"Калорийность рассчитанная статическим методом: {calories} ккал");
        }
    } 
}