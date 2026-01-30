namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            FileHandling file = new FileHandling();
            file.CreateFile("Hello");
        }
    }
}
