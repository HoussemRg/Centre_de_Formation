using Formation;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{
    public class FormationDAO
    {
        public FormationDAO() { }
        public void ajouterFormation(Formatione formation)
        {
            GlobalData.Formations.Add(formation);
        }

        public void supprimerFormation(Formatione formation)
        {
            GlobalData.Formations.Remove(formation);
        }

        public void modifierFormation(Formatione f,Formatione newFormation)
        {
            f.setIdFormation(newFormation.getIdFormation());
            f.setnomFormation(newFormation.getNomFormation());
            f.setPrixFormation(newFormation.getPrixFormation());
            f.setCours(newFormation.getCours());
        }
    }
}
