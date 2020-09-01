namespace OOP
{
    public abstract class Amphibian : Animal
    {
        public virtual bool Scales { get; set; }

        public override string SleepType => "noctornal";

        public override int SleepHours()
        {
            return 12;
        }
        public override string FightOrFlight => "flight";

        public override string FoodSearch()
        {
            return "I'm looking for bugs";
        }

        public class Freshwater : Amphibian
        {
            public override string Home()
            {
                return "I live in freshwater";
            }
        }

        public class Arboreal : Amphibian
        {
            public override string Home()
            {
                return "I live in the trees";
            }
        }

        public class TreeFrog : Arboreal
        {
            public override string Sounds()
            {
                return "Ribbit ribbit";
            }

            public override bool Scales => false;
        }

        public class BullFrog : Arboreal
        {
            public override string Sounds()
            {
                return "Jug-o-rum";
            }

        }

        public class Cobra : Arboreal
        {
            public override string Sounds()
            {
                return "hisss";
            }

            public override bool Scales => true;
        }
    }
}
