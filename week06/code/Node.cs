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
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        Node? _root;
        // if(_root.)
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        BinarySearchTree bst =  new BinarySearchTree();
        bst.
        
        return 0; // Replace this line with the correct return statement(s)
    }
}