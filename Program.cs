using RLDatix.ConsoleInteractionSolution_1.DataDriven;
using RLDatix.ConsoleInteractionSolution_1.Exceptions;
using RLDatix.ConsoleInteractionSolution_1.Polymorphism;
using RLDatix.ConsoleInteractionSolution_1.Validators;

while (true)
{
    try
    {
        Console.WriteLine("=================================");
        Console.WriteLine(" Old MacDonald Had a Farm ");
        Console.WriteLine("=================================\n");
        Console.WriteLine("1. Play using Data-Driven approach");
        Console.WriteLine("2. Play using Polymorphism");
        Console.WriteLine("3. Exit\n");
        Console.Write("Choose option: \n");

        var input = Console.ReadLine();
        InputValidator.ValidateMenuOption(input);

        switch (input)
        {
            case "1":
                Console.WriteLine("Playing All Verses using a data-driven approach\n");
                new DataDrivenApproachProvider().PlaySong();
                break;

            case "2":
                Console.WriteLine("Playing All Verses using polymorphism\n");
                new PolymorphicApproachProvider().PlaySong();
                break;

            case "3":
                return;
        }
    }
    catch (InputException ex)
    {
        Console.WriteLine($"Input error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }

    Console.WriteLine("\nPress ENTER to continue...");
    Console.ReadLine();
    Console.Clear();
}