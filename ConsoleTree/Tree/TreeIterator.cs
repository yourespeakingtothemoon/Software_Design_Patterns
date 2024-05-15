using System.Collections;
using System.Collections.Generic;

public class TreeIterator : IIterator
{
    private FamilyTreeAggregate familyTree;
    private int index;

    public TreeIterator(FamilyTreeAggregate familyTree)
    {
        this.familyTree = familyTree;
        this.index = 0;
    }

    public IComponent Next()
    {
        return familyTree.components[index++];
    }

    public bool HasNext()
    {
        return index < familyTree.components.Count;
    }

    public IComponent? currentItem()
    {
       
    return familyTree.components[index] ?? null;
    }
}