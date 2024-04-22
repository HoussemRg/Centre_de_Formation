using CentreFormation.Data;
using Formation;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{

    public class SalleDAO
    {
        private readonly CentreFormationContext _context;
        public SalleDAO(CentreFormationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void ajouterSalle(Salle salle)
        {
            try
            {
                _context.salles.Add(salle);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de l'ajout de la salle : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
