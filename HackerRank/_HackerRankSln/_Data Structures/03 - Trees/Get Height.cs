namespace _HackerRankSln._Data_Structures._03___Trees
{
    public static class Get_Height
    {
        public static int Height(Node node)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if (node == null)
                // return 0 if you wanted the number of nodes
                return -1;

            if (node.left != null)
                leftHeight = Height(node.left) + 1;

            if (node.right != null)
                rightHeight = Height(node.right) + 1;

            return leftHeight > rightHeight ? leftHeight : rightHeight;
        }
    }
}
