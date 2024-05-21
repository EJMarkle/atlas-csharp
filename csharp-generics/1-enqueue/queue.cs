using System;

/// <summary>
/// Queue class
/// </summary>
class Queue<T>
{
    /// <summary>
    /// Queue nodes
    /// </summary>
    public class Node
    {
        public T value;
        public Node next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    /// <summary>
    /// Add node
    /// </summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }
    /// <summary>
    /// Get node count
    /// </summary>
    public int Count()
    {
        return count;
    }
}