using CentreFormation.Data;
using Formation;
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

namespace CentreFormation
{
    public partial class Ajout_Participant : Form
    {
        private readonly CentreFormationContext _context;
        public Ajout_Participant(CentreFormationContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btn_ajout_part_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupération des données du formulaire
                string nom = nom_textbox.Text;
                string prenom = prenom_textbox.Text;
                string tel = tel_textbox.Text;
                

                // Création d'un nouveau formateur
                var participant = new Participant { nom = nom, prenom = prenom, tel = tel, etatPayment = false };

                // Utilisation du DAO pour ajouter le formateur à la base de données
                var participantDAO = new ParticipantDAO(_context);
                participantDAO.ajouterParticipant(participant);

                // Affichage d'un message de succès
                MessageBox.Show("Participant ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Participants part = new Participants();
                part.Show();
            }
            catch (Exception ex)
            {
                // Affichage d'un message en cas d'erreur
                MessageBox.Show($"Erreur lors de l'ajout du formateur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btn_ajout_part_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Participants part = new Participants();
            part.Show();

        }
    }
}
