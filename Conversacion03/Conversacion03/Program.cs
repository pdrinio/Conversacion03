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
            Lenguaje MiLenguaje = new Lenguaje(); // lenguaje, vocabulario, funciones, etc
            Conversacion MiConversacion = new Conversacion(); // tracking de los nodos recorridos
            Nodo NodoActual = new Nodo();        
            List<string> RespuestaEnLista = new List<string>();
            Respuesta MiRespuesta = new Respuesta(0, new List<string>());

            // inicialización
            Console.OutputEncoding = System.Text.Encoding.Unicode;            

            // bucle de diálogo
            while (MiRespuesta.SiguientePaso != 99 )
            {
                // actualizamos el nodo en función del paso en el que estemos
                NodoActual = MiLenguaje.NodosLenguaje.Where(x => x.IdNodo == MiRespuesta.SiguientePaso).Single();                

                // preguntamos, y obtenemos respuesta en lista de strings
                RespuestaEnLista = Dialogos.FormulaPregunta(NodoActual);

                // ejecuto la acción del nodo
                NodoActual.AcciónARealizar();

                // Evaluamos respuesta en el contexto del nodo actual, y devolvemos un siguiente paso
                MiRespuesta = Dialogos.EvaluaSiguientePaso(NodoActual, RespuestaEnLista);
            } 

            Console.WriteLine("He finalizado");
            Console.ReadLine();
        }


    }
}