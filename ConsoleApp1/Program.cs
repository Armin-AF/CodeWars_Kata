using System;
using System.Text;
using System.Collections;
using LeetCode;

class Program
{
    static void Main()
    {
        var myHashTable = new Hashtable{
            {"bob", 27},
            {33, "fred"}
        };

        int theAge = (int)(myHashTable["bob"] ?? throw new InvalidOperationException());
        
        Console.WriteLine(theAge);
        
        IDictionaryEnumerator myEnumerator = myHashTable.GetEnumerator();

        while (myEnumerator.MoveNext())
        {
            Console.WriteLine("{0}: {1}", myEnumerator.Key, myEnumerator.Value);
        }

        StringBuilder myStringBuilder = new StringBuilder();

        myStringBuilder.Append("bob");
        myStringBuilder.Append(" smith");
        myStringBuilder.Append(" jr");
        myStringBuilder.Insert(2, " ");
        var hashCode = myStringBuilder.GetHashCode();
        Console.WriteLine(hashCode);

        string myString = myStringBuilder.ToString();
        
        Console.WriteLine(myString);

        
        var idk = Class1.PigIt("Pig latin is cool");
        Console.WriteLine(idk);

    }
}