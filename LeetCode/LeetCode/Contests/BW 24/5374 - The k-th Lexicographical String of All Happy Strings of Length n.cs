//// 
//using System.Collections.Generic;
//using System.Text;

//public partial class Solution
//{
//    public string GetHappyString(int n, int k)
//    {
//        var sb = new StringBuilder();

//        // Need to start with the n number of chars
//        // 1- Create initial string
//        for (int i = 0; i < n; i++)
//            sb.Append(i % 2 == 0 ? 'a' : 'b');

//        var next = new Dictionary<char, char>();
//        next.Add('a', 'b');
//        next.Add('b', 'c');
//        next.Add('c', 'a');
//        int iteration = 1;
//        while (iteration < k && sb.Length > 0)
//        {
//            Increment(sb, next, sb.Length - 1);
//            iteration++;
//        }

//        return sb.ToString();
//    }

//    private static void Increment(StringBuilder sb, Dictionary<char, char> next, int i)
//    {
//        if (i < 0)
//        {
//            sb.Clear();
//            return;
//        }

//        if (sb[i] == 'c')
//        {
//            Increment(sb, next, i - 1);
//            return;
//        }

//        while ((i > 0 && sb[i - 1] == sb[i]) || (i<sb.Length - 1 && sb[i + 1] == sb[i]))
//            sb[i] = next[sb[i]];

//        ResetRightSide(sb, i);
//    }

//    private static void ResetRightSide(StringBuilder sb, int i)
//    {
//        for (int j = i + 1; j < sb.Length; j++)
//        {
//            if (sb[j - 1] == 'c' || sb[j - 1] == 'b')
//                sb[j] = 'a';
//            else // a
//                sb[j] = 'b';
//        }
//    }
//}