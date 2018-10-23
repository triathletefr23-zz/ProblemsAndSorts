﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblemsLibrary.Problems
{
    public static class ArrayProblems
    {
        

        public static List<int> oddNumbers(int l, int r)
        {
            var res = new List<int>();
            if (l > r) return res;
            if (l == r && l % 2 == 1)
            {
                res.Add(l);
                return res;
            };

            for (var i = l % 2 == 1 ? l : l + 1; i <= r; i += 2)
            {
                res.Add(i);
            }

            return res;
        }

        public static int hourglassSum(int[][] sum)
        {
            var n = sum.Length;
            var max = int.MinValue;

            for (var i = 1; i < n - 1; i++)
            {
                for (var j = 1; j < n - 1; j++)
                {
                    var curr = sum[i - 1][j - 1] + sum[i - 1][j] + sum[i - 1][j + 1] + sum[i][j] +
                            sum[i + 1][j - 1] + sum[i + 1][j] + sum[i + 1][j + 1];
                    if (curr > max) max = curr;
                }
            }
            return max;
        }

        public static int sockMerchant(int n, int[] ar)
        {
            var count = 0;
            var pairs = new List<int>();

            foreach (var el in ar)
            {
                if (pairs.Contains(el))
                {
                    count++;
                    pairs.Remove(el);
                }
                else pairs.Add(el);
            }

            return count;
        }

        public static int MaxRotateFunction(int[] A)
        {
            if (!A.Any()) return 0;

            var maxSum = 0;
            var allElemsSum = 0;
            for (var i = 0; i < A.Length; i++)
            {
                maxSum += A[i] * i;
                allElemsSum += A[i];
            }
            
            var prev = maxSum;
            for (var i = 1; i < A.Length; i++)
            {
                var sum = allElemsSum + prev - A.Length * A[A.Length - i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                prev = sum;
            }

            return maxSum;
        }
    }
}
