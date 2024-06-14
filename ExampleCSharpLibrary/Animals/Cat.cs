namespace ExampleCSharpLibrary.Animals
{
    public class Cat : Animal, IAnimal
    {
        public Cat(string animalName) : base(animalName)
        {
        }

        public string MakeANoise()
        {
            return AnimalName + " says Miaow";
        }
    }
}