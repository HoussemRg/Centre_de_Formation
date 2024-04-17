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
    public partial class Ajout_Participant : Form
    {
        public Ajout_Participant()
        {
            InitializeComponent();
        }

        private void btn_ajout_part_Click(object sender, EventArgs e)
        {
            int idPart = GlobalData.Participants.Count + 1;
            string nom = nom_textbox.Text;
            string prenom = prenom_textbox.Text;
            string tel = tel_textbox.Text;

            Participant p = new Participant(idPart, nom, prenom, tel, false);
            p.ajouterParticipant(GlobalData.Participants);
            MessageBox.Show("Participant Ajouté avec succées");
            this.Hide();
            Participants part = new Participants();
            part.Show();
        }

        private void btn_ajout_part_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Participants part = new Participants();
            part.Show();

        }
    }
}
