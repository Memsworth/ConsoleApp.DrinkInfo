using Drinks.Services;

UserService user = new();
Client.InitializeClient("https://www.thecocktaildb.com/api/json/v1/1/");
var item = await user.GetCategoryInput();
var item2 = await  user.GetDrinkInput(item);
await user.GetDrinkDetail(item2);