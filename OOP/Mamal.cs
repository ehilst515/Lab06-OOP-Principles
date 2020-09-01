using System;
using System.Collections.Generic;

namespace OOP
{
    public abstract class Mamal : Animal
    {
        public override int SleepHours()
        {
            return 8;
        }

        public virtual bool Marsupial => false;

        public bool Swimmer => true;

        public override string FightOrFlight => "fight";
        public override string SleepType => "dinural";
        public override string FoodSearch()
        {
            return "I'm hungry. I'll search for food.";
        }
    }

    public class Carnivor: Mamal
    {
        public override string FoodSearch()
        {
            base.FoodSearch();
            return "I'll hunt for an animal to eat!";
        }

    }

    public class Herbavor : Mamal
    {
        public override string FoodSearch()
        {
            base.FoodSearch();
            return "I'll find some plants to eat!";
        }
    }
    
    public class Kangaroo : Herbavor
    {
        public override bool Marsupial => true;
    }

    public class Bat : Mamal, IFly, ISwim
    {
        public int FlightDistance => 500;

        public int FlightSpeed => 60;

        public int SwimDistance => 10;

        public int SwimSpeed => 2;

        public string Swim()
        {
            return "I can kind of swim!";
        }
    }

    public class Bear : Mamal, ISwim
    {
        public int SwimDistance => 300;

        public int SwimSpeed => 50;

        public string Swim()
        {
            return "I can swim!";
        }
    }
}
