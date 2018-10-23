using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ProblemsLibrary.Problems.Helpers;

namespace ProblemsLibrary.Problems
{
    public static class OtherProblems
    {
        public static int PowerSum(int X, int N)
        {
            return FindSum(X, N, 1);
        }

        private static int FindSum(int x, int n, int number)
        {
            var sqr = Convert.ToInt32(Math.Pow(number, n));
            if (sqr < x)
            {
                return FindSum(x, n, number + 1) +
                       FindSum(x - sqr, n, number + 1);
            }
            return sqr == x ? 1 : 0;
        }

        public static int DistantPairs(int[][] points, int c)
        {
            var max = 0;

            for (var i = 0; i < points.Length; i++)
            {
                for (var j = i + 1; j < points.Length - 1; j++)
                {
                    max = Math.Max(DistBetweenPoints(points[i], points[j], c), max);
                }
            }

            return max;
        }

        private static int DistBetweenPoints(int[] point1, int[] point2, int c)
        {
            var min = int.MaxValue;
            foreach (var a in point1)
            {
                foreach (var b in point2)
                {
                    if (a == b) return 0;
                    min = Math.Min(PointDist(new[] {a, b}, c), min);
                }
            }

            min = Math.Min(PointDist(point1, c), Math.Min(PointDist(point2, c), min));

            return min;
        }

        private static int PointDist(int[] point, int c)
        {
            if (point[0] == point[1]) return 0;
            var diff = Math.Abs(point[0] - point[1]);
            return Math.Min(diff, c - diff);
        }

        public static string Encode(int i)
        {
            var Base = Data.Alphabet.Length;
            if (i == 0) return Data.Alphabet[0].ToString();

            var s = string.Empty;

            while (i > 0)
            {
                s += Data.Alphabet[i % Base];
                i = i / Base;
            }

            return string.Join(string.Empty, s.Reverse());
        }

        public static int Decode(string s)
        {
            var Base = Data.Alphabet.Length;

            return s.Aggregate(0, (current, c) => current * Base + Data.Alphabet.IndexOf(c));
        }

        public static int NumJewelsInStones(string jewels, string stones)
        {
            var i = 0;
            //return stones.Replace(jewels, "").Length;
            var dict = jewels.ToDictionary(jewel => i++);

            var count = stones.Count(stone => dict.ContainsValue(stone));
            return count;
        }

        public static int BinarySearch(int[] array, int key)
        {
            int lo = 0, hi = array.Length - 1;
            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                var midValue = array[mid];
                if (midValue > key) hi = mid - 1;
                else if (midValue < key) lo = mid + 1;
                else return mid;
            }
            return -1;
        }

        public static string ToLowercase(string str)
        {
            return str.ToLower();
        }

        private static int calculateResultScore(int x, int y)
        {
            if (x > y) return 1;
            if (x < y) return -1;
            return 0;
        }

        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int aliceScore = 0, bobScore = 0;
            for (var i = 0; i < a.Count; i++)
            {
                if (calculateResultScore(a[i], b[i]) > 0)
                {
                    aliceScore += 1;
                }
                if (calculateResultScore(a[i], b[i]) < 0)
                {
                    bobScore += 1;
                }
            }

            return new List<int> { aliceScore, bobScore };
        }       
        
    }
}
