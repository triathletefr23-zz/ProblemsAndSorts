using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemsLibrary.Problems;
using ProblemsLibrary.Problems.Helpers;

namespace Tests
{
    [TestClass]
    public class ProblemsShould
    {
        private readonly int[] defaultArray = { 1, 3, 5, 7, 8 };

        private readonly int[] defaultArray1 = { 4, 3, 2, 6 };

        private readonly int[] defaultArray2 = { -2147483648, -2147483648 };

        private readonly int[] defaultArray3 = { 4, 15, 14, 3, 14, -8, 12, -9, 17, -1, 15, 1, 10, 19, -7, 15, 8, 7, -8, 11 };

        private readonly int[] randomArray = { 5, 4, 6, 3, 1, 9, 7, 8, 2 };

        private readonly int[] oneElementArray = { 4 };

        private readonly int[] twoElementsArray = { 7, 8 };

        private readonly string[] randomWords = { "abc", "deq", "mee", "aqq", "dkd", "ccc" };

        private readonly string[] randomWordsFromExample = { "abc", "cba", "xyx", "yxx", "yyx" };

        private readonly int?[] binaryTree1 = { 1, null, 0, 0, 1 };

        private readonly int?[] binaryTree2 = { 1, 0, 1, 0, 0, 0, 1 };

        private readonly int?[] binaryTree3 = { 1, 1, 0, 1, 1, 0, 1, 0 };

        private readonly int[][] matrix1 =
        {
            new[] {-9, -9, -9, 1, 1, 1},
            new[] {0, -9, 0, 4, 3, 2},
            new[] {-9, -9, -9, 1, 2, 3},
            new[] {0, 0, 8, 6, 6, 0},
            new[] {0, 0, 0, -2, 0, 0},
            new[] {0, 0, 1, 2, 4, 0}
        };

        private readonly int[][] points1 =
        {
            new []{ 0, 4 },
            new []{ 2, 6 },
            new []{ 1, 5 },
            new []{ 3, 7 },
            new []{ 4, 4 },
        };

        private readonly int[][] points2 =
        {
            new []{ 0, 10 },
            new []{ 10, 20 },
        };

