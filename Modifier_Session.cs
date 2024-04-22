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
    public partial class Modifier_Session : Form
    {
        private readonly CentreFormationContext _context;
        string selectedFormateur = "";
        string selectedSalle = "";
        DateTime selectedDate;
        private int iDSession;
        public Modifier_Session(CentreFormationContext context, int idSession)
        {
            InitializeComponent();
            _context = context;
            this.iDSession = idSession;
            foreach (Formateur f in _context.Formateurs)
            {
                comboBox1.Items.Add(f.nom + " " + f.prenom);
            }
            foreach (Salle s in _context.salles)
            {
                comboBox2.Items.Add(s.numSalle);
            }
            Session session = _context.sessions.FirstOrDefault(s => s.idSession == iDSession);
            if (session != null)
            {
                duree_textbox.Text = session.duree.ToString();
                comboBox1.SelectedItem = session.formateur.nom + " " + session.formateur.prenom;
                comboBox2.SelectedItem = session.salle.numSalle;
                dateTimePicker1.Value = session.dateDebut;
            }
            else
            {
                MessageBox.Show("Session non trouvé");
                this.Close();
            }
        }

        private void Modifier_Session_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFormateur = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSalle = comboBox2.SelectedItem.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dateTimePicker1.Value;
        }

        private void mdf_session_Click(object sender, EventArgs e)
        {
            Session sessionRecherche = _context.sessions.FirstOrDefault(s => s.idSession == this.iDSession);



            if (sessionRecherche != null)
            {
                int duree = Convert.ToInt32(duree_textbox.Text);

                if (selectedDate == null)
                {
                    MessageBox.Show("Veuillez choisir une date de debut pour cette session");
                }
                else if (selectedFormateur == "")
                {
                    MessageBox.Show("Veuillez choisir un formateur pour cette session");
                }
                else if (selectedSalle == "")
                {
                    MessageBox.Show("Veuillez choisir une salle pour cette session");
                }
                else if (duree == null)
                {
                    MessageBox.Show("Veuillez choisir une durée pour cette session");
                }
                else
                {
                    Formateur formateur = _context.Formateurs.FirstOrDefault(f => f.nom + " " + f.prenom == selectedFormateur);
                    Salle salle = _context.salles.FirstOrDefault(s => s.numSalle.ToString() == selectedSalle);

                    if (formateur != null || salle != null)
                    {

                        Session session = new Session(this.iDSession, duree, salle, selectedDate, formateur, sessionRecherche.formation);
                        SessionDAO sessionDAO = new SessionDAO(_context);
                        sessionDAO.modifierSession(sessionRecherche, session);
                        MessageBox.Show("Session Modifié avec succès");
                        this.Hide();
                        Sessions sess = new Sessions();
                        sess.Show();
                    }
                    else
                    {
                        MessageBox.Show("Le formateur ou la salle sélectionné est introuvable.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Formation non trouvé");
            }
        }

        private void back_mod_session_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sessions sess = new Sessions();
            sess.Show();
        }
    }
}
