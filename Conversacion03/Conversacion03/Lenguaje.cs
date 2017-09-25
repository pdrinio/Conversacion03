using System;
using System.Collections.Generic;
using System.Text;


namespace Conversacion03
{
    class Lenguaje
    {
        public List<Nodo> NodosLenguaje;

        public Lenguaje()
        {
            NodosLenguaje = new List<Nodo>();

            // Nodo-0: indica final de la conversación


            // Nodo-1: saludo, y apertura del primer árbol de decisión
            Dictionary<int, List<string>> _Diccionario01 = new Dictionary<int, List<string>>();
            _Diccionario01.Add(0, new List<string> { "hola" });
            _Diccionario01.Add(1, new List<string> { "entrada", "entrar" });
            _Diccionario01.Add(2, new List<string> { "salida", "salir" });
            _Diccionario01.Add(3, new List<string> { "quien", "consulta" });
            _Diccionario01.Add(4, new List<string> { "quienes", "cuantos" });
            NodosLenguaje.Add(new Nodo(0, Nodo.TiposNodo.Pregunta, "Hola, ¿qué necesitas?", _Diccionario01));

            // Nodo-2: ¿a quién quiere dar entrada?
            Dictionary<int, List<string>> _Diccionario02 = new Dictionary<int, List<string>>();
            _Diccionario02.Add(7, Presencia.ListaHabitantes());
            NodosLenguaje.Add(new Nodo(1, Nodo.TiposNodo.ConsultaNombre, "¿A quién?", _Diccionario02));

        }
    }
}
