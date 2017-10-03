using System;
using System.Collections.Generic;
using System.Text;

namespace Conversacion03
{
    class Acciones
    {

        public static void NoHacerNada() { }

        public static void DarEntrada(string Persona, Presencia MiPresencia)
        {

            //TODO: controlar que no estaba ya en la lista; pasar de string a List
            MiPresencia.Add(Persona);
            
        }
    }
}
