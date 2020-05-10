using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Practica1
{
    public class Ejercicio1
    {
        private int[] lista1;
        private int[] lista2;
        private int[] mix;
       
        
        static string Resp;

        private static void InsertionSort(int[] arr)
        {
            int aux;
            int j;

            for (int i = 0; i < arr.Length; i++)
            {
                aux = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > aux)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = aux;

            }



        }
        public  void PrincipalMethod()
        {
            #region // Menu
            do
            {
                Stopwatch tiempo = Stopwatch.StartNew();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("  **************BIENVENIDO AL PROGRAMA**************  ");
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine("           |||Metodo de Insertion Sort||| ");
                Console.WriteLine();
                #endregion
                #region //primera lista
                Console.WriteLine("");
                Console.Write("     Digite la longitud de la lista 1: ");
                string linea;
                int cant;
                linea = Console.ReadLine();
                
                    try
                    {
                        cant = int.Parse(linea);
                        lista1 = new int[cant];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();

                        Console.WriteLine("    Lo sentimos, solo se permiten numeros.", ex.Message);
                        Console.WriteLine();
                    Console.WriteLine("     Responda si o no a la siguiente pregunta:");
                        Console.WriteLine();
                       Console.Write("   Volver al menu principal?  ");
                         string choice = Console.ReadLine();
                        switch (choice)
                        {
                              case "si":
                               PrincipalMethod();
                                break;

                                case "s":
                                PrincipalMethod();
                                     break;

                            case "no":
                            Console.WriteLine();
                            Console.Write("   Presione Enter para salir: ");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                                case "n":
                            Console.WriteLine();
                            Console.Write("   Presione Enter para salir: ");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;         

                         }

                    
                    }

                
                for (int f = 0; f < lista1.Length; f++)
                {
                    Console.WriteLine();
                    Console.Write("     Ingrese elemento " + (f + 1) + ": ");
                    linea = Console.ReadLine();
                    lista1[f] = int.Parse(linea);
                    
                  
                }

                #region //Insertion Sort lista 1
       
                InsertionSort(lista1);
                #endregion
                Console.WriteLine("");
                #endregion



                #region// Segunda lista
                Console.Write("     Digite la longitud de la lista 2: ");
                string line;
                line = Console.ReadLine();
                int cantidad;


                try
                {
                    cantidad = int.Parse(line);
                    lista2 = new int[cantidad];
                }
                catch (Exception ex)
                {
                    Console.WriteLine();

                    Console.WriteLine("  Lo sentimos, solo se permiten numeros. reinicie el programa.", ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("     Responda si o no a la siguiente pregunta:");
                    Console.WriteLine();
                    Console.Write("   Volver al menu principal?  ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "si":
                            PrincipalMethod();
                            break;

                        case "s":
                            PrincipalMethod();
                            break;

                        case "no":
                            Console.WriteLine();
                            Console.Write("   Presione Enter para salir: ");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        case "n":
                            Console.WriteLine();
                            Console.Write("   Presione Enter para salir: ");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                    }

                }
        
              
                for (int f = 0; f < lista2.Length; f++)
                {
                    Console.WriteLine();
                    Console.Write("     Ingrese elemento " + (f + 1) + ": ");
                    linea = Console.ReadLine();
                    lista2[f] = int.Parse(linea);
                   
                  
                }
                #region // Insertion Sort lista 2
            
                InsertionSort(lista2);

                #endregion
                #endregion

                #region // mix
                mix = lista1.Concat(lista2).ToArray();
                #endregion
                #region //opciones de visualizacion
                Console.WriteLine();
                Console.WriteLine("   ---Opciones de visualizacion---");
                Console.WriteLine();
                Console.WriteLine($"    1) Ascendente \t 2) Descendente ");
                Console.WriteLine();
                Console.Write("  Elija la opcion que desea [1-2]: ");
                
                

                try
                {
                    short opcion = short.Parse(Console.ReadLine());
                    if (opcion == 1)
                    {
                        InsertionSort(mix);

                        Console.WriteLine();
                        Console.WriteLine("   Lista ordenada en forma ascendente");
                        Console.WriteLine();
                        for (int f = 0; f < mix.Length; f++)
                        {
                            Console.WriteLine("  Posicion " + (f + 1) + ": " + mix[f]);
                        }


                    }
                    else
                    {
                        if (opcion == 2)
                        {
                            int var;
                            for (int i = 0; i < mix.Length; i++)
                            {
                                for (int m = 0; m < mix.Length - 1; m++)
                                {
                                    if (mix[m] < mix[m + 1])
                                    {
                                        var = mix[m];
                                        mix[m] = mix[m + 1];
                                        mix[m + 1] = var;
                                    }
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("   Lista ordenada en forma descendente");

                            Console.WriteLine();

                            for (int f = 0; f < mix.Length; f++)
                            {

                                Console.WriteLine("   Posicion " + (f + 1) + ": " + mix[f]);
                            }
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("  Lo sentimos, seleccione una opcion que se encuentre en el menu de visualizacion.");

                        }
                           
                    }
             
                }
                catch (Exception ex)
                {
                    Console.WriteLine();

                    Console.WriteLine("  Lo sentimos, solo se permiten numeros. reinicie el programa.", ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("     Responda si o no a la siguiente pregunta:");
                    Console.WriteLine();
                    Console.Write("   Volver al menu principal?  ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "si":
                            PrincipalMethod();
                            break;

                        case "s":
                            PrincipalMethod();
                            break;

                        case "no":
                            Console.WriteLine();
                            Console.Write("   Presione Enter para salir: ");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        case "n":
                            Console.WriteLine();
                            Console.Write("   Presione Enter para salir: ");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                    }

                }
                Console.WriteLine();
                #endregion

                Console.Write($" La cantidad de tiempo que tardo en procesar todo es de: {tiempo.Elapsed.TotalMilliseconds.ToString()}");
                Console.WriteLine();
                do
                {
                    Console.WriteLine();
                    Console.Write("  ¿Desea reiniciar el ejercicio? (si o no): ");
                    Resp = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                } while (Resp != "s" && Resp != "n" && Resp != "si" && Resp != "no");


            } while (Resp == "s" || Resp == "si");
            

        }
    }
}
