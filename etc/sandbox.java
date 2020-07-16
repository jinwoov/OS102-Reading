
public class Node {
    public Integer Value;
    public Node Right;
    public Node Left;
    public Node(int value){
        this.Value = value;
        this.Right = null;
        this.Left = null;
    }
}

public class BinarySearchTree{
    public Node Root;

    public Node Insert(Node root, Integer value){
        if(Root == null)
            root = new Node(value);
            Root = root;
            return root;
        
        else{
            if(root == null)
                root = new Node(value);
            
            if(root.Value >= value)
                root.Left = Insert(root.Left, value);
            if(root.Value < value)
                root.Right = Insert(root.Right, value);
        }

    }

    public boolean Contains(Node node, Integer Value) {
        if(node == null )
            return false;
        
        if(node.Value == value)
            return true;

        else{
            if(root.Value < value)
                return Contains(node.Right);
            else{
                return Contains(node.left);
            }
        }
    }
}

public class SandBox{

    public static boolean BinarySearch(Integer[] value, Integer searchValue){

        if(value.length == 0 )
            return false;

        Integer start = 0;
        Integer end = value.length - 1;
        while(start < end){
            Integer mid = (start + end)/ 2;

            if(value[mid] == searchValue)
                return true;
            
            if(value[mid] > searchValue)
                end = mid - 1;
            
            else
                start = mid +1;
        }

        return false;
    }
    
}