using Formation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{
    public class CoursDAO
    {
        public CoursDAO() { }
        public void ajouterCours(Cours cours)
        {
            GlobalData.Cours.Add(cours);
        }



        public void supprimerCours(Cours cours)
        {
            GlobalData.Cours.Remove(cours);
        }
    }
    
}
