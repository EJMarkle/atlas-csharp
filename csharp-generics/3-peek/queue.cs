using System;

/// <summary>
/// Queue class
/// </summary>
class Queue<T>
{
    /// <summary>
    /// Queue node
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
    /// Node count
    /// </summary>
    public int Count()
    {
        return count;
    }
    /// <summary>
    /// Remove node
    /// </summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;

        if (head == null)
        {
            tail = null;
        }

        count--;

        return value;
    }
    /// <summary>
    /// Gets 1st node value
    /// </summary>
    /// <returns></returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }
}