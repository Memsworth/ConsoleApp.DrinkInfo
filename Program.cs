using Drinks.Services;

UserService user = new();

var item = await user.GetCategoryInput();
var item2 = await  user.GetDrinkInput(item);
await user.GetDrinkDetail(item2);