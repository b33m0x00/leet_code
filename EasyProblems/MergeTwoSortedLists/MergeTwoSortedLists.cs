namespace EasyProblems.MergeTwoSortedLists;

public class MergeTwoSortedLists
{
    public ListNode Solution(ListNode? list1, ListNode? list2)
    {
        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

        var header = list1.val <= list2.val ? list1 : list2;
        var second = list1.val <= list2.val ? list2 : list1;
        var savedHeader = header;

        while (second != null)
        {
            if (header.next != null && header.next.val < second.val)
            {
                header = header.next;
            }
            else
            {
                var tmp = header.next;
                
                header.next = new ListNode(second.val, tmp);
                second = second.next;
            }
        }
        
        return savedHeader;
    }
}