namespace Drinks.Services;

public class UserService
{
    private DisplayService displayService = new();
    private DrinkService DrinkService = new();
    
    public async Task<string> GetCategoryInput()
    {
        var categories = await DrinkService.GetCategories();
        displayService.DisplayTable(categories?.drinks, "Categories");
        var input = Helper.PromptValidString("Choose a valid Category", "stringValidity");

        while (true)
        {
            if (categories != null && categories.drinks.Any(x=> x.strCategory == input))
                break;
            
            input = Helper.PromptValidString("Choose a valid Category", "stringValidity");
        }
        
        return input;
    }

    public async Task<string> GetDrinkInput(string category)
    {
        var drinks = await DrinkService.GetDrinksByCategory(category);
        displayService.DisplayTable(drinks?.drinks, "Categories");
        var input = Helper.PromptValidString("Choose a valid drink", "IdValidity");
        
        while (true)
        {
            if (drinks != null && drinks.drinks.Any(x=> x.idDrink == input))
                break;
            
            input = Helper.PromptValidString("Choose a valid drink", "IdValidity");
        }
        
        return input;
    }


    public async Task GetDrinkDetail(string drinkId)
    {
        var drinkDetail = await DrinkService.GetDrinkDetail(drinkId);
        displayService.DisplayTable(drinkDetail?.DrinkDetails, "DrinkInfo");
    }
}