namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> personeelnummer = new Dictionary<int,string>();

            personeelnummer.Add(382942, "jim");
            personeelnummer.Add(382941, "zim");
         
            
            string jim = personeelnummer[382942];
            string zim = personeelnummer[382941];

            foreach (int key in personeelnummer.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string value in personeelnummer.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
