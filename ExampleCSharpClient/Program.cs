using ExampleCSharpLibrary.Animals;

namespace ExampleCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bigDog = new BigDog("Rover");
            var smallDog = new SmallDog("Monty");
            var cat = new Cat("Tiddles");

            Console.WriteLine(bigDog.MakeANoise());
            Console.WriteLine(smallDog.MakeANoise());
            Console.WriteLine(cat.MakeANoise());
        }
    }
}