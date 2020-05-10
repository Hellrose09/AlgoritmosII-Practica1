using System;

namespace Practica1
{
    class Program
    {

        static string Opcion;

        static void Main(string[] args)
        {
          
            do
            {
                Ejercicio1 ejercicio1 = new Ejercicio1();
                ejercicio1.Method();


                Console.Clear();
                Console.WriteLine();
                Console.Write("Presione Enter para continuar con el siguiente ejercicio: ");
                Console.Read();
                Console.Clear();

                do
                {
                    char[] tuercas = { 'a', 'b', 'c', 'e', 'f', 'g' };
                    char[] tornillos = { 'c', 'e', 'g', 'f', 'a', 'b' };

                    Ejercicio2 ejercicio2 = new Ejercicio2();
                    ejercicio2.Pares(tuercas, tornillos, 0, 5);

                    Console.WriteLine();
                    Console.Write("  ¿Desea reiniciar el programa? (si o no): ");
                     Opcion = Console.ReadLine().ToLower();
                     Console.WriteLine("");

                } while (Opcion != "s" && Opcion != "n" && Opcion != "si" && Opcion != "no");


            } while (Opcion == "s" || Opcion == "si");
           




        }
    }
}
