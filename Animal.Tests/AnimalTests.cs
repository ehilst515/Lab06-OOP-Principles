using OOP;
using Xunit;
using static OOP.Amphibian;

namespace Animal.Tests
{
    public class AnimalTests
    {

        [Fact]
        public void Kangeroo_has_correct_attributes()
        {
            //Arange and Act
            Kangeroo kangeroo = new Kangeroo();

            //Assert
            string expectedFood = "I'll find some plants to eat!";
            Assert.Equal(expectedFood, kangeroo.FoodSearch());
            Assert.True(kangeroo.Marsupial);
            Assert.True(kangeroo.Swimmer);
            Assert.Equal("fight", kangeroo.FightOrFlight);
            Assert.Equal(8, kangeroo.SleepHours());
        }

        [Fact]
        public void BullFrog_has_correct_attributes()
        {
            //Arange and Act
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
            //Arange and Act
            BaldEagle baldeagle = new BaldEagle();

            //Assert 
            string expectedMovement = "I flap my wings and fly";
            Assert.Equal(expectedMovement, baldeagle.Movement());
            Assert.Equal(6, baldeagle.SleepHours());
            Assert.Equal("United States of America", baldeagle.Home());
        }

        [Fact]
        public void Cobra_hissses_has_scales_and_lives_in_trees()
        {
            //Arange and Act
            Cobra cobra = new Cobra();

            //Assert 
            Assert.Equal("hisss", cobra.Sounds());
            Assert.True(cobra.Scales);
            Assert.Equal("I live in the trees", cobra.Home());
        }

        [Fact]
        public void Emu_lives_in_down_under_and_is_flightless()
        {
            //Arange and Act
            Emu emu = new Emu();

            //Assert 
            Assert.Equal("The great down under", emu.Home());
            Assert.Equal("I might flap my wings, but I'll never fly", emu.Movement());
        }

    }
}
