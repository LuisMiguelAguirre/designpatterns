using System;
using System.Collections;
using System.Collections.Generic;

class Example : IEnumerable<string>
{
    List<string> _elements;

    public Example(string[] array)
    {
        this._elements = new List<string>(array);
    }

    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    {
        Console.WriteLine("HERE");
        return this._elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this._elements.GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        Example example = new Example(
            new string[] { "cat", "dog", "bird" });
       
        foreach (string element in example)
        {
            Console.WriteLine(element);
        }

        Console.ReadLine();
    }
}
