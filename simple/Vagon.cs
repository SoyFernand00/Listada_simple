using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple
{
    internal class Vagon
    {


        public int Dato { get; set; }
        public Vagon Sig { get; set; }
        public Vagon(int dato, Vagon sig)
        {
            Dato = dato;
            Sig = sig;
        }
    }
}
