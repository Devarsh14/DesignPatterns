using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CSharpFeatures
{
    public class HashTables
    {

        // Hash tables represents collection of key value pair in c#
        //The generic Dictionary was copied from Hashtable's source
        // And also generic collections are a lot faster as there's no boxing/unboxing
        //"It returns/throws Exception if we try to find a key which does not exist." Not if you use Dictionary.TryGetValue – Jim Balter Nov 3 '18 at 17:21
        public void HashTableDemo()
        {

            Hashtable hashtable = new Hashtable();
            hashtable.Add("Devarsh", "Shukla");
            hashtable.Add("Ripal", "Kumar");

            bool containsKey = hashtable.ContainsKey("Devarsh");
            // Each hashtable or item is converted into the dictionary entry.
            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
