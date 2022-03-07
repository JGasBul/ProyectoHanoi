using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        //Declaramos Variables.
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        //Constructor Vacio
        public Pila(){}
        //Constructor Pila
        public Pila(int Size)
        {
            this.Size = Size;
            Elementos = new List<Disco>();
            Top = -1;

            for (int i = this.Size; i > 0; i--)
            {
                Elementos.Add(new Disco(i));
                Top = Elementos.Last().Valor;
            }
        }
        
        //Metodo para añadir un disco a la pila
        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = Elementos.Last().Valor;
        }
        
        //Metodo para eliminar un disco de la pila
        public Disco pop()
        {
            Disco d = Elementos.Last();
            Elementos.Remove(d);
            Top = Elementos.Last().Valor;
            return d;
        }

        //Metodo para saber si la lista elementos esta vacia.
        public bool isEmpty()
        {
            return !Elementos.Any();
        }

    }
}
