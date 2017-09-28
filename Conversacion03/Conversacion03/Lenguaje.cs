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

            // Nodo-0: saludo, y apertura del primer árbol de decisión
            Dictionary<int, List<string>> _Diccionario00 = new Dictionary<int, List<string>>();
            _Diccionario00.Add(0, new List<string> { "hola", "buenos días", "buenas tardes" });
            _Diccionario00.Add(1, new List<string> { "entrada", "entrar" });
            _Diccionario00.Add(2, new List<string> { "salida", "salir" });
            _Diccionario00.Add(3, new List<string> { "quien", "consulta" });
            _Diccionario00.Add(4, new List<string> { "quienes", "cuantos" });
            NodosLenguaje.Add(new Nodo(0, Nodo.TiposNodo.Pregunta, "Hola, ¿qué necesitas?", _Diccionario00, new List<string>()));

            // Nodo-1: Quiere dar entrada
            Dictionary<int, List<string>> _Diccionario01 = new Dictionary<int, List<string>>();
            _Diccionario01.Add(100, Presencia.ListaHabitantes());
            NodosLenguaje.Add(new Nodo(1, Nodo.TiposNodo.ConsultaNombre, "¿A quién?", _Diccionario01, new List<string>()));


            // Nodo-100: ¿A quién?
            Dictionary<int, List<string>> _Diccionario100 = new Dictionary<int, List<string>>();
            _Diccionario100.Add(100, new List <string>()); //si "me responde algo que entiendo", continúa (y si no, va a repetir el mismo nodo            
            NodosLenguaje.Add(new Nodo(100, Nodo.TiposNodo.ConsultaNombre, "", _Diccionario100, new List<string>()));
            
        }
    }
}
