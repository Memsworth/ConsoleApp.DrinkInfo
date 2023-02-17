namespace Drinks;

public static class Helper
{
    public static string PromptValidString(string message, string validityType)
    {
        Console.Write($"{message}: ");
        var input = Console.ReadLine();

        switch (validityType)
        {
            case "stringValidity":
                while (!Validator.IsStringValid(input!))
                {
                    Console.WriteLine("Invalid Command");
                    input = Console.ReadLine();
                }
                break;
            case "IdValidity":
                while (!Validator.IsIdValid(input!))
                {
                    Console.WriteLine("Invalid Command");
                    input = Console.ReadLine();
                }
                break;
        }

        return input!;
    }
}