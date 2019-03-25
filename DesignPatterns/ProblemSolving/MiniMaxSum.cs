using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace DesignPatterns.ProblemSolving
{
    public class MiniMaxSum
    {   // Find minimum sum of givan array and maxium sum of givan array element of only 4 out of 5.
        // https://www.hackerrank.com/challenges/mini-max-sum/problem solved.
        // Complete the miniMaxSum function below.
        public  void miniMaxSum(int[] arr)
        {
            // Find minumum sum 
            // IList do not conatains the defination of get range.
            List<int> minimumList = arr.ToList();
            // Here V is actual value in list.
            minimumList = minimumList.OrderBy(v => v).ToList();

            // Get range helps you  to create sublist out of list.
            minimumList = minimumList.GetRange(0, 4);
            
            // sum of first four elements for minimu value
            long minValue = 0;
            if (minimumList.Count > 0)
            {
                foreach (var item in minimumList)
                {
                    minValue += item;
                }
            }
            

            // Find maximum sum
            List<int> maxValueList = arr.OrderByDescending(v=>v).ToList();
            // sum of first four elements for max value
            long maxValue = 0;

            maxValueList = maxValueList.GetRange(0, 4);
            if (maxValueList.Count > 0)
            {
                foreach (var item in maxValueList)
                {
                    maxValue += item;
                }
            }
            Console.Write(minValue.ToString() + ' ' + maxValue.ToString());
        }
    }
}

// Intially failing because output was expected in long. 
// Get range is part of immuatable 
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.immutable.immutablelist-1.getrange?view=netcore-2.2
// In list it GetRange and other methods will only works if List<T> no IList<t>.
