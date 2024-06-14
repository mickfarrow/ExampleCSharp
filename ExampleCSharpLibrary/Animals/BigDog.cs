namespace ExampleCSharpLibrary.Animals
{
    public class BigDog : Animal, IAnimal
    {
        public BigDog(string animalName) : base(animalName)
        {
        }

        public string MakeANoise()
        {
            return AnimalName + " says Woof";
        }
    }
}