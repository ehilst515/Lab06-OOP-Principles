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

    public class Bat : Mamal, IFly
    {
        public int FlightDistance => 500;

        public int FlightSpeed => 60;
    }

    //public class Bear : Mamal, ISwim
    //{

    //}
}
