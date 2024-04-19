using Formation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{
    public class FormateurDAO
    {
        public FormateurDAO() { }
        public void ajouterFormateur(Formateur f)
        {
            GlobalData.Formateurs.Add(f);
        }
        public void supprimerFormateur(Formateur f)
        {
            GlobalData.Formateurs.Remove(f);
        }
        public void modifierFormateur(Formateur formateur,Formateur nouveauFormateur)
        {
            formateur.SetIdFormateur(nouveauFormateur.GetIdFormateur());
            formateur.SetNom(nouveauFormateur.GetNom());
            formateur.SetPrenom(nouveauFormateur.GetPrenom());
            formateur.SetTel(nouveauFormateur.GetTel());
            formateur.SetSalaire(nouveauFormateur.GetSalaire());
        }
    }
}
