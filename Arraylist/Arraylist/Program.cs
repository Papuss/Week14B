using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            while (true)
            {
                Console.WriteLine("Enter input:"); // Prompt
                string line = Console.ReadLine(); // Get string from user
                if (line != "exit") // Check string
                {
                    lista.Add(line);

                }
                else
                {
                    PrintValues(lista);
                    lista.Sort();
                    Console.Write("The list, sorted \n");
                    PrintValues(lista);
                    Console.Read();
                    break;
                }
            }

        }
        public static void PrintValues(IEnumerable lista)
        {
            foreach (Object obj in lista)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();
        }
    }
}

