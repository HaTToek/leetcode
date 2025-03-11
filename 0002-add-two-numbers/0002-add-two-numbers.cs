/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum = l1.val + l2.val;
        int ten = sum / 10;
        int one = sum % 10;
        ListNode result = new ListNode(one);
        ListNode temp = result;
        l1 = l1?.next;
        l2 = l2?.next;
        while(l1 != null || l2 != null){
            sum = (l1?.val ?? 0) + (l2?.val ?? 0) + ten;
            ten = sum / 10;
            one = sum % 10;
            ListNode newNode = new ListNode(one);
            temp.next = newNode;
            temp = temp.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if(ten != 0){
            ListNode newNode = new ListNode(ten);
            temp.next = newNode;
            temp = temp.next;
        }

        return result;
    }
}