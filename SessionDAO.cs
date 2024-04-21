using Formation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{
    internal class SessionDAO
    {
        public SessionDAO() { }
        public void affecterParticipant(Session s, Participant participant)
        {
            List<Participant> newParticipants = s.getParticipants();
            newParticipants.Add(participant);
        }


        public void creerSession(Session session)
        {
            GlobalData.Sessions.Add(session);
        }

        public void annulerSession(Session session)
        {
            GlobalData.Sessions.Remove(session);
        }

        public void modifierSession(Session s,Session newSession)
        {
            s.setIdSession(newSession.getIdSession());
            s.setDuree(newSession.getDuree());
            s.setFormateur(newSession.getFormateur());
            s.setFormation(newSession.getFormation());
            s.setDateDebut(newSession.getDateDebut());
            s.setSalle(newSession.getSalle());
            s.setParticipants(newSession.getParticipants());
        }
    }
}
