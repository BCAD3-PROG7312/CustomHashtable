using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace CustomHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            CHashtable ch = new CHashtable();

            ch.Add(56581, "John");
            ch.Add(58381, "Jane");

            Console.WriteLine(ch.GetHashTable());
            
            /*
            ch.Remove(56581);
            Console.WriteLine("Removed");

            Console.WriteLine(ch.GetHashTable())*/;


            /*        
            Hashtable hash = new Hashtable();
            hash.Add(56581, "John");
            hash.Add(58384, "Jane");

            foreach (DictionaryEntry de in hash)
            {
                Console.WriteLine(de.Key + " - " + de.Value);
            }

            hash.Remove(56581);
            foreach (DictionaryEntry de in hash)
            {
                Console.WriteLine(de.Key + " - " + de.Value);
            }*/


        }
    }
}
