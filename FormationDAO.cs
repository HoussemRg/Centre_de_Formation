using CentreFormation.Data;
using Formation;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{

    public class FormationDAO
    {
        private readonly CentreFormationContext _context;
        public FormationDAO(CentreFormationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void ajouterFormation(Formatione formation)
        {
            try
            {
                _context.Formations.Add(formation);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de l'ajout de la formation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void supprimerFormation(Formatione formation)
        {
            try
            {
                _context.Formations.Remove(formation);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de la suppression de la formation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void modifierFormation(Formatione f,Formatione newFormation)
        {
            try
            {
                var formationToUpdate = _context.Formations.Find(f.idFormation);
                if (formationToUpdate != null)
                {
                    formationToUpdate.nomFormation = newFormation.nomFormation;
                    formationToUpdate.prixFormation = newFormation.prixFormation;
                    formationToUpdate.cours = newFormation.cours;
                    
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de la modification de la formation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
            
        }
    }
}
