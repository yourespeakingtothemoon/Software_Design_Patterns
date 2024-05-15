using System.Collections;
using System.Collections.Generic;
using System.Transactions;

public class Person : IComponent
{

    private string name;
    private int birthYear;

    public List<IComponent> children = new List<IComponent>();

    public List<string> Operation()
    {
        List<string> strings = new List<string>();
        strings.Add(name + " " + birthYear);
        if (children.Count != 0)
        {
            strings.Add(children[0].Operation()[0]);
            strings.Add(children[1].Operation()[0]);
        }
        return strings;

    }

    public void Add(IComponent component)
    {
        children.Add(component);
    }

    public void Remove(IComponent component)
    {
        children.Remove(component);
    }


    public Person(string name, int birthYear)
    {
        this.name = name;
        this.birthYear = birthYear;
       
    }

    public string GetName()
    {
        return name;
    }

    public int GetBirthYear()
    {
        return birthYear;
    }

}