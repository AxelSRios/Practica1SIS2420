using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos números deseas añadir? ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                List<int> numeros = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Añade el número {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        numeros.Add(numero);
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
                        i--;
                    }
                }

                List<int> multiplosDe2 = new List<int>();
                List<int> primos = new List<int>();
                List<int> multiplosDe5 = new List<int>();
                List<int> perfectos = new List<int>();

                foreach (int numero in numeros)
                {
                    if (numero % 2 == 0)
                    {
                        multiplosDe2.Add(numero);
                    }

                    if (EsPrimo(numero))
                    {
                        primos.Add(numero);
                    }

                    if (numero % 5 == 0)
                    {
                        multiplosDe5.Add(numero);
                    }

                    if (EsNumeroPerfecto(numero))
                    {
                        perfectos.Add(numero);
                    }
                }

                Console.WriteLine($"Lista 1 (Múltiplos de 2): {string.Join(", ", multiplosDe2)}");
                Console.WriteLine($"Lista 2 (Primos): {string.Join(", ", primos)}");
                Console.WriteLine($"Lista 3 (Múltiplos de 5): {string.Join(", ", multiplosDe5)}");
                Console.WriteLine($"Lista 4 (Perfectos): {string.Join(", ", perfectos)}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número válido para la cantidad de números.");
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        static bool EsNumeroPerfecto(int numero)
        {
            int sumaDivisores = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores == numero;
        }
    }
}
    
