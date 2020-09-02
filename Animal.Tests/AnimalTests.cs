using OOP;
using Xunit;
using static OOP.Amphibian;

namespace Animal.Tests
{
    public class AnimalTests
    {

        [Fact]
        public void Kangaroo_has_correct_attributes()
        {
            //Arrange and Act
            Kangaroo kangaroo = new Kangaroo();

            //Assert
            string expectedFood = "I'll find some plants to eat!";
            Assert.Equal(expectedFood, kangaroo.FoodSearch());
            Assert.True(kangaroo.Marsupial);
            Assert.True(kangaroo.Swimmer);
            Assert.Equal("fight", kangaroo.FightOrFlight);
            Assert.Equal(8, kangaroo.SleepHours());
        }

        [Fact]
        public void BullFrog_has_correct_attributes()
        {
            //Arrange and Act
            BullFrog bullfrog = new BullFrog();

            //Assert
            string expectedFood = "I'm looking for bugs";
            Assert.Equal(expectedFood, bullfrog.FoodSearch());
            Assert.False(bullfrog.Scales);
            Assert.Equal(12, bullfrog.SleepHours());
        }

        [Fact]
        public void BaldEagle_has_correct_attributes()
        {
            //Arrange and Act
            BaldEagle baldeagle = new BaldEagle();

            //Assert 
            string expectedMovement = "I flap my wings and fly";
            Assert.Equal(expectedMovement, baldeagle.Movement());
            Assert.Equal(6, baldeagle.SleepHours());
            Assert.Equal("United States of America", baldeagle.Home());
            Assert.Equal(300, baldeagle.FlightDistance);
        }

        [Fact]
        public void Cobra_hissses_has_scales_and_lives_in_trees()
        {
            //Arrange and Act
            Cobra cobra = new Cobra();

            //Assert 
            Assert.Equal("hisss", cobra.Sounds());
            Assert.True(cobra.Scales);
            Assert.Equal("I live in the trees", cobra.Home());
        }

        [Fact]
        public void Emu_lives_in_down_under_and_is_flightless()
        {
            //Arrange and Act
            Emu emu = new Emu();

            //Assert 
            Assert.Equal("The great down under", emu.Home());
            Assert.Equal("I might flap my wings, but I'll never fly", emu.Movement());
        }

        [Fact]
        public void Bear_swims_and_is_an_animal()
        {
            //Arrange and act
            Bear bear = new Bear();

            //Assert
            Assert.Equal(300, bear.SwimDistance);
            Assert.Equal("I can swim!", bear.Swim());
            Assert.Equal("I'm an animal", bear.Statement());
        }

        [Fact]
        public void Bat_swims_and_flies()
        {
            //Arrange and act
            Bat bat = new Bat();

            //Assert
            Assert.Equal(500, bat.FlightDistance);
            Assert.Equal(60, bat.FlightSpeed);
            Assert.Equal(10, bat.SwimDistance);
            Assert.Equal(2, bat.SwimSpeed);
            Assert.Equal("I can kind of swim!", bat.Swim());
        }
    }
}
