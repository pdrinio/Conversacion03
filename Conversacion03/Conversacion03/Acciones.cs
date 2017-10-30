using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversacion03
{
    class Acciones
    {
        public static void NoHacerNada() { }

        public static Presencia DarEntrada(Presencia MiPresencia, List<object> argumentos)
        {            
            //List<string> Nombres = new List<string>(); me gusta más declarar esto que usar var, pero la vida moderna no va por ahí
            var Nombres = argumentos.Select(s => (string)s).ToList();
    
            foreach (string nombre in Nombres) {
                //TODO: controlar que no estaba ya en la lista; pasar de string a List
                MiPresencia.Add(nombre);
            }

            return MiPresencia;
        }

        public static Presencia DarSalida(Presencia MiPresencia, List<object> argumentos)
        {
            var Nombres = argumentos.Select(s => (string)s).ToList();

            foreach (string nombre in Nombres)
            {
                //TODO: controlar que no estaba ya en la lista; pasar de string a List
                MiPresencia.Remove(nombre);
            }

            return MiPresencia;
        }

    }
}
