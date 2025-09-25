namespace CSharp100Knocks
{
    public class knock24
    {
        public void outputDict()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>(){
                {"apple", "りんご"}
            };
            Console.WriteLine(dict["apple"]);
        }
    }
}