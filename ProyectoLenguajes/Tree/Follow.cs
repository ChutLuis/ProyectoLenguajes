using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLenguajes.Tree
{
    class Follow
    {
        public string Valor { get; set; }       
        public int Posicion { get; set; }
        public List<int> FollowValues = new List<int>();
    }
}
