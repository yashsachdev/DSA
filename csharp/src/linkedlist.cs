// Class representing a node in a singly linked list
public class Node
{
    public int data; // Holds the data
    public Node next; // Pointer to the next node

    // Constructor to create a new node
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

// Class containing linked list operations
public class linkedlist
{
    // Recursively traverses the list and prints each node's data
    public static void TraverseList(Node head)
    {
        if (head == null)
        {
            System.Console.WriteLine();
            return;
        }
        System.Console.Write(head.data + " ");
        TraverseList(head.next);
    }

    // Searches for a key in the list
    public static bool SearchKey(Node head, int key)
    {
        Node curr = head;
        while (curr != null)
        {
            if (curr.data == key)
                return true;
            curr = curr.next;
        }
        return false;
    }

    // Inserts a new node at the start of the list
    public static Node insertNodeAtStart(Node head, int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = head;
        return new_node;
    }

    // Inserts a new node at the end of the list
    public static Node insertNodeAtEnd(Node head, int new_data)
    {
        Node new_node = new Node(new_data);

        // If the list is empty, return the new node as head
        if (head == null)
        {
            return new_node;
        }

        Node end = head;
        // Traverse to the last node
        while (end.next != null)
        {
            end = end.next;
        }

        end.next = new_node; // Link the last node to the new node
        return head;
    }

    // Counts the number of nodes in the list
    public static int CountNode(Node head)
    {
        int count = 0;
        Node curr = head;
        while (curr != null)
        {
            count++;
            curr = curr.next;
        }
        return count;
    }

    // Inserts a new node at a specific position (1-based index)
    public static Node insertAtPosition(int pos, int new_data, Node head)
    {
        if (pos < 1)
        {
            return head;
        }

        if (pos == 1)
        {
            Node new_node_1 = new Node(new_data);
            new_node_1.next = head;
            return new_node_1;
        }

        Node curr = head;
        for (int i = 1; i < pos - 1 && curr != null; i++)
        {
            curr = curr.next;
        }

        if (curr == null)
        {
            return head;
        }

        Node new_node = new Node(new_data);
        new_node.next = curr.next;
        curr.next = new_node;

        return head;
    }

    // Deletes the head node from the list
    public static Node DeleteHead(Node head)
    {
        if (head == null)
            return null;

        return head.next;
    }
    public static Node RemoveLastNode(Node head)
    {
        // If the list is empty, return null
        if (head == null) {
            return null;
        }

        // If the list has only one node, delete it and
        // return null
        if (head.next == null) {
            return null;
        }

        // Find the second last node
        Node secondLast = head;
        while (secondLast.next.next != null) {
            secondLast = secondLast.next;
        }

        // Delete the last node
        secondLast.next = null;

        return head;
    }


    // Main method to demonstrate linked list operation
}
