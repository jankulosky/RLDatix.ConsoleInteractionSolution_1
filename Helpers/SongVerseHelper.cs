namespace RLDatix.ConsoleInteractionSolution_1.Helpers
{
    public class SongVerseHelper
    {
        public static void PrintSongVerse(string type, string sound)
        {
            Console.WriteLine("Old MacDonald had a farm, E I E I O.");
            Console.WriteLine($"And on his farm he had a {type}, E I E I O.");
            Console.WriteLine($"With a {sound} {sound} here and a {sound} {sound} there,");
            Console.WriteLine($"Here a {sound}, there a {sound}, everywhere a {sound} {sound}.");
            Console.WriteLine("Old MacDonald had a farm, E I E I O.\n");
        }
    }
}
