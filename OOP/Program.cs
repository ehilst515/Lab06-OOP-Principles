using System;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    public abstract class Animal
    {
        public int Mass { get; set; }
        public string FoodType { get; set; }
        public string SleepType { get; set; }

        public abstract string FoodSearch();
        //public abstract string Sleep();
        //public abstract string Sounds();

    }
}
