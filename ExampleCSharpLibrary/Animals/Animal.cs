namespace ExampleCSharpLibrary.Animals
{
    public abstract class Animal
    {
        private readonly string _animalName;
        
        public Animal(string animalName)
        {
            _animalName = animalName;
        }

        public string AnimalName => _animalName;
    }
}
