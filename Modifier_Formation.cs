using CentreFormation.Data;
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
        private readonly CentreFormationContext _context;
        public Modifier_Formation(CentreFormationContext context,int idFormation)
        {
            InitializeComponent();
            _context = context;
            this.iDFormation = idFormation;
            foreach (Cours c in _context.cours)
            {
                comboBox1.Items.Add(c.nomCours);
            }
            Formatione formation = _context.Formations.FirstOrDefault(f => f.idFormation == iDFormation);
            if (formation != null)
            {
                nom_for_textbox.Text = formation.nomFormation;
                prix_for_textbox.Text = formation.prixFormation.ToString();
                comboBox1.SelectedItem = formation.cours.nomCours;
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
            Formatione formationRecherche = _context.Formations.FirstOrDefault(f => f.idFormation == this.iDFormation);



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
                    Cours selectedCourse = _context.cours.FirstOrDefault(c => c.nomCours == selectedOption);
                    if (selectedCourse != null)
                    {
                        Formatione f = new Formatione(this.iDFormation, nom, prix, selectedCourse);
                        FormationDAO formationDAO = new FormationDAO(_context);
                        formationDAO.modifierFormation(formationRecherche, f);
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
