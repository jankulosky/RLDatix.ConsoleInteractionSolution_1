using RLDatix.ConsoleInteractionSolution_1.Helpers;

namespace RLDatix.ConsoleInteractionSolution_1.Polymorphism
{
    public class PolymorphicApproachProvider
    {
        public void PlaySong()
        {
            List<Animal> animals =
                [
                    new Cow(),
                    new Duck(),
                    new Pig(),
                    new Sheep(),
                    new Dog()
                ];

            foreach (var animal in animals)
            {
                animal.Sing();
            }
        }
    }
}
