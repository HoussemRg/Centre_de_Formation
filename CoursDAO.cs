using CentreFormation.Data;
using Formation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{
    public class CoursDAO
    {
        private readonly CentreFormationContext _context;
        public CoursDAO(CentreFormationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void ajouterCours(Cours cours)
        {
            try
            {
                _context.cours.Add(cours);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de l'ajout du cours : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }



        public void supprimerCours(Cours cours)
        {
            try
            {
                _context.cours.Remove(cours);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de la suppression du cours : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
    
}
