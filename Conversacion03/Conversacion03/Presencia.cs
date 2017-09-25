using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversacion03
{
    public class Presencia
    {
        public enum Habitantes { Pa, Ma, Cris, Pablo };
        public List<Habitantes> Personas;


        public Presencia()
        {
            //Personas.Add(Habitantes.Pa);
            //Personas.Add(Habitantes.Ma);
            //Personas.Add(Habitantes.Cris);
            //Personas.Add(Habitantes.Pablo);
        }

        public void Add(Habitantes HabitanteEntrante)
        {
            if (!Personas.Contains(HabitanteEntrante))
                Personas.Add(HabitanteEntrante);
        }

        public void Remove(Habitantes HabitanteSaliente)
        {
            if (Personas.Contains(HabitanteSaliente))
                Personas.Remove(HabitanteSaliente);
        }

        public int Contains()
        {
            return Personas.Count;
        }

        public static List<string> ListaHabitantes()
        {
            return Enum.GetNames(typeof(Habitantes)).ToList();
        }
    }

}