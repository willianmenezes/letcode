using System.Collections;

namespace LetCode.Resolvidos;

public class _98_ValidateBinarySearchTree
{
    public static void Executar()
    {
        var teste = IsValidBST(
            new TreeNode(5, 
                new TreeNode(3),new TreeNode(15, 
                    new TreeNode(3), new TreeNode(17, 
                        new TreeNode(16), new TreeNode(22)))));
    }

    private static bool IsValidBST(TreeNode root)
    {
        if (root == null)
            return false;

        return IsValid(root, long.MinValue, long.MaxValue);
    }

    private static bool IsValid(TreeNode root, long min, long max)
    {
        if (root == null)
            return true;

        var condicao = root.val > min && root.val < max;

        if (!condicao)
            return false;

        return IsValid(root.left, min, root.val) && IsValid(root.right, root.val, max);
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}