using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> lista = new Dictionary<String, int>();

            lista["zero"] = 0;
            lista["one"] = 1;
            lista["two"] = 2;
            lista["three"] = 3;
            lista["four"] = 4;
            lista["five"] = 5;
            lista["six"] = 6;
            lista["seven"] = 7;
            lista["eight"] = 8;
            lista["nine"] = 9;

            Console.WriteLine("Enter input:"); 
            string line = Console.ReadLine();

            foreach (KeyValuePair<String, int> item in lista)
            {
                
                string text = item.Key;
                if(text == line)
                {
                    int number = item.Value;
                    Console.WriteLine("{0}", number);
                }
                
            }

            Console.ReadLine();

        }
    }
}
