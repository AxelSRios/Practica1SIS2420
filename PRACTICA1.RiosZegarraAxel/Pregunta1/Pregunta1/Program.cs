using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Pregunta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                string parteLiteral = numero.ToWords();
                Console.WriteLine($"En su parte literal: {parteLiteral}");
            }
            else
            {
                Console.WriteLine("No ingresaste un número válido.");
            }
        }
    }
}
