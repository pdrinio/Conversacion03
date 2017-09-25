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

        public static Respuesta EvaluaSiguientePaso(Nodo _NodoActual, List<string> _RespuestaEnLista)
        {
            switch (_NodoActual.TipoNodo) {
                case Nodo.TiposNodo.Pregunta:
                    {
                        List<string> TextoDevuelto = new List<string>();
                        foreach (int key in _NodoActual.SiguientesPasos.Keys)
                        {
                            if (_NodoActual.SiguientesPasos[key].Any(s => _RespuestaEnLista.Contains(s.ToUpper())))
                            {
                                Console.WriteLine("Ocurrencia localizada en clave: " + key.ToString()); //DEBUG
                                return new Respuesta(key, TextoDevuelto);
                            }
                        }
                        Console.WriteLine("No te he entendido");
                        return new Respuesta(0,TextoDevuelto);                        
                    }
                case Nodo.TiposNodo.ConsultaNombre:
                    {
                        int SiguientePaso; //preparo el objeto respuesta
                        Respuesta MiRespuesta = new Respuesta(); 

                        List<string> ListaNombres = Presencia.ListaHabitantes(); //obtenemos la lista de habitantes

                        foreach (string Palabra in _RespuestaEnLista) //¿está algún nombre de la respuesta en la lista?
                        {
                            if(ListaNombres.Contains(Palabra) { MiRespuesta.TextoDevuelto.Add(Palabra); }
                            SiguientePaso = 
                        }
                        return ;
                    }
                    
            }
            return new Respuesta(0, new List<string>()); //TODO: quitar esto de aquí
        }
    }
    
}
