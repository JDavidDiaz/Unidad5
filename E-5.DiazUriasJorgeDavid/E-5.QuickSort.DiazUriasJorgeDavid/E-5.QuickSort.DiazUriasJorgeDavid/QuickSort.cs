using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_5.QuickSort.DiazUriasJorgeDavid
{
    class QuickSort
    {
        public void Lista()
        {
            List<string> Palabras = new List<string>();           
            string Frase = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. Duis ac massa est";
            foreach (var item in Frase.Split())
            {
                Palabras.Add(item);
            }
            QuickSrt(Palabras, 0, 29 - 1);
            Despliegue(Palabras);
        }

        public void QuickSrt(List<string> Lista, int Primero, int Ultimo)
        {
            int i = Primero;
            int j = Ultimo;
            string leftString = Lista[i];
            string rightString = Lista[j];
            double pivotValue = ((Primero + Ultimo) / 2);
            string middle = Lista[Convert.ToInt32(pivotValue)];
            string temp = null;
            while (i <= j)
            {
                while (Lista[i].CompareTo(middle) < 0)
                {
                    i++;
                    leftString = Lista[i];
                }
                while (Lista[j].CompareTo(middle) > 0)
                {
                    j--;
                    rightString = Lista[j];
                }
                if (i <= j)
                {
                    temp = Lista[i];
                    Lista[i++] = Lista[j];
                    Lista[j--] = temp;
                }
                if (Primero < j)
                {
                    QuickSrt(Lista, Primero, j);
                }
                if (i < Ultimo)
                {
                    QuickSrt(Lista, i, Ultimo);
                }
            }
        }

        public void Despliegue(List<string> Lista) 
        {
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
