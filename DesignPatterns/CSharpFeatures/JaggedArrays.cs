using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CSharpFeatures
{
    class JaggedArrays
    {
        public void JaggedArrayExample2D()
        {
            Console.WriteLine("Enter values for multi dimentional 2D array");
            Console.ReadLine();

            int[][] array2dexample = new int[3][];

            // Jagged array is array of arrays. Mostly used in javascript or charting library with element[i].Properties example risk[i].numbers in array, enumerator or list to access value in MVC.
            // All those javascript concepts with inner and outer for loop is considered as jagged array and to access elements.

            // bug : provide null refernece exception.
            // Bug : create method with input and output oriented. Remove innner inputs which are hidden to make it testable.
            // BUG : provide values from upstream.
            for (int i = 0; i < array2dexample.Length; i++)
            {
                // Intialsise rows of array in jagged array.
                array2dexample[i] = new int[3];
                for (int j = 0; j < array2dexample[i].Length; j++)
                {
                    Console.WriteLine("Insert values into jagged array");

                    array2dexample[i][j] = int.TryParse(Console.ReadLine(), out int value) ? value : 0;
                }
            }

            for (int i = 0; i < array2dexample.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array2dexample[i].Length; j++)
                {
                    Console.Write(array2dexample[i][j] + " ");
                }
            }

            // Get diagnoal sum
            int sum = 0;
            int leftDiagonal = 0;

            for (int i = 0; i < array2dexample.Length; i++)
            {
                sum += array2dexample[i][i];
                leftDiagonal += array2dexample[array2dexample.Length - 1 - i][i];

                //Console.WriteLine();
                //for (int j = 0; j < array2dexample[i].Length; j++)
                //{
                //}
            }

            Console.WriteLine(sum);
            sum = Math.Abs(sum - leftDiagonal);
        }
    }
}

//https://docs.microsoft.com/en-us/dotnet/api/system.math.abs?view=netframework-4.7.2