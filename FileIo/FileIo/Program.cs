namespace FileIo
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine(Environment.CurrentDirectory);
            string[] lines = File.ReadAllLines("quiz.txt");
        }
    }
}
