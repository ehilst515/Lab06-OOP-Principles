using OOP;
using Xunit;

namespace Animal.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Mamals_are_not_auto_marsupial_and_are_auto_swimmers()
        {
            //Arange and Act
            Mamal tiger = new Mamal();

            //Assert
            Assert.False(tiger.Marsupial);
            Assert.True(tiger.Swimmer);
        }

        [Fact]
        public void Kangeroo_is_an_Herbavor_and_Marsupial()
        {
            //Arange and Act
            Herbavor Kangeroo = new Herbavor();
            Kangeroo.Marsupial = true;


            string expectedFood = "I'll find some plants to eat!";
            Assert.Equal(expectedFood, Kangeroo.FoodSearch());
            Assert.True(Kangeroo.Marsupial);
            
        }
    }
}
