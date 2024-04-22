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
    internal class SessionDAO
    {
        private readonly CentreFormationContext _context;
        public SessionDAO(CentreFormationContext context) 
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        /*public void affecterParticipant(Session s, Participant participant)
        {
            ICollection<Participant> newParticipants = s.participants;
            newParticipants.Add(participant);
        }*/


        public void creerSession(Session session)
        {
            try
            {
                _context.sessions.Add(session);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la session : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void annulerSession(Session session)
        {
            try
            {
                _context.sessions.Remove(session);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erreur lors de la suppression de la formation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void modifierSession(Session s,Session newSession)
        {
            try
            {
                var sessionToUpdate = _context.sessions.Find(s.idSession);
                if (sessionToUpdate != null)
                {
                    sessionToUpdate.duree = newSession.duree;
                    sessionToUpdate.formateur = newSession.formateur;
                    sessionToUpdate.formation = newSession.formation;
                    sessionToUpdate.salle = newSession.salle;
                    sessionToUpdate.dateDebut = newSession.dateDebut;
                    sessionToUpdate.participants = newSession.participants;

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
