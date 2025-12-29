namespace RLDatix.ConsoleInteractionSolution_1.Polymorphism
{
    public abstract class Animal
    {
        public abstract string Type { get; }

        public abstract string Sound { get; }

        public virtual void Sing()
        {
            Console.WriteLine("Old MacDonald Had a Farm");
        }
    }
}
