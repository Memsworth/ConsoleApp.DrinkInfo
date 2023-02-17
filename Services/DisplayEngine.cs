using ConsoleTableExt;

public class DisplayService
{
    public void DisplayTable<T>(List<T>? dataContent, string tableName) where T : class
    {
        if (dataContent is null)
        {
            Console.WriteLine($"DataSet is empty");
        }
        else
        {
            ConsoleTableBuilder.From(dataContent).WithColumn(tableName).ExportAndWriteLine();
        }
    }
}