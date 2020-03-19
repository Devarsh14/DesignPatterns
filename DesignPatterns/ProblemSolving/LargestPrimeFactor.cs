using System;
using System.Collections.Generic;
using System.Text;

// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?
namespace DesignPatterns.ProblemSolving
{
    class LargestPrimeFactor
    {
        // 1. Divide the value with the number

        long InputInt = 600851475143;
        List<int> PrimeNumber = new List<int>();

        public int FindLargestPrimeNumber()
        {
            int number = 13195;
            float reminder;
            List<float> reminders = new List<float>();
            for (int i = 1; i <= number; i++)
            {
                reminder = number / i;
                reminders.Add(reminder);
            }

            return 0;
        }

    }
}