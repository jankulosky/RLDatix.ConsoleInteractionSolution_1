namespace RLDatix.ConsoleInteractionSolution_1.Polymorphism
{
    public class Sheep : Animal
    {
        public override string Type => "sheep";

        public override string Sound => "baa";

        public override void Sing()
        {
            Console.WriteLine("Old MacDonald had a farm, E I E I O.");
            Console.WriteLine($"And on his farm he had a {Type}, E I E I O.");
            Console.WriteLine($"With a {Sound.ToUpper()} {Sound.ToUpper()} here and a {Sound.ToUpper()} {Sound.ToUpper()} there,");
            Console.WriteLine($"Here a {Sound.ToUpper()}, there a {Sound.ToUpper()}, everywhere a {Sound.ToUpper()} {Sound.ToUpper()}.");
            Console.WriteLine("Old MacDonald had a farm, E I E I O.\n");
        }
    }
}
