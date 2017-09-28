﻿using System;
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
                        int SiguientePaso; //preparo el objeto respuesta
                       // Respuesta MiRespuesta = new Respuesta();TODO: esto sobra, ¿no?

                        List<string> TextoDevuelto = new List<string>();
                        foreach (int key in _NodoActual.SiguientesPasos.Keys)
                        {
                            if (_NodoActual.SiguientesPasos[key].Any(s => _RespuestaEnLista.Contains(s.ToUpper())))
                            {
                                Console.WriteLine("Ocurrencia localizada en clave: " + key.ToString()); //DEBUG
                                SiguientePaso = key;
                                return new Respuesta(SiguientePaso, TextoDevuelto);
                            }
                        }
                        Console.WriteLine("No te he entendido");
                        return new Respuesta(0,TextoDevuelto);                        
                    }
                case Nodo.TiposNodo.ConsultaNombre:
                    {
                        int PasoActual = _NodoActual.IdNodo;
                        int SiguientePaso = _NodoActual.IdNodo; //preparo el objeto respuesta (si no hay éxito en la respuesta, me voy a quedar donde estoy para que repita la pregunta)
                        List<string> MensajeVuelta = new List<string>();
                        // Respuesta MiRespuesta = new Respuesta();TODO: esto sobra, ¿no?

                        List<string> ListaNombres = Presencia.ListaHabitantes(); //obtenemos la lista de habitantes EN MAYÚSCULAS
                        

                        foreach (string Palabra in _RespuestaEnLista) //¿está algún nombre de la respuesta en la lista?
                        {
                            if(ListaNombres.Contains(Palabra.ToUpper()))
                            {
                                MensajeVuelta.Add(Palabra); 
                                SiguientePaso = _NodoActual.SiguientesPasos.First().Key; //si hay un nombre válido voy al (único) siguiente paso que haya                            
                            }
                        }

                        if(SiguientePaso  == PasoActual) 
                        {//no encontró respuesta, vuelve a repetir la pregunta
                            return new Respuesta(PasoActual, new List<string>());
                        }
                        else
                        {
                            return new Respuesta(SiguientePaso, MensajeVuelta);
                        }                        
                    }                    
            }
            return new Respuesta(0, new List<string>()); //TODO: quitar esto de aquí
        }
    }
    
}
