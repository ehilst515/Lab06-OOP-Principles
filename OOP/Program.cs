using System;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running");
        }

    }

    public abstract class Animal
    {
        public abstract string FightOrFlight { get; }
        public abstract string SleepType { get; }


        public abstract string FoodSearch();
        public abstract int SleepHours();

        public virtual string Home()
        {
            return "I have a place to live";
        }
        public virtual string Sounds()
        {
            return "Animal noises";
        }
        public virtual string Movement()
        {
            return "I can get around";
        }

    }
}
