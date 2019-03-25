namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BirthdayCackeCandles
    {
        public int BirthdayCakeCandles(int[] ar)
        {
            List<int> candlesHeight = ar.ToList();
            candlesHeight = candlesHeight.OrderBy(v => v).ToList();
            int maximumHeightOfCandle = candlesHeight.Max();

            // Find total candles with maximum heights in List.
            List<int> totalCandlesWithMaxHeight = candlesHeight.Where(v => v == maximumHeightOfCandle).ToList();

            // Find count of maximum height candles
            int maxHeightCandlesCount = totalCandlesWithMaxHeight.Count();
            return maxHeightCandlesCount;
        }
    }
}