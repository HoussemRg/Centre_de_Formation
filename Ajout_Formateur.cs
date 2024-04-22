using CentreFormation;
using CentreFormation.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formation
{
    public partial class Ajout_Formateur : Form
    {
        private readonly CentreFormationContext _context;
        public Ajout_Formateur(CentreFormationContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btn_ajout_formateur_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupération des données du formulaire
                string nom = nom_for_textbox.Text;
                string prenom = prenom_for_textbox.Text;
                string tel = tel_for_textbox.Text;
                double salaire = Convert.ToDouble(salaire_form_textbox.Text);

                // Création d'un nouveau formateur
                var formateur = new Formateur { nom =nom, prenom = prenom, tel = tel, salaire = salaire };

                // Utilisation du DAO pour ajouter le formateur à la base de données
                var formateurDAO = new FormateurDAO(_context);
                formateurDAO.AjouterFormateur(formateur);

                // Affichage d'un message de succès
                MessageBox.Show("Formateur ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Formateurs form = new Formateurs();
                form.Show();
            }
            catch (Exception ex)
            {
                // Affichage d'un message en cas d'erreur
                MessageBox.Show($"Erreur lors de l'ajout du formateur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formateurs form = new Formateurs();
            form.Show();
        }
    }
}
