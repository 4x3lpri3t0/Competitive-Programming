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

		// TODO: Improve: https://leetcode.com/submissions/detail/206295901/
		//Console.WriteLine(Solution.ShortestCompletingWord("1s3 PSt", new string[] { "step", "steps", "stripe", "stepple" })); 


		// *** 2019 *** DP focus ***
		//StoneGame // TODO: Refactor to bottom-up
		//MinFallingPathSum
		//MincostTickets // TODO: Bottom-up?
		//Rob
		//NumArray

		// *** 2020 ***
		var array = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
		solution.MaxSubArray(array);
	}
}
