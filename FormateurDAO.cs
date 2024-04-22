using CentreFormation.Data;
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
        private readonly CentreFormationContext _context;

        
        public FormateurDAO(CentreFormationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AjouterFormateur(Formateur formateur)
        {
            try
            {
                _context.Formateurs.Add(formateur);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de l'ajout du formateur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; 
            }
        }
        public void SupprimerFormateur(Formateur formateur)
        {
            try
            {
                _context.Formateurs.Remove(formateur);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Erreur lors de la suppression du formateur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; 
            }
        }
        public void ModifierFormateur(Formateur formateur, Formateur nouveauFormateur)
        {
            try
            {
                var formateurToUpdate = _context.Formateurs.Find(formateur.idFormateur);
                if (formateurToUpdate != null)
                {
                    formateurToUpdate.nom = nouveauFormateur.nom;
                    formateurToUpdate.prenom = nouveauFormateur.prenom;
                    formateurToUpdate.tel = nouveauFormateur.tel;
                    formateurToUpdate.salaire = nouveauFormateur.salaire;
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Erreur lors de la modification du formateur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; 
            }
        }
    }
}
