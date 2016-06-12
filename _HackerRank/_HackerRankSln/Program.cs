using _HackerRankSln._Algorithms._01___Warmup_Problems;
using _HackerRankSln._Algorithms._02___Implementation;
using _HackerRankSln._Algorithms._04___Sorting;
using _HackerRankSln._Data_Structures._01___Arrays;
using LL = _HackerRankSln._Data_Structures._02___Linked_Lists;
using _HackerRankSln._Data_Structures._02___Linked_Lists;
using Trees = _HackerRankSln._Data_Structures._03___Trees;
using _HackerRankSln._Data_Structures._03___Trees;
using _HackerRankSln._Mathematics._01___Fundamentals;
using _HackerRankSln.Competitions.May_World_CodeSprint_2016;
using _HackerRankSln.Competitions.Week_of_Code___20;
using _HackerRankSln._Algorithms._03___Strings;
using _HackerRankSln._Data_Structures._04___Balanced_Trees;
using _HackerRankSln._30DaysOfCode;
using _HackerRankSln._Data_Structures._05___Stacks;
using _HackerRankSln._Algorithms._08___Dynamic_Programming;
using _HackerRankSln.Competitions.Zalando_CodeSprint;
using _HackerRankSln._Algorithms._06___Graph_Theory;
using _HackerRankSln._Algorithms._09___Bit_Manipulation;
using _HackerRankSln.Competitions.BlackRock_CodeSprint;

namespace _HackerRankSln
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------- ALGORITHMS ----------------
            #region 01 - Warmup
            //Console.WriteLine(Simple_Array_Sum.ArraySum());
            //Console.WriteLine(A_Very_Big_Sum.VeryBigSum());
            //Console.WriteLine(Diagonal_Difference.DiagonalDiff());
            //Plus_Minus.PrintFractions();
            //Time_Conversion.ConvertTime();
            #endregion
            #region 02 - Implementation
            //Angry_Professor.PrintCancelledClasses();
            //Sherlock_and_The_Beast.CalculateLinearDiophantineEquation();
            //Sherlock_and_Squares.Sherlock();
            //Lisa_s_Workbook.PrintSpecialChapters();
            //The_Grid_Search.HasPattern();
            //Caesar_Cipher.Encrypt();
            //Library_Fine.CalculateFine();
            //Extra_Long_Factorials.CalculateFactorial();
            //Taum_and_B_day.GiftCalculator();
            #endregion
            #region 03 - Strings
            //Alternating_Characters.CountDeletions();
            #endregion
            #region 04 - Sorting
            //Insertion_Sort___Part_1.insertionSort();
            #endregion

            #region 06 - Graph Theory
            //Even_Tree.Main(); // TODO: ---> Study this
            #endregion
            #region 08 - Dynamic Programming
            //Fibonacci_Modified._Main();
            #endregion
            #region 09 - Bit Manipulation
            //Lonely_Integer.Main();
            #endregion
            // --------------- DATA STRUCTURES -----------
            #region 01 - Arrays
            //Arrays___DS.PrintReversedElements();
            //_2D_Array___DS.FindMaxHourglass();
            //Dynamic_Array.PrintUpdatedLastAnswer();
            //Sparse_Arrays.PrintTimes();
            #endregion
            #region 02 - Linked Lists
            var llNode = new LL.Node();
            //Print_the_Elements_of_a_LL.Print(llNode);
            //Insert_a_Node_at_the_Tail_of_a_LL.InsertTail(llNode, 0);
            //Insert_a_node_at_the_Head_of_a_LL.InsertHead(llNode, 0);
            //Insert_a_node_at_a_specific_position_in_a_LL.InsertNth(llNode, 0, 1);
            //Delete_a_Node.Delete(llNode, 1);
            //Print_in_Reverse.ReversePrint(llNode);
            //Reverse_a_LL.Reverse(llNode);
            //Compare_two_LL.CompareLists(llNode, llNode);
            //Merge_two_sorted_LL.MergeLists(llNode, llNode);
            //Get_Node_Value.GetNode(llNode, 0);
            //Delete_duplicate_value_nodes_from_a_sorted_LL.RemoveDuplicates(llNode);
            //Cycle_Detection.HasCycle(llNode);
            //Find_Merge_Point_of_Two_LL.FindMergeNode(llNode, llNode);
            var llDoubleNode = new LL.Node2();
            //Insert_a_node_into_a_sorted_doubly_LL.SortedInsert(llDoubleNode, 100);
            //Reverse_a_doubly_LL.Reverse(llDoubleNode);
            #endregion
            #region 03 - Trees
            var treeNode = new Trees.Node();
            //Preorder_Traversal.PreOrder(treeNode);
            //Postorder_Traversal.PostOrder(treeNode);
            //Inorder_Traversal.InOrder(treeNode);
            //Get_Height.Height(treeNode);
            //Top_View.TopView(treeNode);
            //Level_Order_Traversal.LevelOrder(treeNode);
            //Inorder_Traversal.InOrder(treeNode);
            //Huffman_Decoding.Decode("ABACA", new Huffman_Decoding.Node());
            //BST_Lowest_Common_Ancestor.LCA(treeNode, 1, 7);
            //Swap_Nodes.Swap();
            #endregion
            #region 04 - Balanced Trees
            //Self_Balancing_Tree__AVL_.Insert(new Self_Balancing_Tree__AVL_.Node(), 10);
            // Array and simple queries -> available for C#
            // Median Updates -> available for C#
            #endregion

            #region 05 - Stacks
            //Maximum_Element._Main();
            //Balanced_Parentheses._Main();
            //Simple_Text_Editor.Main();
            //Largest_Rectangle.Main();
            #endregion
            // --------------- MATHEMATICS ---------------
            #region 01 - Fundamentals
            //Find_Point.FindPoint();
            //Restaurant.gcdSquares();
            #endregion
            // --------------- 30DaysOfCode ---------------
            #region 30
            //Day_8___Dictionaries_and_Maps._Main();
            //Day_9___Recursion._Main();
            //Day_11___2DArrays._Main();
            //Day_10___Binary_Numbers._Main();

            #endregion
            // --------------- COMPETITIONS ----------------
            #region May World CodeSprint 2016
            //Compare_the_Triplets.Compare();
            //Richie_Rich.PrintMaxPalindrome();
            #endregion
            #region Week of Code - 20
            // Non_Divisible_Subset._Main(); -> Not finished, sub-optimal... TODO: Look for others submissions
            #endregion
            #region Zalando CodeSprint
            //Match_the_Shoes._Main();
            The_Inquiring_Manager.Solve();
            #endregion
            #region BlackRock CodeSprint
            //Currency_Arbitrage.Main();
            #endregion
        }
    }
}
