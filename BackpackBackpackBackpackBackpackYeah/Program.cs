using BackpackBackpackBackpackBackpackYeah.Items;
using BackpackBackpackBackpackBackpackYeah.ConcreteAggregate;
using BackpackBackpackBackpackBackpackYeah.ConcreteIterator;
using BackpackBackpackBackpackBackpackYeah.Interfaces;


internal class Program
{
    private static void Main(string[] args)
    {
        BackpackInventory backpack = new BackpackInventory();
        backpack.AddItem(new Torch());
        backpack.AddItem(new Book("Holes by Louis Sachar"));
        backpack.AddItem(new Book("Spanish-English Dictionary"));
        backpack.AddItem(new Map());

        IInventoryIterator backpackIterator = backpack.GetIterator();
        while (backpackIterator.HasNext())
        {
           Console.WriteLine(backpackIterator.Current().Name());
            backpackIterator.Next();
        }



    }
}