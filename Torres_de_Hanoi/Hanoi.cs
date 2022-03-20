using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public int movements { get; set; }
        public Hanoi()
        {
            movements = 0;
        }
        /*TODO: Implementar métodos*/
        public void Mover_disco(Pila a, Pila b)
        {
            if (a.Top == 0)
            {
                if (b.Top > 0)
                {
                    a.push(b.pop());
                }
            }
            else if (b.Top == 0)
            {
                if (a.Top > 0)
                {
                    b.push(a.pop());
                }
            }
            else if (a.Top < b.Top)
            {
                b.push(a.pop());
            }
            else
            {
                a.push(b.pop());
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            //Comprobamos si num es un número par o no
            if ((n % 2) == 0)
            {
                do
                {
                    Mover_disco(ini, aux);
                    movements++;
                    Mover_disco(ini, fin);
                    movements++;
                    if (fin.Elementos.Count < n)
                    {
                        Mover_disco(aux, fin);
                        movements++;
                    }
                } while (fin.Elementos.Count < n);
            }
            else
            {
                do
                {
                    Mover_disco(ini, fin);
                    movements++;
                    if (fin.Elementos.Count < n)
                    {
                        Mover_disco(ini, aux);
                        movements++;
                        Mover_disco(aux, fin);
                        movements++;
                    }
                } while (fin.Elementos.Count < n);
            }
            return movements;
        }
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 1)
            {
                Mover_disco(ini, fin);
                movements++;
            }
            else
            {
                recursivo(n - 1, ini, aux, fin);
                Mover_disco(ini, fin);
                movements++;
                recursivo(n - 1, aux, fin, ini);
            }
            return movements;
        }

    }
}
