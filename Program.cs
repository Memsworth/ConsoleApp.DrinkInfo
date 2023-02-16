// See https://aka.ms/new-console-template for more information
using System.Text.Json;

using HttpClient client = new HttpClient
{
    BaseAddress = new Uri("https://www.thecocktaildb.com/api/json/v1/1/")
};
client.DefaultRequestHeaders.Accept.Clear();
await GetData(client);





static async Task GetData(HttpClient client)
{
    await using Stream stream = await client.GetStreamAsync("list.php?c=list");

    var data = await JsonSerializer.DeserializeAsync<RootObject>(stream);

    var categories = data.drinks;

    foreach (var item in categories)
    {
        Console.WriteLine(item.strCategory.ToString());
    }

}


public class RootObject
{
    public List<Drinks> drinks { get; set; }
}

public class Drinks
{ 
    public string strCategory { get; set; }
}



