using System;

namespace Practica1
{
    class Program
    {

        static string Opcion;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("-------------BIENVENIDO AL PROGRAMA---------------");
                Console.WriteLine();
                Console.WriteLine("    1. Ordenar dos arreglos.");
                Console.WriteLine("    2. Tuercas y tornillos. ");
                Console.WriteLine("    3. Salir.");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("         Elija la opcion que desea[1-3] : ");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {

                    case 1:
                        Ejercicio1 ejercicio1 = new Ejercicio1();
                        ejercicio1.PrincipalMethod();
                        break;

                    case 2:
                        char[] tuercas = { 'a', 'b', 'c', 'e', 'f', 'g' };
                        char[] tornillos = { 'c', 'e', 'g', 'f', 'a', 'b' };

                        Ejercicio2 ejercicio2 = new Ejercicio2();
                        ejercicio2.Pares(tuercas, tornillos, 0, 5);
                        Console.ReadKey();

                        break;

                    case 3:

                        Environment.Exit(0);
                        break;
                }



            }







        }
    }
}

