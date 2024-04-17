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
    public partial class Ajout_Formation : Form
    {
        string selectedOption = "";
        public Ajout_Formation()
        {

            InitializeComponent();
            foreach (Cours c in GlobalData.Cours)
            {
                comboBox1.Items.Add(c.getNomCours());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            selectedOption = selectedValue;
        }

        private void ajout_formation_btn_Click(object sender, EventArgs e)
        {
            int idFormation = GlobalData.Formations.Count + 1;
            string nom = nom_for_textbox.Text;

            double prix = Convert.ToDouble(prix_form_textbox.Text);
            if (selectedOption == "")
            {
                MessageBox.Show("Veuillez choisir un cours pour cette formation");
            }
            else
            {
                Cours selectedCourse = GlobalData.Cours.FirstOrDefault(c => c.getNomCours() == selectedOption);
                if (selectedCourse != null)
                {
                    Formatione f = new Formatione(idFormation, nom, prix, selectedCourse);
                    f.ajouterFormation(GlobalData.Formations);
                    MessageBox.Show("Formation Ajoutée avec succès");
                    this.Hide();
                    Formations form = new Formations();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Le cours sélectionné est introuvable.");
                }
            }

        }

        private void btn_back_ajout_for_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formations form = new Formations();
            form.Show();
        }
    }
}
