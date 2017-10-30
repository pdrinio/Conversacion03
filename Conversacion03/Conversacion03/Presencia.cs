using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversacion03
{
    public class Presencia
    {
        public enum Habitantes { Tani, Pablo, César, David, Javi, Iria, Fer, Pedro };
        public List<Habitantes> Personas;


        public Presencia()
        {

        }

        public void Add(string Entrante)
        {
            Habitantes HabitanteEntrante;

            if(Enum.TryParse<Habitantes>(Entrante, out HabitanteEntrante))
            {
                if (!Personas.Contains(HabitanteEntrante))
                    Personas.Add(HabitanteEntrante);
            }

        }


        public void Remove(string Saliente)
        {
            Habitantes HabitanteSaliente;

            if (Enum.TryParse<Habitantes>(Saliente, out HabitanteSaliente))
            {
                if (Personas.Contains(HabitanteSaliente))
                    Personas.Remove(HabitanteSaliente);
            }

        }

        public int Contains()
        {
            return Personas.Count;
        }

        public static List<string> ListaHabitantes()
        {
            List<string> _Personas =  Enum.GetNames(typeof(Habitantes)).ToList();
            List<string> _PersonasMayusculas = new List<string>();

            foreach(string Persona in _Personas)
            {
                _PersonasMayusculas.Add(Persona.ToUpper());
            }

            return _PersonasMayusculas;
        }
    }

}