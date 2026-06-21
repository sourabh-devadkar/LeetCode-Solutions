public class HashNode
{
    public int Key;
    public int Value;
    public HashNode Next;
    public HashNode(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

public class MyHashMap {
    private HashNode[] ans;
    private readonly int capacity = 1000003;
    public MyHashMap() {
        ans = new HashNode[capacity];
    }

    private int GetIndex(int key)
    {
        return Math.Abs(key % capacity);
    }
    
    public void Put(int key, int value) {
        int index = GetIndex(key);
        HashNode current = ans[index];
        while(current != null)
        {
            if(current.Key == key)
            {
                current.Value = value;
                return;
            }
            current = current.Next;
        }
        HashNode newNode = new HashNode(key, value);
        newNode.Next = ans[index];
        ans[index] = newNode;
    }
    
    public int Get(int key) {
        int index = GetIndex(key);
        HashNode current = ans[index];
        while(current != null)
        {
            if(current.Key == key)
            {
                return current.Value;
            }
            current = current.Next;
        }
        return -1;
    }
    
    public void Remove(int key) {
        int index = GetIndex(key);
        HashNode current = ans[index];
        HashNode previous = null;
        while(current != null)
        {
            if(current.Key == key)
            {
                if(previous == null)
                {
                    ans[index] = current.Next;
                }
                else{
                    previous = current.Next;
                }
                return;
            }
            previous = current;
            current = current.Next;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
