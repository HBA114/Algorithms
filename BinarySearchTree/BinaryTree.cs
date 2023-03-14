using Algorithms.Common;
using BreadthFirstSearch;
using DepthFirstSearch;

namespace BinarySearchTree;

public class BinaryTree : Tree
{
    public BinaryTree(Node root) : base(root)
    {
    }

    public bool Add(int id, Node? node = null)
    {
        if (root is null)
        {
            root = new Node(id);
            return true;
        }
        else
        {
            if (node is null) node = root;
            if (id < node.Id)
            {
                if (node.Left is not null) return Add(id, node.Left);
                else
                {
                    node.Left = new Node(id: id, parent: node);
                    return true;
                }
            }
            else if (id > node.Id)
            {
                if (node.Right is not null) return Add(id, node.Right);
                else
                {
                    node.Right = new Node(id: id, parent: node);
                    return true;
                }
            }
            else    //! if id equals another node's id do not add
            {
                return false;
            }

        }
    }

    public void WriteAsDepthFirst()
    {
        List<Node> order = DFS.CreateDepthFirstSearchOrder(this);

        Console.WriteLine($"Depth First Search Order: ");
        foreach (var item in order)
        {
            if (item != order.Last())
                Console.Write($"{item.Id}, ");
            else
                Console.Write($"{item.Id}");
        }
        Console.WriteLine($"");
    }

    public void WriteAsBreadthFirst()
    {
        List<Node> order = BFS.CreateBreadthFirstSearchOrder(this);

        Console.WriteLine($"Breadth First Search Order: ");
        foreach (var item in order)
        {
            if (item != order.Last())
                Console.Write($"{item.Id}, ");
            else
                Console.Write($"{item.Id}");
        }
        Console.WriteLine($"");
    }
}
