public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
    if (value < Data) {
        // Insert to the left
        if (Left is null)
            Left = new Node(value);
        else
            Left.Insert(value);
    } 
    else if (value > Data) {
        // Insert to the right
        if (Right is null)
            Right = new Node(value);
        else
            Right.Insert(value);
    }
    // If value == Data, do nothing (no duplicates)
}


    public bool Contains(int value) {
    if (value < Data) {
        // Search the left subtree
        return Left != null && Left.Contains(value);
    } else if (value > Data) {
        // Search the right subtree
        return Right != null && Right.Contains(value);
    } else {
        // Value is equal to the data of this node
        return true;
    }
}


    public int GetHeight() {
        // TODO Start Problem 4
        BinarySearchTree bst =  new BinarySearchTree();
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        return Math.Max(leftHeight, rightHeight) + 1;
        
        
    }
}