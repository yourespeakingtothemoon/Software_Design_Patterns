using System.Collections;
using System.Collections.Generic;


public class FamilyTreeAggregate : IAggregate
{
    public List<IComponent> components;

    public FamilyTreeAggregate()
    {
        components = new List<IComponent>();
    }

    public void AddItem(IComponent item)
    {
        components.Add(item);
    }

    public void RemoveItem(IComponent item)
    {
        components.Remove(item);
    }

    public IIterator GetIterator()
    {
        return new TreeIterator(this);
    }


 
}