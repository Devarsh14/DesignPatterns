using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CSharpFeatures
{
    class MultiDimentionalArray
    {

        public void Array2D()
        {
            Console.WriteLine("Enter values for multi dimentional 2D array");
            Console.ReadLine();

            int[,] array2dexample = new int[2, 3];

            for (int i = 0; i < array2dexample.GetLength(0); i++)
            {
                for (int j = 0; j < array2dexample.GetLength(1); j++)
                {
                    Console.WriteLine("Insert array value");
                    int.TryParse(Console.ReadLine(), out int value);
                    array2dexample[i, j] = value;
                }
            }

            for (int i = 0; i < array2dexample.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array2dexample.GetLength(1); j++)
                {
                    Console.Write(array2dexample[i, j] + " ");
                }
            }


        }
    }
}
