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

            
            Console.WriteLine("Select input for the execution");
            Console.WriteLine("0 for MinMax value");
            Console.WriteLine("1 for BirthDay candles");
            int[] arr;
            // Get input selected for class to execute.
            int.TryParse(Console.ReadLine(), out int n);
            switch (n)
            {
                case 0:
                    Console.WriteLine("Please insert 5 integers with space separated.");

                    // Min max sum 
                    arr = ArrayInput();  
                    MiniMaxSum miniMaxSum = new MiniMaxSum();
                    miniMaxSum.MiniMaxsum(arr);
                    Console.Read();
                    break;
                case 1:
                    Console.WriteLine("Please insert age of your niece");
                    int arCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please insert height of candle with space separated as age.");
                    arr = ArrayInput();

                    BirthdayCackeCandles birthdayCackeCandles = new BirthdayCackeCandles();
                    birthdayCackeCandles.BirthdayCakeCandles(arr);
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    break;
            }



        }

        private static int[] ArrayInput()
        {
            return Array.ConvertAll(Console.ReadLine().Split(' '),
                arrTemp => Convert.ToInt32(arrTemp));
        }
    }
    
}



