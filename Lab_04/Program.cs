using System;
using System.Collections;
using System.IO;
public class Program
{
    public static void Main()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array[1] = 3;
        array[5] = 4; 
    

    }
}

class DynamicArray<T>
{
    private T[] items = new T[0];

    public T this[int i]
    {

        get { return this.items[i];  }
        set
        {
            if (i > this.items.Length)
            {
                T[] newItems = new T[i + 1];

                Array.Copy(this.items, newItems, this.items.Length);
            }

            this.items[i] = value;
        }

    }
}