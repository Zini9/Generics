using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando classe
            PrintService printService = new PrintService();


            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            // Imprimir todos elementos
            printService.Print();

            Console.WriteLine("Firt: " + printService.Firt());

        }
    }
}
