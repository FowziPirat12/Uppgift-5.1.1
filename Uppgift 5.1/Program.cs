using System; 
namespace Uppgitfr_5._1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] mening = new string[3];
            for (int i = 0; i < 3; i++)
            {
               Console.WriteLine("skriv ner några meningar:" + mening[i]);
               mening[i] = Console.ReadLine();
               Console.WriteLine();
                
            }
        }
    }
}