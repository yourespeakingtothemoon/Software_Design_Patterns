using System.Collections;
using System.Collections.Generic;

public class Composite : IComponent
{
    private List<IComponent> children = new List<IComponent>();

    public void Add(IComponent component)
    {
        children.Add(component);
    }

    public void Remove(IComponent component)
    {
        children.Remove(component);
    }

    public void Operation()
    {
        foreach (IComponent child in children)
        {
            child.Operation();
        }
    }

}

