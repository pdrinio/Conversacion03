using System;
using System.Collections.Generic;
using System.Text;

namespace Conversacion03
{
    class Nodo
    {
        public int IdNodo;
        public enum TiposNodo { Pregunta, Afirmacion, ConsultaNombre };
        public TiposNodo TipoNodo;
        public string MensajeIda;
        public Dictionary<int, List<string>> SiguientesPasos;
        public List<string> MensajeVuelta;

        public Nodo()
        {
            //int _IdNodo = 0;
            //TiposNodo _TipoNodo = TiposNodo.Pregunta;
            //string _MensajeIda = System.String.Empty;

            //int i = 0;
            //List<string> _MiLista = new List<string> { "uno", "dos", "tres" };

            //Dictionary<int, List<string>> _SiguientesPasos = new Dictionary<int, List<string>>();
            //_SiguientesPasos.Add(i, _MiLista);


        }

        public Nodo(int IdNodo, TiposNodo TipoNodo, string MensajeIda, Dictionary<int, List<string>> SiguientesPasos, List<string> MensajeVuelta)
        {
            this.IdNodo = IdNodo;
            this.TipoNodo = TipoNodo;
            this.MensajeIda = MensajeIda;
            this.SiguientesPasos = SiguientesPasos;
            this.MensajeVuelta = MensajeVuelta;
        }


    }
}