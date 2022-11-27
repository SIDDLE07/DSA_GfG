using DSA_GfG.DSA.core;

public class RecursiveReverseLL
{
    public ListNode ReverseList(ListNode node)
    {

        if (node == null || node.next == null)
        {
            return node;
        }
        // in every iteration it is returning the original head back.
        var newHead = ReverseList(node.next);
        node.next.next = node;
        node.next = null;
        return newHead;
    }


    
	
}