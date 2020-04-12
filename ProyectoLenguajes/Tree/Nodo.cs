using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLenguajes.Tree
{
    class Nodo<T>
    {
        public Nodo<T> Izquierda { get; set; }
        public Nodo<T> Derecha { get; set; }
        public T Valor { get; set; }
        public List<int> First = new List<int>();
        public List<int> Last = new List<int>();
        public bool Nullable;
        public int Posicion;
    }
}
