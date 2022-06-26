using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(3);
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine(queue.ToString());
        }
    }
}
