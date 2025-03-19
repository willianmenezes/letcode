using System.Collections;

namespace LetCode.Resolvidos;

public class _111_MinimumDepthOfBinaryTree
{
    public static void Executar()
    {
        var root = new TreeNode(2, null,
            new TreeNode(3, null, new TreeNode(4, null, new TreeNode(5, null, new TreeNode(6)))));
        var teste = MinDepth(root);
    }

    static int profundidadeMinima = int.MaxValue;

    private static int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        
        ValidaMinimaProfundidade(root, 1);
        
        return profundidadeMinima;
    }

    private static void ValidaMinimaProfundidade(TreeNode root, int profundidade)
    {
        if (root == null)
            return;

        var folha = root.left == null && root.right == null;

        if (folha)
            profundidadeMinima = Math.Min(profundidadeMinima, profundidade);

        var proximaProfundidade = profundidade + 1;
        
        if (proximaProfundidade >= profundidadeMinima)
            return;
        
        ValidaMinimaProfundidade(root.left, profundidade + 1);
        ValidaMinimaProfundidade(root.right, profundidade + 1);
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