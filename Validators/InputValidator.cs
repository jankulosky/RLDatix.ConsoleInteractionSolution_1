using RLDatix.ConsoleInteractionSolution_1.Exceptions;

namespace RLDatix.ConsoleInteractionSolution_1.Validators
{
    public class InputValidator
    {
        public static void ValidateMenuOption(string? input)
        {
            if (string.IsNullOrWhiteSpace(input) || !"123".Contains(input))
                throw new InputException("Invalid menu option.");
        }
    }
}
