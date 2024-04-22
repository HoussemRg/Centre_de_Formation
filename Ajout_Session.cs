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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CentreFormation
{
    public partial class Ajout_Session : Form
    {
        string selectedFormation = "";
        string selectedFormateur = "";
        string selectedSalle = "";
        DateTime selectedDate;
        private readonly CentreFormationContext _context;
        public Ajout_Session(CentreFormationContext context)
        {
            InitializeComponent();
            _context = context;
            foreach (Formatione f in _context.Formations)
            {
                formation_combo.Items.Add(f.nomFormation);
            }
            foreach (Formateur f in _context.Formateurs)
            {
                formateur_combo.Items.Add(f.nom + " " + f.prenom);
            }
            foreach (Salle f in _context.salles)
            {
                salle_combo.Items.Add(f.numSalle);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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
                Formatione formation = _context.Formations.FirstOrDefault(f => f.nomFormation == selectedFormation);
                Formateur formateur = _context.Formateurs.FirstOrDefault(f => f.nom + " " + f.prenom == selectedFormateur);
                Salle salle = _context.salles.FirstOrDefault(s => s.numSalle.ToString() == selectedSalle);
                if (salle != null && formation != null && formateur != null)
                {
                    Session s = new Session { duree=duree, salle=salle,dateDebut= selectedDate,formateur= formateur,formation= formation };
                    var sessionDAO = new SessionDAO(_context);
                    sessionDAO.creerSession(s);

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

        private void Ajout_Session_Load(object sender, EventArgs e)
        {

        }
    }
}
