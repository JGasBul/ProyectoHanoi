using System;
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
                            Console.WriteLine("Se ha elejido el modo recursivo");
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
                                        int movimientos = new Hanoi().recursivo(piezas, ini, fin, aux);
                                        Console.WriteLine("Con " + piezas + " piezas se han necesitado " + movimientos + " movimientos para resolver el puzle");
                                        run = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No se admiten palabras, intruduzca de manera numerica el numero de piezas que quiere.");
                                }
                            } while (!run);
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
                if (run)
                {
                    Console.WriteLine("¿Quiere probar otra vez? Pulse 1. Por el contrario, pulse 0 para salir.");
                    int rerun = -1;
                    do
                    {
                        String rerunString = Console.ReadLine();
                        if (Int32.TryParse(rerunString, out int x))
                        {
                            rerun = x;
                            switch (rerun)
                            {
                                case 0:
                                    Console.WriteLine("Hasta luego, ten un buen dia");
                                    Console.ReadLine();
                                    break;
                                case 1:
                                    Console.WriteLine("Perfecto, pulse 1 si quiere usar el modo iterativo o el 2 si quiere usar el modo recursivo");
                                    run = false;
                                    break;
                                default:
                                    Console.WriteLine("No se admiten mas opciones, 1 para seguir, 0 para salir");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se admiten palabras, intruduzca de manera numerica lo que quiere hacer a continuación.");
                        }
                    } while (rerun != 1 && rerun != 0);
                }
            } while (!run);
        }
    }
}