        [TestMethod]
        [TestCategory("PowerSum")]
        public void ReturnThreeForNumberHundredAndPowTwo()
        {
            var res = OtherProblems.PowerSum(100, 2);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        [TestCategory("PowerSum")]
        public void ReturnOneForNumberTenAndPowTwo()
        {
            var res = OtherProblems.PowerSum(10, 2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [TestCategory("DistantPairs")]
        public void ReturnZeroForNextExample()
        {
            var res = OtherProblems.DistantPairs(points2, 1000);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        [TestCategory("DistantPairs")]
        public void ReturnTwoForNextExample()
        {
            var res = OtherProblems.DistantPairs(points1, 8);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        [TestCategory("OddNumbers")]
        public void ReturnOddNumbersForRange3()
        {
            var res = ArrayProblems.oddNumbers(2, 8);
            Assert.AreEqual(3, res.Count);
        }

        [TestMethod]
        [TestCategory("OddNumbers")]
        public void ReturnOddNumbersForRange2()
        {
            var res = ArrayProblems.oddNumbers(3, 7);
            Assert.AreEqual(3, res.Count);
        }

        [TestMethod]
        [TestCategory("OddNumbers")]
        public void ReturnOddNumbersForRange1()
        {
            var res = ArrayProblems.oddNumbers(4, 3);
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        [TestCategory("OddNumbers")]
        public void ReturnOddNumbersForRange()
        {
            var res = ArrayProblems.oddNumbers(4, 5);
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        [TestCategory("HourglassSum")]
        public void ReturnMaxForMatrix1()
        {
            var res = ArrayProblems.hourglassSum(matrix1);
            Assert.AreEqual(28, res);
        }

        [TestMethod]
        [TestCategory("RotateFunction")]
        public void ReturnMaxForDefaultArray3()
        {
            var res = ArrayProblems.MaxRotateFunction(defaultArray3);
            Assert.AreEqual(1511, res);
        }

        [TestMethod]
        [TestCategory("RotateFunction")]
        public void ReturnMaxForDefaultArray2()
        {
            var res = ArrayProblems.MaxRotateFunction(defaultArray2);
            Assert.AreEqual(-2147483648, res);
        }

        [TestMethod]
        [TestCategory("RotateFunction")]
        public void ReturnMaxForDefaultArray1()
        {
            var res = ArrayProblems.MaxRotateFunction(defaultArray1);
            Assert.AreEqual(26, res);
        }

        [TestMethod]
        [TestCategory("PruneTree")]
        public void ReturnPruneTreeForExample2()
        {
            var tree = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 0,
                    left = new TreeNode(0),
                    right = new TreeNode(0)
                },
                right = new TreeNode
                {
                    val = 1,
                    left = new TreeNode(0),
                    right = new TreeNode(1)
                }
            };

            var expectedTree = new TreeNode
            {
                val = 1,
                right = new TreeNode
                {
                    val = 1,
                    right = new TreeNode(1)
                }
            };

            var resTree = TreeProblems.PruneTree(tree);

            Assert.IsNull(resTree.left);
            Assert.AreEqual(expectedTree.right.right.val, resTree.right.right.val);
        }


        [TestMethod]
        [TestCategory("PruneTree")]
        public void ReturnPruneTreeForExample1()
        {
            var tree = new TreeNode
            {
                val = 1,
                right = new TreeNode
                {
                    val = 0,
                    left = new TreeNode(0),
                    right = new TreeNode(1)
                }
            };

            var expectedTree = new TreeNode
            {
                val = 1,
                right = new TreeNode
                {
                    val = 0,
                    right = new TreeNode(1)
                }
            };

            var resTree = TreeProblems.PruneTree(tree);

            Assert.IsNull(resTree.left);
            Assert.AreEqual(expectedTree.right.right.val, resTree.right.right.val);
        }

        [TestMethod]
        [TestCategory("FindAndReplacePattern")]
        public void ReturnAListWithTwoWordsForExample()
        {
            var expectedRes = new List<string> { "abc", "cba" };
            var res = StringProblems.FindAndReplacePattern(randomWordsFromExample, "abc").ToList();
            CollectionAssert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [TestCategory("FindAndReplacePattern")]
        public void ReturnAListWithTwoWords()
        {
            var expectedRes = new List<string> { "mee", "aqq" };
            var res = StringProblems.FindAndReplacePattern(randomWords, "abb").ToList();
            CollectionAssert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [TestCategory("MaxBinaryTree")]
        public void ReturnMaxBinaryTreeForRandomArray()
        {
            var res = TreeProblems.ConstructMaximumBinaryTree(randomArray);
            Assert.IsTrue(res.val == randomArray[5]);
            Assert.AreEqual(res.left.val, randomArray[2]);
            Assert.AreEqual(res.right.val, randomArray[randomArray.Length - 2]);
        }

        [TestMethod]
        [TestCategory("MaxBinaryTree")]
        public void ReturnMaxBinaryTreeForDefaultArray()
        {
            var res = TreeProblems.ConstructMaximumBinaryTree(defaultArray);
            Assert.IsTrue(res.val == defaultArray.Last());
        }

        [TestMethod]
        [TestCategory("MaxBinaryTree")]
        public void ReturnMaxBinaryTreeWithTwoElement()
        {
            var res = TreeProblems.ConstructMaximumBinaryTree(twoElementsArray);
            Assert.IsTrue(res.val == twoElementsArray[1]);
            Assert.IsNull(res.right);
        }

        [TestMethod]
        [TestCategory("MaxBinaryTree")]
        public void ReturnMaxBinaryTreeWithOneElement()
        {
            var res = TreeProblems.ConstructMaximumBinaryTree(oneElementArray);
            Assert.IsTrue(res.val == oneElementArray.First());
            Assert.IsNull(res.left);
            Assert.IsNull(res.right);
        }

        [TestMethod]
        [TestCategory("SocksMerchant")]
        public void ReturnPairsCount()
        {
            var ar = new[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };

            var res = ArrayProblems.sockMerchant(10, ar);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        [TestCategory("HammingDistance")]
        public void ReturnDiffInBitsFor40and94()
        {
            var result = StringProblems.HammingDistance(120, 94);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [TestCategory("HammingDistance")]
        public void ReturnDiffInBitsFor3and1()
        {
            var result = StringProblems.HammingDistance(3, 1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [TestCategory("HammingDistance")]
        public void ReturnDiffInBitsFor10and13()
        {
            var result = StringProblems.HammingDistance(10, 13);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [TestCategory("HammingDistance")]
        public void ReturnDiffInBitsFor1and4()
        {
            var result = StringProblems.HammingDistance(1, 4);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [TestCategory("MorseCode")]
        public void ReturnNumberOfTransformation()
        {
            var words = new[] { "gin", "zen", "gig", "msg" };

            Assert.AreEqual(2, StringProblems.UniqueMorseRepresentations(words));
        }

        [TestMethod]
        [TestCategory("BobAndAliceScore")]
        public void ReturnAliceAndBobScores1()
        {
            var aliceScores = new List<int> { 10, 11, 12 };
            var bobScores = new List<int> { 12, 10, 13 };
            var expected = new List<int> { 1, 2 };

            var result = OtherProblems.CompareTriplets(aliceScores, bobScores);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("BobAndAliceScore")]
        public void ReturnAliceAndBobScores2()
        {
            var aliceScores = new List<int> { 13, 11, 12 };
            var bobScores = new List<int> { 12, 10, 13 };
            var expected = new List<int> { 2, 1 };

            var result = OtherProblems.CompareTriplets(aliceScores, bobScores);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("BobAndAliceScore")]
        public void ReturnAliceAndBobScores3()
        {
            var aliceScores = new List<int> { 12, 10, 13 };
            var bobScores = new List<int> { 12, 10, 13 };
            var expected = new List<int> { 0, 0 };

            var result = OtherProblems.CompareTriplets(aliceScores, bobScores);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void ReturnMinusOneIfElementIsNotInArray()
        {
            var result = OtherProblems.BinarySearch(defaultArray, 4);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void ReturnMinusOneIfElementIsNotInTwoElementsArray()
        {
            var result = OtherProblems.BinarySearch(defaultArray, 4);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void ReturnMinusOneIfArrayIsEmpty()
        {
            var result = OtherProblems.BinarySearch(new int[] { }, 4);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void ReturnZeroIfElementIsOnTheIFirstPosition()
        {
            var result = OtherProblems.BinarySearch(defaultArray, 1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void ReturnLastELementIndexIfElementIsOnTheILastPosition()
        {
            var result = OtherProblems.BinarySearch(defaultArray, 8);
            Assert.AreEqual(defaultArray.Length - 1, result);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void FindElementInOneElementArray()
        {
            var result = OtherProblems.BinarySearch(oneElementArray, 4);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void FindElementInTwoElementArray()
        {
            var result = OtherProblems.BinarySearch(twoElementsArray, 7);
            Assert.AreEqual(0, result);
        }
    }
}
