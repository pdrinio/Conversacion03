using System;
using System.Collections.Generic;

namespace Conversacion03
{
    class Program
    {
        static void Main(string[] args)
        {
            // objetos
            Presencia MiPresencia = new Presencia();
            Lenguaje MiLenguaje = new Lenguaje();
            Conversacion MiConversacion = new Conversacion();
            Nodo NodoActual = new Nodo();
            string Respuesta;
            string[] RespuestaEnArray;
            List<string> RespuestaEnLista = new List<string>();

            // inicialización
            MiConversacion.NodoInicial = MiLenguaje.NodosLenguaje[0];
            NodoActual = MiConversacion.NodoInicial;

            // preguntamos, y obtenemos respuesta en lista de strings
            Console.WriteLine(NodoActual.MensajeIda.ToString());
            Respuesta = Console.ReadLine();
            RespuestaEnArray = Respuesta.Split(' ');
            foreach (string Palabra in RespuestaEnArray) { RespuestaEnLista.Add(Palabra); };

            foreach (int key in NodoActual.SiguientesPasos.Keys)
            {
                if (NodoActual.SiguientesPasos.ContainsValue(RespuestaEnLista))
                {
                    Console.WriteLine("Ocurrencia localizada en clave: " + key.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}