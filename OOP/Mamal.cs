using System;
namespace OOP
{
    public class Mamal : Animal
    {

        public virtual bool Marsupial { get; set; }

        public bool Swimmer => true;

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
    
    class Kangeroo : Herbavor
    {
        public override bool Marsupial => true;
    }
}
