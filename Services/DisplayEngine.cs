using ConsoleTableExt;

public class DisplayService
{
    public void DisplayTable<T>(List<T>? dataContent, string tableName) where T : class
    {
        ConsoleTableBuilder.From(dataContent).ExportAndWriteLine();
    }
}