using System;

class Program
{
    static void Main(string[] args)
    {
        ShortQueue<int> queue = new ShortQueue<int>(5);

        queue.Add(1);
        queue.Add(2);
        queue.Add(3);
        queue.Add(4);
        queue.Add(5);

        Console.WriteLine("Initial queue:");
        PrintQueue(queue);

        queue.Add(6);

        Console.WriteLine("After adding 6:");
        PrintQueue(queue);

        bool removed = queue.Remove(3);

        Console.WriteLine($"Removed 3: {removed}");
        Console.WriteLine("After removing 3:");
        PrintQueue(queue);

        queue.Clear();

        Console.WriteLine("After clearing:");
        PrintQueue(queue);
    }

    static void PrintQueue<T>(ShortQueue<T> queue)
    {
        foreach (T item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}