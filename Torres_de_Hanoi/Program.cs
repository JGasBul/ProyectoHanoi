﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Keep the console window open in debug mode.
            bool run = false;
            Console.WriteLine("Bienvenido a las torres de hanoi.");
            Console.WriteLine("Pulse 1 si quiere usar el modo iterativo o el 2 si quiere usar el modo recursivo.");
            do
            {
                String modoString = Console.ReadLine();
                if (Int32.TryParse(modoString, out int modo))
                {
                    switch (modo)
                    {
                        case 1:
                            Console.WriteLine("Se ha elejido el modo iterativo");
                            Console.WriteLine("Ahora elija con cuantas piezas quiere hacer el puzle.");
                            Console.WriteLine("El programa el mostrara cuantos movimientos hacen falta para resolver el puzle.");
                            do
                            {
                                String piezasString = Console.ReadLine();
                                if (Int32.TryParse(piezasString, out int piezas))
                                {
                                    if (piezas <= 0)
                                    {
                                        Console.WriteLine("No se admiten numeros menores que 0.");
                                    }
                                    else
                                    {
                                        Pila ini = new Pila(piezas);
                                        Pila aux = new Pila();
                                        Pila fin = new Pila();
                                        int movimientos = new Hanoi().iterativo(piezas, ini, fin, aux);
                                        Console.WriteLine("Con " + piezas + " piezas se han necesitado " + movimientos + " movimientos para resolver el puzle");
                                        Console.ReadLine();
                                        run = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No se admiten palabras, intruduzca de manera numerica el numero de piezas que quiere.");
                                }
                            } while (!run);

                            break;
                        case 2:
                            Console.WriteLine("Se ha elejido el modo recursivo, en proceso de construccion.");
                            Console.ReadLine();
                            run = true;
                            break;
                        default:
                            Console.WriteLine("Por favor, pulsar 1 para modo iterativo o 2 para modo recursivo. No se admiten mas opciones");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("No se admiten palabras, pulse 1 si quiere usar el modo iterativo o el 2 si quiere usar el modo recursivo.");
                }
            } while (!run);
        }
    }
}
