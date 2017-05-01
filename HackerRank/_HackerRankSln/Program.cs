using LL = _HackerRankSln._Data_Structures._02___Linked_Lists;
using Trees = _HackerRankSln._Data_Structures._03___Trees;

namespace _HackerRankSln
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // --------------- ALGORITHMS ----------------

            #region 01 - Warmup

            //Simple_Array_Sum.Main();
            //A_Very_Big_Sum.Main();
            //Diagonal_Difference.Main();
            //Plus_Minus.Main();
            //Time_Conversion.Main();
            //Circular_Array_Rotation.Main();
            //Birthday_Cake_Candles.Main();

            #endregion 01 - Warmup

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
            //DivisibleSumPairs.Main();
            //Compare_the_Triplets.Main();
            //Mini_Max_Sum.Main();
            //Designer_PDF_Viewer.Main();
            //Bon_Appétit.Main();
            //AppleAndOrange.Main();
            //Sock_Merchant.Main();
            //Beautiful_Days_at_the_Movies.Main();
            //Grading_Students.Main();
            //Breaking_the_Records.Main();
            //Cats_and_a_Mouse.Main();
            //The_Hurdle_Race.Main();
            //Jumping_on_the_Clouds.Main();
            //Drawing_Book.Main();
            //Birthday_Chocolate.Main();
            //Kangaroo.Main();
            //Between_Two_Sets.Main();
            //Viral_Advertising.Main();
            //Equalize_the_Array.Main();

            #endregion 02 - Implementation

            #region 03 - Strings

            //Alternating_Characters.CountDeletions();

            #endregion 03 - Strings

            #region 04 - Sorting

            //Insertion_Sort___Part_1.insertionSort();

            #endregion 04 - Sorting

            #region 06 - Graph Theory

            //Even_Tree.Main(); // TODO: ---> Study this

            #endregion 06 - Graph Theory

            #region 08 - Dynamic Programming

            //Fibonacci_Modified._Main();

            #endregion 08 - Dynamic Programming

            #region 09 - Bit Manipulation

            //Lonely_Integer.Main();

            #endregion 09 - Bit Manipulation

            // --------------- DATA STRUCTURES -----------

            #region 01 - Arrays

            //Arrays___DS.PrintReversedElements();
            //_2D_Array___DS.FindMaxHourglass();
            //Dynamic_Array.PrintUpdatedLastAnswer();
            //Sparse_Arrays.PrintTimes();

            #endregion 01 - Arrays

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

            #endregion 02 - Linked Lists

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

            #endregion 03 - Trees

            #region 04 - Balanced Trees

            //Self_Balancing_Tree__AVL_.Insert(new Self_Balancing_Tree__AVL_.Node(), 10);
            // Array and simple queries -> available for C#
            // Median Updates -> available for C#

            #endregion 04 - Balanced Trees

            #region 05 - Stacks

            //Maximum_Element._Main();
            //Balanced_Parentheses._Main();
            //Simple_Text_Editor.Main();
            //Largest_Rectangle.Main();

            #endregion 05 - Stacks

            // --------------- MATHEMATICS ---------------

            #region 01 - Fundamentals

            //Find_Point.FindPoint();
            //Restaurant.gcdSquares();

            #endregion 01 - Fundamentals

            // --------------- 30DaysOfCode ---------------

            #region 30

            //Day_8___Dictionaries_and_Maps._Main();
            //Day_9___Recursion._Main();
            //Day_11___2DArrays._Main();
            //Day_10___Binary_Numbers._Main();

            #endregion 30

            // ------- Cracking the Coding Interview -------

            #region Cracking the Coding Interview

            // DATA STRUCTURES

            //Arrays___Left_Rotation.Main();
            //Strings___Making_Anagrams.Main();
            //Hash_Tables___Ransom_Note.Main();
            //Stacks___Balanced_Brackets.Main();
            //Queues___A_Tale_of_Two_Stacks.Main();
            //Tries___Contacts.Main();
            //Heaps___Find_the_Running_Median.Main();
            //Trees___Is_This_a_Binary_Search_Tree.Main();
            //Linked_Lists___Detect_a_Cycle.Main();

            // ALGORITHMS

            //Sorting___Bubble_Sort.Main();
            //Merge_Sort___Counting_Inversions.Main();
            //Binary_Search___Ice_Cream_Parlor.Main();
            //DFS___Connected_Cell_in_a_Grid.Main();
            //BFS___Shortest_Reach_in_a_Graph.Main(); // TODO: Need to grok this

            // TECHNIQUES

            //DP___Coin_Change.Main(); // TODO: Need to grok this
            //Time_Complexity___Primality.Main();
            // ... etc

            #endregion Cracking the Coding Interview

            // --------------- COMPETITIONS ----------------

            #region Competitions

            #region May World CodeSprint 2016

            //Compare_the_Triplets.Compare();
            //Richie_Rich.PrintMaxPalindrome();

            #endregion May World CodeSprint 2016

            #region Week of Code - 20

            // Non_Divisible_Subset._Main(); -> Not finished, sub-optimal... TODO: Look for others submissions

            #endregion Week of Code - 20

            #region Zalando CodeSprint

            //Match_the_Shoes._Main();
            //The_Inquiring_Manager.Solve();

            #endregion Zalando CodeSprint

            #region BlackRock CodeSprint

            //Currency_Arbitrage.Main();

            #endregion BlackRock CodeSprint

            #region World CodeSprint 4

            //Minimum_Distances.Main();
            //Equal_Stacks.Main();

            #endregion World CodeSprint 4

            #region Week of Code - 21

            //Luck_Balance.Main();

            #endregion Week of Code - 21

            #endregion Competitions
        }
    }
}