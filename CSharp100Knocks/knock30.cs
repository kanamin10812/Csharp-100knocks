namespace CSharp100Knocks
{
    public class knock30
    {
        public void outputTryGetValue()
        {
            var dict = new Dictionary<string, int>()
            {
                { "apple", 100 },
                { "banana", 200 },
                { "orange", 300 }
            };

            if(dict.TryGetValue("banana", out int value))
            {
                Console.WriteLine(value);
            }
        }
    }
}