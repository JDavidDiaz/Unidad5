using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_5.ShellSort.DiazUriasJorgeDavid
{
    class ShellSort
    {
        public void Captura()
        {
            Console.Write("Ingrese la longitud del vector: ");
            int Cantidad = int.Parse(Console.ReadLine());
            int[] Vector = new int[Cantidad];
            int Longitud = Vector.Length;
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("Ingrese el valor {0}", i + 1);
                Vector[i] = int.Parse(Console.ReadLine());
            }
            ShellSrt(Vector, Longitud);
            Impresion(Vector);
        }

        public void ShellSrt(int[] Vector, int Longitud)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < Longitud; i++)
                {
                    j = i;
                    temp = Vector[i];
                    while ((j >= inc) && (Vector[j - inc] < temp))
                    {
                        Vector[j] = Vector[j - inc];
                        j = j - inc;
                    }
                    Vector[j] = temp;
                }
                if (inc / 2 != 0)
                {
                    inc = inc / 2;
                }
                else if (inc == 1)
                {
                    inc = 0;
                }
                else
                {
                    inc = 1;
                }
            }
        }

        public void Impresion(int[] Vector)
        {
            Console.WriteLine("\nValores Ordenados de Mayor a Menor:");
            foreach (var item in Vector)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
    }
}
