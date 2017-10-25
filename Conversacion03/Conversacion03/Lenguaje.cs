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
            _Diccionario00.Add(1, new List<string> { "entrada", "entrar", "recepción" });
            _Diccionario00.Add(2, new List<string> { "salida", "salir" });
            _Diccionario00.Add(3, new List<string> { "quien", "consulta" });
            _Diccionario00.Add(4, new List<string> { "quienes", "cuantos" });
            _Diccionario00.Add(5, new List<string> { "finalizar", "conversación", "olvídalo", "nada, nada", "déjalo" });
            NodosLenguaje.Add(new Nodo(0, Nodo.TiposNodo.Pregunta, "Hola, ¿qué necesitas?", _Diccionario00, new List<string>(), ()=> Acciones.NoHacerNada()));

            // Nodo-1: Quiere dar entrada
            Dictionary<int, List<string>> _Diccionario01 = new Dictionary<int, List<string>>();
            _Diccionario01.Add(0, Presencia.ListaHabitantes()); //gestiono desde Dialogos.cs el siguiente nodo
            NodosLenguaje.Add(new Nodo(1, Nodo.TiposNodo.ConsultaNombre, "¿A quién?", _Diccionario01, new List<string>(), () => Acciones.NoHacerNada()));//Acciones.DarEntrada(new List<string>(), new Presencia())));

            // Nodo-2: hacer la entrada efectiva


            // Nodo-3: Quiere dar salida
            Dictionary<int, List<string>> _Diccionario03 = new Dictionary<int, List<string>>();
            _Diccionario03.Add(0, Presencia.ListaHabitantes()); //gestiono desde Dialogos.cs el siguiente nodo
            NodosLenguaje.Add(new Nodo(2, Nodo.TiposNodo.ConsultaNombre, "¿A quién?", _Diccionario03, new List<string>(), () => Acciones.NoHacerNada()));


            // Nodo-5: finalizar la conversación
            Dictionary<int, List<string>> _Diccionario05 = new Dictionary<int, List<string>>();
            _Diccionario05.Add(0, Presencia.ListaHabitantes()); //
            NodosLenguaje.Add(new Nodo(5, Nodo.TiposNodo.Orden, "De acuerdo; hasta cuando me llames", _Diccionario05, new List<string>(), () => Acciones.NoHacerNada()));

        }
    }
}
