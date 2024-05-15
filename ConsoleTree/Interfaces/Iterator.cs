using System.Collections;
using System.Collections.Generic;


public interface IIterator
{
    public IComponent Next();
    public bool HasNext();

    IComponent? currentItem();
}
