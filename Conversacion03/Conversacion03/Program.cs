using System;
using System.Linq;
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
            List<string> RespuestaEnLista = new List<string>();


            // inicialización
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int SiguientePaso = 0; // empezamos en el primer nodo                        

            // bucle de diálogo
            while (SiguientePaso != 99 )
            {
                // actualizamos el nodo en función del paso en el que estemos
                NodoActual = MiLenguaje.NodosLenguaje[SiguientePaso]; // actualizamos el nodo actual según el paso anterior

                // preguntamos, y obtenemos respuesta en lista de strings
                RespuestaEnLista = Dialogos.FormulaPregunta(NodoActual);

                // Evaluamos respuesta en el contexto del nodo actual, y devolvemos un siguiente paso
                SiguientePaso = Dialogos.EvaluaSiguientePaso(NodoActual, RespuestaEnLista);
            } 

            Console.WriteLine("He finalizado");
            Console.ReadLine();
        }


    }
}