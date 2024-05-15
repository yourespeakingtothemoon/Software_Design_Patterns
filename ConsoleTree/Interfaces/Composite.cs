using System.Collections;
using System.Collections.Generic;

public class Composite : IComponent
{
    public List<IComponent> children = new List<IComponent>();

    public void Add(IComponent component)
    {
        children.Add(component);
    }

    public void Remove(IComponent component)
    {
        children.Remove(component);
    }

    public List<string> Operation()
    {
        return new List<string>();
    }

}

