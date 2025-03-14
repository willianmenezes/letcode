namespace LetCode.Resolvidos;

public class _21_MergedTwoLists
{
    public void Execute()
    {
        var lista01 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var lista02 = new ListNode(1, new ListNode(3, new ListNode(4)));
        
        var lista = MergeTwoLists(lista01, lista02);
        
    }
    
    // Let code numero 21
    private ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
            return list1;

        if (list1 == null)
            return list2;

        if (list2 == null)
            return list1;

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }

        list2.next = MergeTwoLists(list1, list2.next);
        return list2;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}