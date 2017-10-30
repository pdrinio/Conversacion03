using System;
using System.Collections.Generic;
using System.Text;

namespace Conversacion03
{
    class Respuesta
    {
        public int SiguientePaso { get; set; }
        public List<string> MensajeVuelta { get; set; }
        public Nodo NodoActual;


        public Respuesta()
        {
            SiguientePaso = 0;
            
        }

        public Respuesta(int _SiguientePaso, List<string> _MensajeVuelta, Nodo _NodoActual)
        {
            SiguientePaso = _SiguientePaso;
            MensajeVuelta = _MensajeVuelta;
            NodoActual = _NodoActual;
        }
    }
}
