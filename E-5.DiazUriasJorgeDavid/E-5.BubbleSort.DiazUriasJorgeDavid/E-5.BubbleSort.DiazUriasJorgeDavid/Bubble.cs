using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_5.BubbleSort.DiazUriasJorgeDavid
{
    class Bubble
    {
        public void Captura()
        {
            Console.Write("Ingrese la longitud del vector: ");
            int Cantidad = int.Parse(Console.ReadLine());
            int[] Vector = new int[Cantidad];
            Console.WriteLine("Ingrese los numeros del vector (solo: 0, 1, 2)");
            int i = 0;
            while (true)
            {
                for (i += i; i < Cantidad; i++)
                {
                    Console.WriteLine("\nNumero {0}", i + 1);
                    Vector[i] = int.Parse(Console.ReadLine());
                    if (Vector[i] > 2 || Vector[i] < 0)
                    {
                        Console.WriteLine("Numero Invalido");
                        i = i - 1;
                        continue;
                    }
                }
                break;
            }
            BubbleSort(Vector);
        }

        public void BubbleSort(int[] Vector)
        {
            int Temp;
            for (int i = 1; i < Vector.Length; i++) 
            {   
                for (int j = Vector.Length - 1; j >= i; j--) 
                {
                    if (Vector[j - 1] > Vector[j]) 
                    {
                        Temp = Vector[j - 1]; 
                        Vector[j - 1] = Vector[j]; 
                        Vector[j] = Temp; 
                    }
                }
            }
            Console.WriteLine("\nValores ordenados:");
            for (int i = 0; i < Vector.Length; i++) 
            {
                Console.Write(Vector[i] + "  ");
            }
        }
    }
}
