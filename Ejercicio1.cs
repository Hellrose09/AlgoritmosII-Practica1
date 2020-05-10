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
        public  void Method()
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
                       
                        Console.WriteLine("  Lo sentimos, solo se permiten numeros. reinicie el programa.", ex.Message);
                       Console.WriteLine();
                      Environment.Exit(0);

                    }
                  

                for (int f = 0; f < lista1.Length; f++)
                {
                    Console.WriteLine();
                    Console.Write("     Ingrese elemento " + (f + 1) + ": ");
                    linea = Console.ReadLine();
                    lista1[f] = int.Parse(linea);
                    
                  
                }

               

                #region //Insertion Sort lista 1
                int auxili;
                int j;
                for (int i = 0; i < lista1.Length; i++)
                {
                    auxili = lista1[i];
                    j = i - 1;
                    while (j >= 0 && lista1[j] > auxili)
                    {
                        lista1[j + 1] = lista1[j];
                        j--;
                    }
                    lista1[j + 1] = auxili;


                }
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
                    Environment.Exit(0);

                }
        
              
                for (int f = 0; f < lista2.Length; f++)
                {
                    Console.WriteLine();
                    Console.Write("     Ingrese elemento " + (f + 1) + ": ");
                    linea = Console.ReadLine();
                    lista2[f] = int.Parse(linea);
                   
                  
                }
                #region // Insertion Sort lista 2
                int aux;
                int k; 
                for (int i = 0; i < lista2.Length; i++)
                {
                    aux = lista2[i];
                    k= i - 1;
                    while (k >= 0 && lista2[k] > aux)
                    {
                        lista2[k + 1] = lista2[k];
                        k--;
                    }
                    lista2[k + 1] = aux;

                }


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
                        int a;
                        int b;
                        for (int i = 0; i < mix.Length; i++)
                        {
                            a = mix[i];
                            b = i - 1;
                            while (b >= 0 && mix[b] > a)
                            {
                                mix[b + 1] = mix[b];
                                b--;
                            }
                            mix[b + 1] = a;


                        }
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
                    Environment.Exit(0);

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
