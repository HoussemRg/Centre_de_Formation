using Formation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{
    public class SalleDAO
    {
        public SalleDAO() { }
        public void ajouterSalle(Salle salle)
        {
            GlobalData.Salles.Add(salle);
        }
    }
}
