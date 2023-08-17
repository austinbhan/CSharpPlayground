// See https://aka.ms/new-console-template for more information

using System.Runtime.ConstrainedExecution;

Food currentFood = Food.Soup;
Taste currentTaste = Taste.Hot;
Ingredient currentIngredient = Ingredient.Mushrooms;

var finalResult = (currentFood, currentTaste, currentIngredient);
Console.WriteLine(finalResult);

enum Food {
    Soup,
    Stew,
    Gumbo
}

enum Taste {
    Hot, 
    Salty, 
    Sweet
}

enum Ingredient {
    Mushrooms,
    Chicken, 
    Carrots,
    Potatoes
}