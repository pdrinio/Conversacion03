using System;
using System.Collections.Generic;
using System.Text;

namespace Conversacion03
{
    class Respuesta
    {
        public int SiguientePaso { get; set; }
        public List<string> TextoDevuelto { get; set; }


        public Respuesta()
        {
            SiguientePaso = 0;
            
        }

        public Respuesta(int _SiguientePaso, List<string> _TextoDevuelto)
        {
            SiguientePaso = _SiguientePaso;
            TextoDevuelto = _TextoDevuelto;
        }
    }
}
