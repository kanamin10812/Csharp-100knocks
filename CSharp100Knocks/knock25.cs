namespace CSharp100Knocks
{
    public class knock25
    {
        public void outputQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            Console.WriteLine(queue.Dequeue());
        } 
    }
}