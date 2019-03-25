using DesignPatterns.CSharpFeatures;
using DesignPatterns.ProblemSolving;
using System;

namespace DesignPatterns
{  
    //https://refactoring.guru/design-patterns/factory-method
    // NAME OF EXTENTION IS SUPERCHARGER.
    // BUG: 
  // Creational patterns allows and provides ways to create objects in  application
    public class Desing
    {
        public static void Main()
        {
            //HashTables hashTables = new HashTables();
            //hashTables.HashTableDemo();

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), 
                arrTemp => Convert.ToInt32(arrTemp));
            // Min max sum 
            MiniMaxSum miniMaxSum = new MiniMaxSum();
            miniMaxSum.miniMaxSum(arr);
            Console.Read();

        }
    }
    
}



