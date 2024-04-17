using Formation;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentreFormation
{
    public partial class Modifier_Formation : Form
    {
        string selectedOption = "";
        private int iDFormation;
        public Modifier_Formation(int idFormation)
        {
            InitializeComponent();
            this.iDFormation = idFormation;
            foreach (Cours c in GlobalData.Cours)
            {
                comboBox1.Items.Add(c.getNomCours());
            }
            Formatione formation = GlobalData.Formations.FirstOrDefault(f => f.getIdFormation() == iDFormation);
            if (formation != null)
            {
                nom_for_textbox.Text = formation.getNomFormation();
                prix_for_textbox.Text = formation.getPrixFormation().ToString();
                comboBox1.SelectedItem = formation.getCours().getNomCours();
            }
            else
            {
                MessageBox.Show("Formateur non trouvé");
                this.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            selectedOption = selectedValue;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formations form = new Formations();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formatione formationRecherche = GlobalData.Formations.FirstOrDefault(f => f.getIdFormation() == this.iDFormation);



            if (formationRecherche != null)
            {
                string nom = nom_for_textbox.Text;               
                double prix = Convert.ToDouble(prix_for_textbox.Text);
                if (selectedOption == "")
                {
                    MessageBox.Show("Veuillez choisir un cours pour cette formation");
                }
                else
                {
                    Cours selectedCourse = GlobalData.Cours.FirstOrDefault(c => c.getNomCours() == selectedOption);
                    if (selectedCourse != null)
                    {
                        Formatione f = new Formatione(this.iDFormation, nom, prix, selectedCourse);
                        formationRecherche.modifierFormation(f);
                        MessageBox.Show("Formation Modifié avec succès");
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
            else
            {
                MessageBox.Show("Formation non trouvé");
            }
        }
    }
}
