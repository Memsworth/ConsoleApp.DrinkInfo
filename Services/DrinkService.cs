using System.Text.Json;
using System.Web;
using Model;

namespace Drinks.Services;

public class DrinkService
{
    
    public async Task<Model.DrinkDetailObject?> GetDrinkDetail(string id) =>
        await CallApi<DrinkDetailObject>($"lookup.php?i={id}");
    
    public async Task<Model.Drinks?> GetDrinksByCategory(string category) =>
        await CallApi<Model.Drinks>($"filter.php?c={HttpUtility.UrlEncode(category)}");
    
    public async Task<Categories?> GetCategories() => await CallApi<Categories>("list.php?c=list");

    private async Task<T?> CallApi<T>(string requestString) 
    {
        var response = await Client.ApiClient.GetStreamAsync(requestString);

        var data =  await JsonSerializer.DeserializeAsync<T>(response);
        return data;
    }
}