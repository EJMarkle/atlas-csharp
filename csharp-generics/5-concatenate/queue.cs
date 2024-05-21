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

        /// <summary>
        /// Node
        /// </summary>
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
    /// New node
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
    /// Get 1st node
    /// </summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    /// <summary>
    /// Print queue
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    /// <summary>
    /// Concat all values in queue
    /// </summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        Node current = head;
        string result = "";

        while (current != null)
        {
            result += current.value.ToString();
            if (typeof(T) == typeof(string) && current.next != null)
            {
                result += " ";
            }
            current = current.next;
        }

        return result;
    }
}