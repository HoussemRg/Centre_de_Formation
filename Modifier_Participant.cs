using Formation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentreFormation
{
    public partial class Modifier_Participant : Form
    {
        private int iDParticipant;
        public Modifier_Participant(int idParticipant)
        {
            InitializeComponent();
            this.iDParticipant = idParticipant;
            Participant p = GlobalData.Participants.FirstOrDefault(p => p.getIdParticipant() == iDParticipant);
            if (p != null)
            {
                nom_textbox.Text = p.GetNom();
                prenom_textbox.Text = p.GetPrenom();
                tel_textbox.Text = p.GetTel();
            }
            else
            {
                MessageBox.Show("Participant non trouvé");
                this.Close();
            }
        }

        private void modifier_btn_Click(object sender, EventArgs e)
        {
            Participant participantRecherche = GlobalData.Participants.FirstOrDefault(p => p.getIdParticipant() == this.iDParticipant);



            if (participantRecherche != null)
            {
                string nom = nom_textbox.Text;
                string prenom = prenom_textbox.Text;
                string tel = tel_textbox.Text;

                Participant p = new Participant(this.iDParticipant, nom, prenom, tel, participantRecherche.getEtatPayment());
                ParticipantDAO participantDAO = new ParticipantDAO();
                participantDAO.modifierParticipant(participantRecherche,p);
                MessageBox.Show("Participant modifié avec succès");
                this.Hide();
                Participants part = new Participants();
                part.Show();
            }
            else
            {
                MessageBox.Show("Formateur non trouvé");
            }
        }

        private void btn_modif_part_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Participants part = new Participants();
            part.Show();
        }
    }
}
