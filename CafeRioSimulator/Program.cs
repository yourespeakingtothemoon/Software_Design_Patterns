// See https://aka.ms/new-console-template for more information
using CafeRioSimulator.Interfaces;
using CafeRioSimulator.ConcreteComponents;
using CafeRioSimulator.ConcreteDecorators.AddOns;
using CafeRioSimulator.ConcreteDecorators.Protiens;

Console.WriteLine("Welcome to Tio's Bistro! How may I start your order?");
Console.WriteLine("1. Burrito");
Console.WriteLine("2. Tacos");
Console.WriteLine("3. Enchiladas");

Console.WriteLine("Please enter the number of the dish you would like to order: ");
string dishChoice = Console.ReadLine();
DishComponent dish = null;
switch (dishChoice) {
    case "1":
        Console.WriteLine("You have chosen a Burrito. What protein would you like in your burrito?");
        dish = new Burrito(7.99, 1);
        break;
    case "2":
        Console.WriteLine("You have chosen The Plate of Tacos. What protein would you like in your tacos?");
        dish = new Tacos(3.99, 1);
        break;
    case "3":
        Console.WriteLine("You have chosen the Enchaladas. What protein would you like in your enchaladas?");
        dish = new Enchiladas(5.99, 1);
        break;
}

Console.WriteLine("1. Fire-Grilled Steak");
Console.WriteLine("2. Pollo Asado");
Console.WriteLine("3. Pinto Beans");

Console.WriteLine("Please enter the number of the protein you would like to add to your dish: ");
string proteinChoice = Console.ReadLine();

switch (proteinChoice)
{
    case "1":
        dish = new Steak(dish);
        break;
    case "2":
        dish = new PolloAsado(dish);
        break;
    case "3":
        dish = new Beans(dish);
        break;
}

bool addOns = true;

while(addOns)
{ 
Console.WriteLine("Would you like to add any add-ons to your dish?");
Console.WriteLine("1. Fresh Avocado Slices");
Console.WriteLine("2. Habenero Sauce");
Console.WriteLine("3. Lime");
Console.WriteLine("4. Cojita Cheese");
Console.WriteLine("5. No More Add-Ons");

Console.WriteLine("Please enter the number of the add-on you would like to add to your dish: ");
string addOnChoice = Console.ReadLine();
switch (addOnChoice)
{
    case "1":
        dish = new FreshAvocado(dish);
        break;
    case "2":
        dish = new HabeneroSauce(dish);
        break;
    case "3":
        dish = new Lime(dish);
        break;
    case "4":
        dish = new Cojita(dish);
        break;
    case "5":
        addOns = false;
        break;
}

}

Console.WriteLine("Do you want your dish to be served on a bed of rice? (y/n)");
string riceChoice = Console.ReadLine();
if (riceChoice == "y")
{
    Random random = new Random();
    int riceType = random.Next(1, 3);
    if (riceType == 1)
    {
        dish = new Rice(dish);
    }
    else
    {
        dish = new UndercookedRice(dish);
    }
}
else
{
    dish = new UndercookedRice(dish);
}

Console.WriteLine("Your dish is ready! Here is your order:");
Console.WriteLine(dish.GetDescription());
Console.WriteLine("Price: $" + dish.GetPrice());
string tasteValue = "";
    if (dish.GetTasteValue() > 7)
{
    tasteValue = "delicious";
}
else if (dish.GetTasteValue() < 4)
{
    tasteValue = "inedible";
}
else
{
    tasteValue = "alright";
}

Console.WriteLine("Taste Value: " + tasteValue);
Console.WriteLine("Enjoy your meal!");

