using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Algorithms.Challenge
{
    public class MatrixInSpiralOrder
    {
        public void PrintMatrixInSprialOrder()
        {
            Console.WriteLine("Write matarix");


            int[][] mat = new int[][]
        {
            new int[] { 1,  2,  3,  4, 5},
            new int[] {16, 17, 18, 19, 6},
            new int[] {15, 24, 25, 20, 7},
            new int[] {14, 23, 22, 21, 8},
            new int[] {13, 12, 11, 10, 9 }
        };

            while (true)
            {
                for (int i = 0; i < mat.Length; i++)
                {
                    if (i == 0)
                    {
                        // Go right
                        for (int j = 0; j < mat[i].Length; j++)
                        {
                            Console.WriteLine(mat[i][j]);
                        }
                    }

                    // last column from the remaining columns // [i][j.length-1]
                    if (i > 0 && i < mat.Length - 1)
                    {
                        Console.WriteLine(mat[i][mat.Length - 1]);
                    }

                    if (i == 4)
                    {
                        // Go right
                        for (int j = mat[i].Length - 1; j >= 0; j--)
                        {
                            Console.WriteLine(mat[i][j]);
                        }
                    }
                }

                Console.Read();
            }
        }

// how to create a spiral of even array

        // 1.  Write first array in full ; Last element of all other arrays
    }
}
