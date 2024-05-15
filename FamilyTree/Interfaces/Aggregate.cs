using System.Collections;
using System.Collections.Generic;

public interface IAggregate
{

    public void AddItem(IComponent item);
    public void RemoveItem(IComponent item);

    public IIterator GetIterator();
    
}
