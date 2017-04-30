using _HackerRankSln._Data_Structures._03___Trees;

// https://www.hackerrank.com/challenges/binary-search-tree-insertion

public class BST_Insertion
{
    private static Node Insert(Node root, int value)
    {
        if (root == null)
        {
            root = new Node();
            root.data = value;
            return root;
        }

        if (value < root.data)
        {
            root.left = Insert(root.left, value);
        }
        else
        {
            root.right = Insert(root.right, value);
        }

        return root;
    }
}