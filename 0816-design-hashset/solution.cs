public class ListNode {
    public int Key;
    public ListNode Next;
    public ListNode(int key)
    {
        Key = key;
        Next = null;
    }
}
public class MyHashSet {
    private ListNode[] ans = null;
    private readonly int capacity = 10007;
    public MyHashSet() {
        ans = new ListNode[capacity];
    }
    
    private int GetIndex(int key){
        return Math.Abs(key % capacity);
    }

    public void Add(int key) {
        int index = GetIndex(key);
        ListNode current = ans[index];
        while(current != null)
        {
            if(current.Key == key)
                return;
            current = current.Next;
        }
        ListNode newNode = new ListNode(key);
        newNode.Next = ans[index];
        ans[index] = newNode;
    }
    
    public void Remove(int key) {
        int index = GetIndex(key);
        ListNode current = ans[index];
        ListNode previous = null;
        while(current != null)
        {
            if(current.Key == key)
            {
                if(previous == null)
                {
                    ans[index] = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }
                return;
            }
            previous = current;    
            current = current.Next;
        }
    }
    
    public bool Contains(int key) {
        int index = GetIndex(key);
        ListNode current = ans[index];
        while(current != null)
        {
            if(current.Key == key)
                return true;
            current = current.Next;
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
