// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int depth = 5;

var familyTree = new FamilyTreeAggregate();

Person christian = new Person("Christian", 1998);
familyTree.AddItem(christian);

Person clay = new Person("Clay", 1955);
christian.Add(clay);
familyTree.AddItem(clay);

Person ann = new Person("Ann", 1957);
christian.Add(ann);
familyTree.AddItem(ann);

Person carl = new Person("Carl", 1933);
ann.Add(carl);
familyTree.AddItem(carl);

Person gayle = new Person("Gayle", 1938);
ann.Add(gayle);
familyTree.AddItem(gayle);

Person ted = new Person("Ted", 1930);
clay.Add(ted);
familyTree.AddItem(ted);

Person wanda = new Person("Wanda", 1932);
clay.Add(wanda);
familyTree.AddItem(wanda);

Person rulon = new Person("Rulon", 1902);
ted.Add(rulon);
familyTree.AddItem(rulon);

Person alta = new Person("Alta", 1906);
ted.Add(alta);
familyTree.AddItem(alta);

Person arthur = new Person("Arthur", 1890);
wanda.Add(arthur);
familyTree.AddItem(arthur);

Person katie = new Person("Katie", 1898);
wanda.Add(katie);
familyTree.AddItem(katie);

Person ivin = new Person("Ivin", 1897);
carl.Add(ivin);
familyTree.AddItem(ivin);

Person sarah = new Person("Sarah", 1896);
carl.Add(sarah);
familyTree.AddItem(sarah);

Person bill = new Person("William", 1906);
gayle.Add(bill);
familyTree.AddItem(bill);

Person gayle2 = new Person("Gayle", 1909);
gayle.Add(gayle2);
familyTree.AddItem(gayle2);

var treeIterator = (TreeIterator)familyTree.GetIterator();

//illustrate tree with proper spacing

//print root generation and children
var person = (Person)treeIterator.Next();
string line1 = "";
for (int i = 0; i < depth; i++)
{
    line1 += " ";
}
line1 += person.Operation()[0];
Console.WriteLine(line1);
int line1space = line1.Length / 4;
//draw connecting slashes to children
if (person.children.Count > 0)
{
    string line2 = "";
    for (int i = 0; i < line1space; i++)
    {
        line2 += " ";
    }
    line2 += "/";
    for (int i = 0; i < line1space; i++)
    {
        line2 += " ";
    }
    line2 += "\\";
    Console.WriteLine(line2);
}
//print children
if (person.children.Count > 0)
{
    string line3 = "";
    line3 += person.Operation()[1];
    line3 += " ";
    line3 += person.Operation()[2];
    Console.WriteLine(line3);
}

Console.WriteLine("would you like to print the rest of the tree?");
string response = Console.ReadLine();
if (response == "yes")
{
    PrintAll();
}

void PrintAll()
{
    while (treeIterator.HasNext())
    {
       
            person = (Person)treeIterator.Next();
        if (person.children.Count > 0)
        {
            string line1 = "";
            for (int i = 0; i < depth; i++)
            {
                line1 += " ";
            }
            line1 += person.Operation()[0];
            Console.WriteLine(line1);

            int line1space = line1.Length / 4;
            //draw connecting slashes to children
         
                string line2 = "";
                for (int i = 0; i < line1space; i++)
                {
                    line2 += " ";
                }
                line2 += "/";
                for (int i = 0; i < line1space; i++)
                {
                    line2 += " ";
                }
                line2 += "\\";
                Console.WriteLine(line2);
            
            //print children

            string line3 = "";
            line3 += person.Operation()[1];
            line3 += " ";
            line3 += person.Operation()[2];
            Console.WriteLine(line3);
        }

    }
}
