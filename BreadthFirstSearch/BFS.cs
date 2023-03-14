using Algorithms.Common;

namespace BreadthFirstSearch;

public static class BFS
{
    public static List<Node> CreateBreadthFirstSearchOrder(Tree tree)
    {
        List<Node> order = new List<Node>();
        Node node = tree.root!;

        order.Add(node);

        int index = 0;
        while (true)
        {
            node = order[index];
            if (node.Left != null && !order.Any(x => x.Id == node.Left.Id)) order.Add(node.Left);
            if (node.Right != null && !order.Any(x => x.Id == node.Right.Id)) order.Add(node.Right);
            index++;
            if (index >= order.Count()) break;
        }

        return order;
    }
}
