using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1.DiazUriasJorgeDavid
{
    class Bubble
    {
        public void Burbuja()
        {
            int Cantidad;
            Console.Write("Ingrese la longitud del vector: "); //Se le pide al usuario ingresar la cantidad de numero de elementos
            Cantidad = int.Parse(Console.ReadLine());
            int [] Vector = new int[Cantidad]; //Se inicializa un vector con la cantidad que ingreso el usuario
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.Write("Ingrese el elemento {0}: " , i + 1); //Pregunta al usuario el valor de cada elemento
                Vector[i] = int.Parse(Console.ReadLine());
            }
            int Temp;
            for (int j = 1; j < Vector.Length; j++) //For para ejecutar la cantidad de veces segun la cantidad de elementos del vector
            {   //For para hacer la comparacion y ordenamiento de los valores
                for (int k = Vector.Length - 1; k >= j; k--) //Si el contador k es mayor o igual que el contador j entonces:
                {
                    if (Vector[k - 1] > Vector[k]) //Si el valor anterior es mayor al valor actual entonces:
                    {
                        Temp = Vector[k - 1]; //Se toma el valor anterior y lo guarda en la variable temporal
                        Vector[k - 1] = Vector[k]; //Se cambia el valor anterior por el valor actual
                        Vector[k] = Temp; //Se le asigna el valor temporal al valor actual
                    }
                }
            }
            Console.WriteLine("\nValores ordenados:");
            for (int i = 0; i < Vector.Length; i++) //Imprime los elementos ordenados
            {
                Console.Write(Vector[i] + "  "); 
            }
        }
    }
}
