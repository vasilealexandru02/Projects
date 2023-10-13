// See https://aka.ms/new-console-template for more information

// Composite, resuelve la problemática de crear objetos a partir de otros objetos. En este caso, se podría crear pasteles a partir de otros pasteles y esto se puede extrapolar al caso que a mi me interese

// Es un patrón de diseño de creación de objetos

using Composite;

Ingredient sugar = new Ingredient("Sugar", 100, 100, "grams");
Ingredient flour = new Ingredient("Flour", 300, 200, "grams");
Ingredient eggs = new Ingredient("Eggs", 50, 4, "unit");

// First cake 
CakeComposite cake = new CakeComposite("Cake");
cake.Add(sugar);
cake.Add(flour);
cake.Add(eggs);
//cake.CalculatePrice();
Console.WriteLine("Cake price " + cake.Price);
cake.Remove(flour);
CakeComposite vanillaChocolateCake = new CakeComposite("Vanilla Chocolate Cake");

Ingredient chocolateAndVanilla = new Ingredient("Chocovanilla", 500, 1, "unit");
vanillaChocolateCake.Add(chocolateAndVanilla);
vanillaChocolateCake.Add(cake);

//vanillaChocolateCake.CalculatePrice();
Console.WriteLine("Chovanilla cake price: " + vanillaChocolateCake.Price);

vanillaChocolateCake.Remove(eggs);
Console.WriteLine("After removing eggs: " + vanillaChocolateCake.Price);

vanillaChocolateCake.Add(flour);
Console.WriteLine("After adding flour: " + vanillaChocolateCake.Price);
