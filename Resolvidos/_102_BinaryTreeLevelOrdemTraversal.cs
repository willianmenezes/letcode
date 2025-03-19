using System.Collections;

namespace LetCode.Resolvidos;

public class _102_BinaryTreeLevelOrdemTraversal
{
    public void Executar()
    {
        var root = new TreeNode(3);
        var teste = LevelOrder(null);
    }

    private IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
            return [];

        return AdicionaElementoNaLista(root, new List<IList<int>>(),0);
    }

    private IList<IList<int>> AdicionaElementoNaLista(TreeNode node, IList<IList<int>> resposta, int index)
    {
        if (node == null)
            return resposta;
        
        if (resposta.Count == index)
            resposta.Add(new List<int>());
        
        resposta[index].Add(node.val);
        
        AdicionaElementoNaLista(node.left, resposta, index + 1);
        AdicionaElementoNaLista(node.right, resposta, index + 1);
        
        return resposta;
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
