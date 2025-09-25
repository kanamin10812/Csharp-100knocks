namespace CSharp100Knocks
{
    public class knock26
    {
        public void outputStack()
        {
            var stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            
            Console.WriteLine(stack.Pop());
        }
    }
}