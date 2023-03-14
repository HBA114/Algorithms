namespace BinarySearchTree;

public class Tree
{
    private Node? _root;

    public bool Add(int id, Node? node = null)
    {
        if (_root is null)
        {
            _root = new Node(id);
            return true;
        }
        else
        {
            if (node is null) node = _root;
            if (id <= node.Id)
            {
                if (node.Left is not null) return Add(id, node.Left);
                else
                {
                    node.Left = new Node(id: id, parent: node);
                    return true;
                }
            }
            if (id > node.Id)
            {
                if (node.Right is not null) return Add(id, node.Right);
                else
                {
                    node.Right = new Node(id: id, parent: node);
                    return true;
                }
            }
        }

        return false;
    }

    public void WriteAsDepthFirst()
    {
        List<Node> order = new List<Node>();
        Node node = _root!;
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

            if (node == _root)
            {
                if (_root.Left is not null)
                    if (order.Any(x => x.Id == _root.Left.Id))
                        isEnded[0] = true;
                if (_root.Right is not null)
                    if (order.Any(x => x.Id == _root.Right.Id))
                        isEnded[1] = true;

                if (isEnded.All(x => x == true)) break;
            }
        }

        foreach (var item in order)
        {
            Console.Write($"{item.Id}, ");
        }
        Console.WriteLine($"");
    }
}