namespace DesignPatterns
{
    using System;
    using DesignPatterns.Algorithms.HacherRank;
    using DesignPatterns.CSharpFeatures;
    using DesignPatterns.ProblemSolving;

    // https://refactoring.guru/design-patterns/factory-method
    // NAME OF EXTENTION IS SUPERCHARGER.
    // Install extention stylecop and also install extention stylecopAnalysers.
    // BUG:
    // Creational patterns allows and provides ways to create objects in  application
    public class Desing
    {
        public static void Main()
        {
            //MultiDimentionalArray multiDimentionalArray = new MultiDimentionalArray();
            //multiDimentionalArray.Array2D();

            JaggedArrays jaggedArrays = new JaggedArrays();
            jaggedArrays.JaggedArrayExample2D();


            SwitchConsoleStatements();

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
                case 2:
                    Console.WriteLine("Insert time conversion string ex: 12:05:05PM");
                    string timeString = Console.ReadLine();
                    TimeConversion timeConversion = new TimeConversion();
                    string convertedTime = timeConversion.TimeConversions(timeString);
                    Console.WriteLine(convertedTime);
                    Console.ReadLine();
                    break;
                case 3:
                    // Enter details for string interpolatio in future.

                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    break;
            }
        }

        private static void SwitchConsoleStatements()
        {
            Console.WriteLine();
            Console.WriteLine("Select input for the execution");
            Console.WriteLine("0 for MinMax value");
            Console.WriteLine("1 for BirthDay candles");
            Console.WriteLine("2 for DateTimeConversion");
            Console.WriteLine("3 for StringInterpolation using $");
        }

        private static int[] ArrayInput()
        {
            return Array.ConvertAll(
                Console.ReadLine().Split(' '),
                arrTemp => Convert.ToInt32(arrTemp));
        }
    }
}
