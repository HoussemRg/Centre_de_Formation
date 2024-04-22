using CentreFormation.Data;
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

namespace CentreFormation
{
    public partial class Ajout_Formation : Form
    {
        string selectedOption = "";
        private readonly CentreFormationContext _context;
        public Ajout_Formation(CentreFormationContext context)
        {

            InitializeComponent();
            _context = context;
            foreach (Cours c in _context.cours)
            {
                comboBox1.Items.Add(c.nomCours);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            selectedOption = selectedValue;
        }

        private void ajout_formation_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupération des données du formulaire
                string nom = nom_for_textbox.Text;
                double prix = Convert.ToDouble(prix_form_textbox.Text);
                if (selectedOption == "")
                {
                    MessageBox.Show("Veuillez choisir un cours pour cette formation");
                }
                else
                {
                    Cours selectedCourse = _context.cours.FirstOrDefault(c => c.nomCours == selectedOption);
                    if (selectedCourse != null)
                    {
                        Formatione f = new Formatione { nomFormation= nom,prixFormation= prix,cours= selectedCourse };
                        MessageBox.Show(f.cours.nomCours);
                        var formationDAO = new FormationDAO(_context);
                        formationDAO.ajouterFormation(f);
                        MessageBox.Show("Formation ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                // Affichage d'un message en cas d'erreur
                MessageBox.Show($"Erreur lors de l'ajout de la formation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
