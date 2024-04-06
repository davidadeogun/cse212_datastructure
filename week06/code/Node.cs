public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        //TODO Problem 1 SOLVED
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
    
}

    public bool Contains(int value) {
        //TO DO Problem 2 SOLVED
    if (value < Data) {
        // Search to the left
        if (Left is null)
            return false;
        else
            return Left.Contains(value);
    }
    else if (value > Data) {
        // Search to the right
        if (Right is null)
            return false;
        else
            return Right.Contains(value);
    }
    else {
        
        return true;
    }
}

    public int GetHeight() {
        //Problem 4 SOLVED
    int leftHeight = Left is null ? 0 : Left.GetHeight();
    int rightHeight = Right is null ? 0 : Right.GetHeight();
    return 1 + Math.Max(leftHeight, rightHeight);
}
}