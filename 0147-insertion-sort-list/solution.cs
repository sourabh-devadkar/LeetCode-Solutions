public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }

        // Dummy node acts as the start of the sorted list
        ListNode dummy = new ListNode(0);
        ListNode current = head;

        while (current != null) {
            // Crucial: Save the next node in the unsorted list before we modify current
            ListNode nextNode = current.next;

            // Find the correct position to insert 'current' 
            // We start scanning from the dummy node every time
            ListNode prev = dummy;
            while (prev.next != null && prev.next.val < current.val) {
                prev = prev.next;
            }

            // Insert 'current' between 'prev' and 'prev.next'
            current.next = prev.next;
            prev.next = current;

            // Move to the next unsorted node that we safely saved earlier
            current = nextNode;
        }

        return dummy.next;
    }
}
