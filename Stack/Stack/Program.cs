using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var elsoLista = new Stack<int>();
            Console.WriteLine("If 0 (zero) is given program quit, and shoe the reversed numbers");
            while (true)
            {
                Console.WriteLine("Enter input:"); 
                int line = Convert.ToInt32(Console.ReadLine()); 
                if (line != 0) 
                {
                    elsoLista.Push(line);

                }
                else
                {
                    
                    foreach(int i in elsoLista)
                    {
                        Console.WriteLine(i);
                    }
                    var masodikLista = new Stack<int>(elsoLista);
                    Console.Write("Reversed numbers: \n");
                    foreach (int i in masodikLista)
                    {
                        Console.WriteLine(i);
                    }
                    /* valójában a második listában szerepelnek a számok eredeti sorrendben, mivel a a foreachel
                    a Stack tetejéről vesszük ki egyesével a számokat tehát az utoljára bevitt szám lesz az 1. helyen
                    és így tovább*/
                    Console.Read();
                    break;
                }
            }

        }
  
        }
    }
