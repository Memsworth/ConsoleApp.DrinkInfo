namespace Drinks;

public class Validator
{
    public static bool IsStringValid(string stringInput)
    {
        if (string.IsNullOrEmpty(stringInput)) return false;
        if (stringInput.Any(c => !char.IsLetter(c) && c != '/' && c != ' ')) return false;
        
        return true;
    }

    public static bool IsIdValid(string stringInput)
    {
        if (string.IsNullOrEmpty(stringInput)) return false;
        if (stringInput.Any(c => !char.IsDigit(c))) return false;
        return true;
    }
}