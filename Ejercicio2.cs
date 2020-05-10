using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    public  class Ejercicio2
    {

        private static void PrintArray(char[] arr)
        {

            foreach (char ch in arr)
            {
                Console.Write(ch + " ");
            }
            Console.Write("\n");


        }

        public  void Pares(char[] nuts, char[] bolts, int low, int high)
        {
             
            if (low < high)
            {

                int bases = Division(nuts, low, high, bolts[high]);

                Division(bolts, low, high, nuts[bases]);

                Pares(nuts, bolts, low, bases - 1);
                Pares(nuts, bolts, bases + 1, high);
                
                

            }

            Console.WriteLine();
            Console.WriteLine("Movimientos de  ordenamiento");
            Console.WriteLine();
            PrintArray(nuts);
            PrintArray(bolts);



        }

        

        private static int Division(char[] arr, int low, int high, char bases2)
        {
            int i = low;
            char posicion1, posicion2;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < bases2)
                {
                    posicion1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = posicion1;
                    i++;
                }
                else if (arr[j] == bases2)
                {
                    posicion1 = arr[j];
                    arr[j] = arr[high];
                    arr[high] = posicion1;
                    j--;
                }
            }
            posicion2 = arr[i];
            arr[i] = arr[high];
            arr[high] = posicion2;

            return i;

           
        }

    }
}
