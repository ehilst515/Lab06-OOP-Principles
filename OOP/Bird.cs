namespace OOP
{
    public abstract class Bird : Animal
    {
        public override string SleepType => "dinural";

        public override int SleepHours()
        {
            return 6;
        }

        public override string FoodSearch()
        {
            return "I'm looking for food with a bird's eye view";
        }

        public override string FightOrFlight => "flight";
    }

    public abstract class Flight : Bird, IFly
    {
        public abstract int FlightDistance { get; }
        public abstract int FlightSpeed { get; }
        public override string Movement()
        {
            return "I flap my wings and fly";
        }
    }

    public class Flightless : Bird
    {
        public override string Movement()
        {
            return "I might flap my wings, but I'll never fly";
        }
    }


    public class Emu : Flightless
    {
        public override string Home()
        {
            return "The great down under";
        }
    }

    public class BaldEagle : Flight, IFly
    {
        public override int FlightDistance => 300;

        public override int FlightSpeed => 30;

        public override string Home()
        {
            return "United States of America";
        }
    }



}
