﻿//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR

using System;
using System.Collections.Generic;
using System.Text;

namespace Conversacion03
{
    class Lugar
    {
        public int IdNodo;
        public enum TiposNodo { Pregunta, Afirmacion, ConsultaNombre, Orden };
        public TiposNodo TipoNodo;
        public string MensajeIda;
        public Dictionary<int, List<string>> SiguientesPasos;
        public List<string> MensajeVuelta;
        public Action AcciónARealizar;

        public Lugar()
        {

        }

        public Lugar(int IdNodo, TiposNodo TipoNodo, string MensajeIda, Dictionary<int, List<string>> SiguientesPasos, List<string> MensajeVuelta, Action _AccionARealizar)
        {
            this.IdNodo = IdNodo;
            this.TipoNodo = TipoNodo;
            this.MensajeIda = MensajeIda;
            this.SiguientesPasos = SiguientesPasos;
            this.MensajeVuelta = MensajeVuelta;
            this.AcciónARealizar = _AccionARealizar;
        }


    }
}
//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR
//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR//TODO OBSOLETO DEL TODO: LO PUEDO ELIMINAR