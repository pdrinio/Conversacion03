using System;
using System.Collections.Generic;
using System.Text;

namespace Conversacion03
{
    class Nodo
    {
        public int IdNodo;
        public enum TiposNodo { Pregunta, Afirmacion, ConsultaNombre, Orden, Accion };
        public TiposNodo TipoNodo;
        public string MensajeIda;
        public Dictionary<int, List<string>> SiguientesPasos;
        public List<string> MensajeVuelta;
        public List<Object> ArgumentosAccion;
        public Action AccionARealizar;

        public Nodo(int v)
        {
   
        }

        public Nodo(int IdNodo, TiposNodo TipoNodo, string MensajeIda, Dictionary<int, List<string>> SiguientesPasos, List<string> MensajeVuelta, List<Object> ArgumentosAccion, Action _AccionARealizar)
        {
            this.IdNodo = IdNodo;
            this.TipoNodo = TipoNodo;
            this.MensajeIda = MensajeIda;
            this.SiguientesPasos = SiguientesPasos;
            this.MensajeVuelta = MensajeVuelta;
            this.AccionARealizar = _AccionARealizar;
        }


    }
}