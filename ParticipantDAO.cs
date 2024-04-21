using Formation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentreFormation
{
    public class ParticipantDAO
    {
        public ParticipantDAO() { }
        public void ajouterParticipant(Participant participant)
        {
            GlobalData.Participants.Add(participant);
        }

        public void supprimerParticipant(Participant participant)
        {
            GlobalData.Participants.Remove(participant);
        }

        public void modifierParticipant(Participant p,Participant newParticipant)
        {
            p.setIdParticipant(newParticipant.getIdParticipant());
            p.SetNom(newParticipant.GetNom());
            p.SetPrenom(newParticipant.GetPrenom());
            p.SetTel(newParticipant.GetTel());
            p.setEtatPayment(newParticipant.getEtatPayment());
        }

        public void payerFormation(Participant p)
        {
            p.setEtatPayment(true);
        }
    }
}
