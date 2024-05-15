using System.Collections;
using System.Collections.Generic;

public class Person : Composite
{

    private string name;
    private int birthYear;

   
  
    public void Operation()
    {
   
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