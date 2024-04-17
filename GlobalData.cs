using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    public static class GlobalData 
    {
        public static List<Formateur> Formateurs { get; } = new List<Formateur>();
        public static List<Cours> Cours { get; } = new List<Cours>();

        public static List<Formatione> Formations { get; } = new List<Formatione>();

        public static List<Participant> Participants { get; } = new List<Participant>();
        public static List<Salle> Salles { get; } = new List<Salle>();
        public static List<Session> Sessions { get; } = new List<Session>();

        static GlobalData()
        {
            
        }
       
        

    }
}
