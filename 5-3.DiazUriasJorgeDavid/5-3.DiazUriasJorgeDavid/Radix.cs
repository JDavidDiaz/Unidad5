using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3.DiazUriasJorgeDavid
{
    class Radix
    {
        public void Sort(int[] Lista)
        {
            int i, j; //Inicio y Final
            int[] Temp = new int[Lista.Length]; //Se declara un vector temporal con la longitud de las Listas
            for (int Cambio = 31; Cambio > -1; --Cambio) //Si Cambio es mayor a -1 entonces
            {
                j = 0;
                for (i = 0; i < Lista.Length; ++i) //Si la longitud de la lista es menor a i entonces
                {
                    bool Move = (Lista[i] << Cambio) >= 0; //Cambio se desplaza a la Lista[i] y Move representara true o false dependiendo si es mayor o igual a 0
                    if (Cambio == 0 ? !Move : Move) //Evalúa Move y devuelve el resultado de evaluar una de las dos expresiones (true o false)
                    {  
                        Lista[i - j] = Lista[i]; // Cambia los 0 hasta arriba de la Lista
                    }
                    else 
                    {                            
                        Temp[j++] = Lista[i]; //Mueve los 1 a Temp
                    }
                }
                Array.Copy(Temp, 0, Lista, Lista.Length - j, j); //Se hace una copia del arreglo con distintos parametros
            }
        }

        public void Listas()
        { 
            int[] L1 = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };
            Console.WriteLine("Lista 1:\nAntes: " + string.Join(", " , L1)); //Imprime la lista de numeros antes del ordenamiento
            Sort(L1);                                                        //Ejecuta el metodo de ordenamiento
            Console.WriteLine("Despues: " + string.Join(", ", L1));          //Imprime la lista de numeros despues del ordenamiento
            int[] L2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            Console.WriteLine("\nLista 2:\nAntes: " + string.Join(", ", L2));
            Sort(L2);
            Console.WriteLine("Despues: " + string.Join(", ", L2));
            int[] L3 = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };
            Console.WriteLine("\nLista 3:\nAntes: " + string.Join(", ", L3));
            Sort(L3);
            Console.WriteLine("Despues: " + string.Join(", ", L3));
            int[] L4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            Console.WriteLine("\nLista 4:\nAntes: " + string.Join(", ", L4));
            Sort(L4);
            Console.WriteLine("Despues: " + string.Join(", ", L4));
            int[] L5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 };
            Console.WriteLine("\nLista 5:\nAntes: " + string.Join(", ", L5));
            Sort(L5);
            Console.WriteLine("Despues: " + string.Join(", ", L5));
        }
    }
}
