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
    public class ParticipantDAO
    {
        private readonly CentreFormationContext _context;
        public ParticipantDAO(CentreFormationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void ajouterParticipant(Participant participant)
        {
            try
            {
                _context.Participants.Add(participant);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de l'ajout du participant : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void supprimerParticipant(Participant participant)
        {
            try
            {
                _context.Participants.Remove(participant);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de la suppression du participant : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void modifierParticipant(Participant p,Participant newParticipant)
        {
            try
            {
                var participantToUpdate = _context.Participants.Find(p.idParticipant);
                if (participantToUpdate != null)
                {
                    participantToUpdate.nom = newParticipant.nom;
                    participantToUpdate.prenom = newParticipant.prenom;
                    participantToUpdate.tel = newParticipant.tel;
                    participantToUpdate.etatPayment = newParticipant.etatPayment;
                    participantToUpdate.sessions = newParticipant.sessions;
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de la modification du participant : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            

        }

        public void payerFormation(Participant p)
        {
            try
            {
                var participantToUpdate = _context.Participants.Find(p.idParticipant);
                if (participantToUpdate != null)
                {
                    
                    participantToUpdate.etatPayment = true;
                 
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors du payment: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
           
        }
    }
}
