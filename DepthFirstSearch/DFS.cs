using Algorithms.Common;

namespace DepthFirstSearch;

public static class DFS
{
    public static List<Node> CreateDepthFirstSearchOrder(Tree tree)
    {
        List<Node> order = new List<Node>();
        Node node = tree.root!;
        bool[] isEnded = new bool[2] { false, false };

        while (true)
        {
            if (order.Any(x => x.Id == node.Id))
            {
                if (node.Left != null && !order.Any(x => x.Id == node.Left.Id)) node = node.Left;
                else if (node.Right != null && !order.Any(x => x.Id == node.Right.Id)) node = node.Right;
                else node = node.Parent!;
            }
            else
                order.Add(node);

            if (node == tree.root)
            {
                if (tree.root.Left is not null)
                    if (order.Any(x => x.Id == tree.root.Left.Id))
                        isEnded[0] = true;
                if (tree.root.Right is not null)
                    if (order.Any(x => x.Id == tree.root.Right.Id))
                        isEnded[1] = true;

                if (isEnded.All(x => x == true)) break;
            }
        }

        return order;
    }
}
