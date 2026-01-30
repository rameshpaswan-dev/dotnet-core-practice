using SimpleTextEditor.interfaces;
using SimpleTextEditor.Services;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Text Editor");
            ITextEditor editor = new TextEditorService();
            bool running  = true;
            while (running)
            {
                Console.WriteLine("\n==== Mini Text Editor ====");
                Console.WriteLine("1. Create a File");
                Console.WriteLine("2. Write Text");
                Console.WriteLine("3. Append Text");
                Console.WriteLine("4. Read File");
                Console.WriteLine("5. Delete File");
                Console.WriteLine("6. Exit File");

                Console.Write("Choose Options: ");

                bool isValid = int.TryParse(Console.ReadLine(), out int choise);

                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
                if(choise == 6)
                {
                    Console.WriteLine("Exiting Editor....");
                    break;
                }

                Console.Write("Enter File Name: ");

                string fileName = Console.ReadLine();

                try
                {
                    switch (choise)
                    {
                        case 1:
                            editor.CreateFile(fileName);
                            break;
                        case 2:
                            Console.Write("Enter text: ");
                            editor.WriteText(fileName, Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("Enter Text: ");
                            editor.AppendText(fileName, Console.ReadLine());
                            break;
                        case 4:
                            editor.ReadText(fileName);
                            break;
                        case 5:
                            editor.DeleteText(fileName);
                            break;
                        default:
                            Console.WriteLine("Invalid choise.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);

                }
            }
        }
    }
}
