using Formation;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CentreFormation
{
    public partial class Ajout_Session : Form
    {
        string selectedFormation = "";
        string selectedFormateur = "";
        string selectedSalle = "";
        DateTime selectedDate;
        public Ajout_Session()
        {
            InitializeComponent();
            foreach (Formatione f in GlobalData.Formations)
            {
                formation_combo.Items.Add(f.getNomFormation());
            }
            foreach (Formateur f in GlobalData.Formateurs)
            {
                formateur_combo.Items.Add(f.GetNom() + " " + f.GetPrenom());
            }
            foreach (Salle f in GlobalData.Salles)
            {
                salle_combo.Items.Add(f.getNumSalle());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSession = GlobalData.Sessions.Count + 1;
            int duree = Convert.ToInt32(duree_textbox.Text);
            if (selectedFormation == "")
            {
                MessageBox.Show("Veuillez choisir une formation pour cette Session");
            }
            else if (selectedFormateur == "")
            {
                MessageBox.Show("Veuillez choisir un formateur pour cette Session");
            }
            else if (selectedSalle == "")
            {
                MessageBox.Show("Veuillez choisir une salle pour cette Session");
            }
            else
            {
                Formatione formation = GlobalData.Formations.FirstOrDefault(f => f.getNomFormation() == selectedFormation);
                Formateur formateur = GlobalData.Formateurs.FirstOrDefault(f => f.GetNom() + " " + f.GetPrenom() == selectedFormateur);
                Salle salle = GlobalData.Salles.FirstOrDefault(s => s.getNumSalle().ToString() == selectedSalle);
                if (salle != null && formation != null && formateur != null)
                {
                    Session s = new Session(idSession, duree, salle, selectedDate, formateur, formation);
                    s.creerSession(GlobalData.Sessions);
                    MessageBox.Show("Session Ajoutée avec succès");
                    this.Hide();
                    Sessions sess = new Sessions();
                    sess.Show();
                }
                else
                {
                    MessageBox.Show("Certaine valeur introuvée");

                }
            }
        }

        private void formation_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFormation = formation_combo.SelectedItem.ToString();
        }

        private void formateur_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFormateur = formateur_combo.SelectedItem.ToString();
        }

        private void salle_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSalle = salle_combo.SelectedItem.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sessions sess = new Sessions();
            sess.Show();
        }
    }
}
