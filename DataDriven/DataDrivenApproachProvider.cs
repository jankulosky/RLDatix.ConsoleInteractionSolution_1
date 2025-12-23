using RLDatix.ConsoleInteractionSolution_1.Helpers;

namespace RLDatix.ConsoleInteractionSolution_1.DataDriven
{
    public class DataDrivenApproachProvider
    {
        public void PlaySong()
        {
            List<Animal> animals =
                [
                    new("cow", "moo"),
                    new("duck", "quack"),
                    new("pig", "oink"),
                    new("sheep", "baa"),
                    new("dog", "woof")
                ];

            foreach (var animal in animals)
            {
                SongVerseHelper.PrintSongVerse(animal.Type, animal.Sound);
            }
        }
    }
}
