using System;

class Program
{
	static void Main(string[] args)
	{
		var solution = new Solution();

		// *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** ***
		// *** *** *** *** Interesting/Hard problems to review *** *** *** *** ***
		// *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** ***

		//SortedSquares // Merge sort
		//InsertIntoBST // Trees
		//KClosest // Sorting
		//CountBattleships // Matrix
		//LetterCasePermutation // Recursion
		//CountBits // Bitwise
		//CheckPossibility // Tricky logic
		//StrWithout3a3b // Greedy
		//ReconstructQueue // Greedy
		//FindMinArrowShots // Greedy
		//MinSwapsCouples // UnionFind                  *** DEBUG ***
		//FindMaxLength
		//DiameterOfBinaryTree
		//LastStoneWeight // Array
		//ContainsNearbyDuplicate // Nice solution (sliding window + set)
		//CountBits // Bitwise
		//CheckValidString

		// TODO: Improve: https://leetcode.com/submissions/detail/206295901/
		//Console.WriteLine(Solution.ShortestCompletingWord("1s3 PSt", new string[] { "step", "steps", "stripe", "stepple" })); 


		// *** 2019 *** DP focus ***
		//StoneGame // TODO: Refactor to bottom-up
		//MinFallingPathSum
		//MincostTickets // TODO: Bottom-up?
		//Rob
		//NumArray

		// *** 2020 ***
		//int[] testArray1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
		//solution.MaxSubArray(testArray1);

		//int[] testArray2 = { 0, 1, 0, 3, 12 };
		//solution.MoveZeroes(testArray2);

		//Console.WriteLine(solution.CountLargestGroup(13));
		//Console.WriteLine(solution.CountLargestGroup(2));
		//Console.WriteLine(solution.CountLargestGroup(15));
		//Console.WriteLine(solution.CountLargestGroup(24));

		//Console.WriteLine(solution.CanConstruct("annabelle", 2));
		//Console.WriteLine(solution.CanConstruct("leetcode", 3));
		//Console.WriteLine(solution.CanConstruct("true", 4));
		//Console.WriteLine(solution.CanConstruct("yzyzyzyzyzyzyzy", 2));
		//Console.WriteLine(solution.CanConstruct("cr", 7)); // Should be FALSE
		//Console.WriteLine(solution.CanConstruct("qlkzenwmmnpkopu", 15)); // Should be TRUE

		//var test = new int[][] {
		//	new int[] { 1, 2 },
		//	new int[] { 1, 2 },
		//	new int[] { 3, 3 },
		//	new int[] { 1, 5 },
		//	new int[] { 1, 5 },
		//};
		//Console.WriteLine(solution.MaxEvents(test));

		//var test = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

		//Console.WriteLine(solution.GroupAnagrams(test));

		//var test = new int[] { 1, 0, 0, 1 };
		//Console.WriteLine(solution.FindMaxLength(test));

		var grid = new char[][]
		{
			"11110".ToCharArray(),
			"11010".ToCharArray(),
			"11000".ToCharArray(),
			"00000".ToCharArray(),
		};
		Console.WriteLine(solution.NumIslands(grid));
	}
}
