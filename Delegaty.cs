using System;
using System.Collections.Generic;
using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        testEventow test = new testEventow();
        test.onAdded += (object sender, mojeargumenty mojeargumenty) =>
        {
            Console.WriteLine($"dodano wartość {mojeargumenty.value}");
        };
        //nie statytcznie
        Program program = new Program();
        test.onRemoved += program.ObjectDeleted;

        //statycznie
        test.onRemoved += StaticObjectDeleted;

        test.Add(73);
        test.Add(1234);
        test.Add(51);
        test.Delete(2);
    }

    public void ObjectDeleted(object sender, mojeargumenty mojeargumenty)
    {
        Console.WriteLine($"Usunieto z moje argumenty niestatycznie {mojeargumenty.value}");
    }
    public static void StaticObjectDeleted(object sender, mojeargumenty mojeargumenty)
    {
        Console.WriteLine($"Usunieto z moje argumenty statycznie {mojeargumenty.value}");
    }
}

public class testEventow
{
    public event EventHandler<mojeargumenty> onAdded;
    public event EventHandler<mojeargumenty> onRemoved;
    private List<int> lista = new List<int>();

    public void Add(int value)
    {
        onAdded?.Invoke(this, new mojeargumenty(value));
        lista.Add(value);
    }

    public void Delete(int index)
    {
        onRemoved?.Invoke(this, new mojeargumenty(lista[index]));
        lista.RemoveAt(index);
    }
}
public class mojeargumenty : EventArgs
{
    public int value;
    public mojeargumenty(int value)
    {
        this.value = value;
    }
}