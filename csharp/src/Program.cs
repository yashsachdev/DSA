class Program
{
    static void Main()
    {
        // Create a linked list: 10 -> 20 -> 30 -> 40
        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head.next.next.next = new Node(40);

        // Traverse and print the list
        linkedlist.TraverseList(head); // Output: 10 20 30 40

        // Insert at start
        head = linkedlist.insertNodeAtStart(head, 5);
        linkedlist.TraverseList(head); // Output: 5 10 20 30 40

        // Insert at end
        head = linkedlist.insertNodeAtEnd(head, 50);
        linkedlist.TraverseList(head); // Output: 5 10 20 30 40 50

        // Insert at position
        head = linkedlist.insertAtPosition(3, 15, head);
        linkedlist.TraverseList(head); // Output: 5 10 15 20 30 40 50

        // Count nodes
        int count = linkedlist.CountNode(head);
        Console.WriteLine("Total nodes: " + count); // Output: Total nodes: 7

        // Search key
        int key = 30;
        if (linkedlist.SearchKey(head, key))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

        // Delete head
        head = linkedlist.DeleteHead(head);
        linkedlist.TraverseList(head); // Output: 10 15 20 30 40 50

        // Remove last node
        head = linkedlist.RemoveLastNode(head);
        linkedlist.TraverseList(head); // Output: 10 15 20 30 40
    }
}
