using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void Mover_disco(Pila a, Pila b)
        {
            if (a.Top < b.Top)
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
            
            return 0;
        }

    }
}
