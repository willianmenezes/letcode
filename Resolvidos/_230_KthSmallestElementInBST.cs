using System.Collections;

namespace LetCode.Resolvidos;

public class _230_KthSmallestElementInBST
{
    public static void Executar()
    {
        var root = new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4));
        var teste = KthSmallest(root, 1);
    }

    static List<int> itensOrdenados = new List<int>();

    private static int KthSmallest(TreeNode root, int k)
    {
        if (root == null)
            return 1;
        
        Validar(root);

        return itensOrdenados[k - 1];
    }

    public static void Validar(TreeNode root)
    {
        if (root == null)
            return;
        
        Validar(root.left);
        
        itensOrdenados.Add(root.val);
        
        Validar(root.right);
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