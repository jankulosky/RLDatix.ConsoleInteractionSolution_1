using RLDatix.ConsoleInteractionSolution_1.Helpers;

namespace RLDatix.ConsoleInteractionSolution_1.Polymorphism
{
    public abstract class Animal
    {
        public abstract string Type { get; }
        public abstract string Sound { get; }

        public void Sing()
        {
            SongVerseHelper.PrintSongVerse(Type, Sound);
        }
    }
}
