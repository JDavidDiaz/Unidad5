using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_5.RadixSort.DiazUriasJorgeDavid
{
    class Radix
    {
        public int[] NumerosRandom()
        {
            Random Aleatorio = new Random();
            int[] Vector = new int[80];
            int i = 0;
            while (true)
            {
                for (i += i; i < 80; i++)
                {
                    Vector[i] = Aleatorio.Next();
                    if (Vector[i] < 0)
                    {
                        i = i - 1;
                        continue;
                    }
                }
                break;   
            }

            int j, k; 
            int[] Temp = new int[Vector.Length]; 
            for (int Cambio = 31; Cambio > -1; --Cambio) 
            {
                k = 0;
                for (j = 0; j < Vector.Length; ++j) 
                {
                    bool Move = (Vector[j] << Cambio) >= 0; 
                    if (Cambio == 0 ? !Move : Move) 
                    {
                        Vector[j - k] = Vector[j]; 
                    }
                    else
                    {
                        Temp[k++] = Vector[j]; 
                    }
                }
                Array.Copy(Temp, 0, Vector, Vector.Length - k, k); 
            }
            return Vector;
        }
    }
}
