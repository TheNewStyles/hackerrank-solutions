// You’re given the pointer to the head node of a linked list, an integer to add to the list and the position at which the integer must be inserted. Create a new node with the given integer, insert this node at the desired position and return the head node.

// A position of 0 indicates head, a position of 1 indicates one node away from the head and so on. The head pointer given may be null meaning that the initial list is empty.

// As an example, if your list starts as  and you want to insert a node at position  with , your new list should be 

// Funtion Description Complete the function SinglyLinkedListNode in the editor. It must return a reference to the head node of your finished list.

// SinglyLinkedListNode has the following parameters:

// head: a SinglyLinkedListNode pointer to the head of the list
// data: an integer value to insert as data in your new node
// position: an integer position to insert the new node
// Input Format

// The first line contains an integer , the number of elements in the linked list. 
// Each of the next  lines contains an integer node[i].data. 
// The last line contains an integer .

// Constraints

// , where  is the  element of the linked list.
// .
// Output Format

// Return a reference to the list head. Locked code prints the list for you.

// Sample Input

// 3
// 16
// 13
// 7
// 1
// 2
// Sample Output

// 16 13 1 7
// Explanation

// The initial linked list is 16 13 7. We have to insert  at the position  which currently has  in it. The updated linked list will be 16 13 1 7

    // Complete the insertNodeAtPosition function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position) {
        var newNode = new SinglyLinkedListNode(data); 
        var currentNode = head;
        var counter = 0;
        
        while (counter < position-1)
        {            
            currentNode = currentNode.next;  
            counter++;
        }
        
        newNode.next = currentNode.next;   
        currentNode.next = newNode; 
        return head;
    }