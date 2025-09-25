namespace CSharp100Knocks
{
    public class knock28
    {
        public void outputSort()
        {
            var array = new int[] { 4, 7, 1, 8, 5 };
            Console.WriteLine(string.Join(",", array.OrderBy(n => n)));
        }
    }
}