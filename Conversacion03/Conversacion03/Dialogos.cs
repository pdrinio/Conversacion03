using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversacion03
{
    class Dialogos
    {
        public static List<string> FormulaPregunta(Nodo _NodoActual)
        {
            Console.WriteLine(_NodoActual.MensajeIda.ToString()); //lanzamos la pregunta del nodo

            var Respuesta = Console.ReadLine(); //la leemos y generamos una lista con ella
            var RespuestaEnArray = Respuesta.Split(' ');
            List<string> _RespuestaEnLista = new List<string>();
            foreach (string Palabra in RespuestaEnArray) { _RespuestaEnLista.Add(Palabra.ToUpper()); };

            return _RespuestaEnLista; //devolvemos la lista de lo que el usuario me ha dado
        }

        public static int EvaluaSiguientePaso(Nodo _NodoActual, List<string> _RespuestaEnLista)
        {
            foreach (int key in _NodoActual.SiguientesPasos.Keys)
            {

                if (_NodoActual.SiguientesPasos[key].Any(s => _RespuestaEnLista.Contains(s.ToUpper())))
                {
                    Console.WriteLine("Ocurrencia localizada en clave: " + key.ToString()); //DEBUG
                    return key;
                }         
            }
            Console.WriteLine("No te he entendido");
            return 0;
        }
    }
}
