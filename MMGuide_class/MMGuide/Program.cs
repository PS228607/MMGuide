// See https://aka.ms/new-console-template for more information
/*
 * Optimaliseer de code op zo’n manier dat je AnimalList en DoubleList kan vervangen met een 
    klasse GenericList met een enkele DoSomething methode.
*/
public class MMGuide_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Console test");

        GenericList<object> listOfAll = new GenericList<object>();
        listOfAll.DoSomething(2.5);
        listOfAll.DoSomething(new Animal());
    }
}

public class Animal
{
    public string Name { get; set; }
    public List<string> Habitats { get; set; }
}

public class GenericList<T>
{
    public void DoSomething(T item)
    {
        Console.WriteLine($"Doing something with {item}");
    }
}


/*public class AnimalList
{
    public void DoSomething(Animal animal)
    {
        Console.WriteLine("Foo Animal");
    }
}
public class DoubleList
{
    public void DoSomething(double number)
    {
        Console.WriteLine("Foo Number");
    }
}*/