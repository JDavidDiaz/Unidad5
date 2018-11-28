using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2.DiazUriasJorgeDavid
{
    class QuickS
    {
        int NumListas = 0; //Se inicializa la variable en 0 que servira como contador para el numero de listas
        public void Listas()
        {
            double[] Lista1 = new double[] { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 }; //Lista 1 de numeros
            QuickSort(Lista1, 0, 10 - 1); //Hace llamar al metodo QuickSort
            Despliegue(Lista1, 10); //Metodo para impresion de los datos
            double[] Lista2 = new double[] { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0 , 10 }; //Lista 2 de numeros
            QuickSort(Lista2, 0, 12 - 1);
            Despliegue(Lista2, 12);
            double[] Lista3 = new double[] { 3, 7, 15, (4/3), 155, 100, 15, Math.Sqrt(3), 5, 2, 3, 2 }; //Lista 3 de numeros
            QuickSort(Lista3, 0, 12 - 1);
            Despliegue(Lista3, 12);
            double[] Lista4 = new double[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 }; //Lista 3 de numeros
            QuickSort(Lista4, 0, 10 - 1);
            Despliegue(Lista4, 10);
        }

        public void QuickSort(double[] Lista, int Primero, int Ultimo) //Recibe como parametros el vector, 0 y la cantidad de numeros del arreglo -1
        {
            int i, j, Central;
            double Pivote;
            Central = (Primero + Ultimo) / 2; //Obtiene el numero dado de la suma del primer y ultimo numero / 2 que sera la posicion del pivote
            Pivote = Lista[Central]; //Se inicializa el pivote que sera el numero con la posicion obtenida del arreglo
            i = Primero;
            j = Ultimo;
            do
            {   //Ciclos para saber que numero es mayor que el pivote y cual es menor y posteriormente se acomodaran dependiendo su valor
                while (Lista[i] < Pivote) i++;
                while (Lista[j] > Pivote) j--;
                if (i <= j) //Si el primero valor es menor o igual al ultimo entonces
                {
                    double Temp; //Se inicializa una variable temporal 
                    Temp = Lista[i]; //Obtiene el valor del numero del arreglo con el valor actual del contador
                    Lista[i] = Lista[j]; //Se intercambian los valores entre el primero y el ultimo
                    Lista[j] = Temp; //El ultimo tendra ahora el valor de la variable temporal
                    i++; //Se suma y se resta 1 a los valores actuales i y j
                    j--;
                }
            } while (i <= j); //Se repite el ciclo si se cumple la condicion
            if (Primero < j) //Si el primer valor es menor al valor de J entonces
            {
                QuickSort(Lista, Primero, j); //Se llama al metodo asi mismo
            }
            if (i < Ultimo) //Si el valor de i es menor al ultimo valor entonces
            {
                QuickSort(Lista, i, Ultimo); //Se llama al metodo asi mismo
            }
        }

        public void Despliegue(double[] Lista, int Cantidad) //Recibe como parametros la lista y el contador actual del numero de listas
        {
            NumListas++; //Incrementa el contador
            Console.WriteLine("\nLista {0}:", NumListas);
            for (int i = 0; i < Cantidad; i++) //Despliegue del arreglo con los numeros ya ordenados con el motodo QuickSort
            {
                Console.Write("{0}, ", Lista[i]);
            }
            Console.WriteLine("");
        }
    }
}
