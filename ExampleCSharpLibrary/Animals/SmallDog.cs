namespace ExampleCSharpLibrary.Animals
{
    public class SmallDog : Animal, IAnimal
    {
        public SmallDog(string animalName) : base(animalName)
        {
        }

        public string MakeANoise()
        {
            return AnimalName +  " says Yap";
        }
    }
}