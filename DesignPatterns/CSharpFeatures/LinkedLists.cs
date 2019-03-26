using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CSharpFeatures
{
    public class LinkedLists
    {
        public void LinkedListDemo()
        {
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddLast(2);
            //LinkedListNode<int> node = new LinkedListNode<int>(linkedlist);
            //linkedlist.AddAfter(node, 3);


            // linked list example  https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?redirectedfrom=MSDN&view=netframework-4.7.2

            // We can convert array to link list. 

            // Create the link list.
            string[] words =
                { "the", "fox", "jumps", "over", "the", "dog" };

            LinkedList<string> sentence = new LinkedList<string>(words);
            sentence.Contains("the");

            sentence.AddFirst("today");

            // move first node to lastnode
            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);

            // Can i convert link list to list or array.
            List<string> convertTolist = sentence.ToList();


            // BUG: come back later to understand better. 
            // still need to verfity more understanding for the linked list. 


        }
    }
}
