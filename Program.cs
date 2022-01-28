using System;
using System.Collections.Generic;
using System.Linq;

namespace problemB
{
    public class Program
    {
        static int totalSum = 0;
        static int totalCount = 0;
        static bool yes = true;
        static bool no = false;
        static int maxValue = 0;
        static int minValue = 0;
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != null)
            {
                if (n >= 2 && n <= 50)
                {
                    string line = Console.ReadLine();
                    var coinSets = line.Split(' ').Select(Int32.Parse).ToList();

                    for (int i = 0; i < coinSets.Count; i++)
                    {
                        totalSum += coinSets[i];
                        totalCount = totalSum;
                    }
                    while (totalCount != 0 && no != true)
                    {
                        var maxCoinValue = GetMaxValue(coinSets);
                        var maxCoinIndex = coinSets.ToList().IndexOf(maxCoinValue);
                        var minCoinValue = GetMinValue(coinSets);
                        var minCoinIndex = coinSets.ToList().IndexOf(minCoinValue);
                        if ((totalSum % 2 == 0) && (yes == true)) //Switch on, only one time to run
                        {
                            Console.WriteLine("yes");
                            Console.WriteLine(minCoinValue + " " + maxCoinIndex);
                            yes = false; //Switch off
                        }
                        else if (totalSum % 2 == 0)
                        {
                            Console.WriteLine(minCoinValue + 1 + " " + (maxCoinIndex + 1));
                        }
                        else
                        {
                            no = true;
                            Console.WriteLine("no");
                        }
                        totalCount -= 2;
                    }
                }
            }
        }
        public static int GetMaxValue(List<int> ai)
        {
            for (int i = 0; i < ai.Count; i++)
            {
                int maxValue1 = Math.Max(ai[0], ai[1]);
                int maxValue2 = Math.Max(ai[1], ai[2]);
                if (maxValue1 > maxValue2)
                {
                    maxValue = maxValue1;
                }
                else
                {
                    maxValue = maxValue2;
                }
            }
            return maxValue;
        }
        public static int GetMinValue(List<int> ai)
        {
            for (int i = 0; i < ai.Count; i++)
            {
                int minValue1 = Math.Min(ai[0], ai[1]);
                int minValue2 = Math.Min(ai[1], ai[2]);
                if (minValue1 < minValue2)
                {
                    minValue = minValue1;
                }
                else
                {
                    minValue = minValue2;
                }
            }
            return minValue;
        }
    }
}
