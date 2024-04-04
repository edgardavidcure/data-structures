public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (value != Data)
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if (value != Data)
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            // Value found at this node
            return true;
        }
        else if (value < Data && Left != null)
        {
            // Search in the left subtree
            return Left.Contains(value);
        }
        else if (value > Data && Right != null)
        {
            // Search in the right subtree
            return Right.Contains(value);
        }

        // Value not found
        return false;
    }

    public int GetHeight()
    {
        if (Left == null && Right == null)
        {
            return 1;
        }
        else
        {
            int leftHeight = (Left != null) ? Left.GetHeight() : 0;
            int rightHeight = (Right != null) ? Right.GetHeight() : 0;
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}