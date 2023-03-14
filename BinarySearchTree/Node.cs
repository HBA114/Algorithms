namespace BinarySearchTree;

public class Node
{
    public int Id { get; set; }
    public Node? Parent { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node()
    {
    }

    public Node(int id, Node? parent = null, Node? left = null, Node? right = null)
    {
        Id = id;
        Parent = parent;
        Left = left;
        Right = right;
    }
}