using _07_Objektorientierung;

namespace TestTierheim
{
    public class Tests : PageTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddAnimal_AddOneCatAndOneDog_ReturnsTwoAnimals()
        {
            var myTierheim = new Tierheim();
            myTierheim.AddAnimal(new Cat("Kitty", "white", new DateTime(2023, 07, 13)));
            myTierheim.AddAnimal(new Dog("Lessi", "grey", new DateTime(2023, 07, 13)));
            Assert.IsTrue(myTierheim.NumberOfAnimals == 2);
        }
    }
}
