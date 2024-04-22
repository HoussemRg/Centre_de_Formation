using CentreFormation;
using CentreFormation.Data;
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
    public partial class Ajout_Cours : Form
    {
        private readonly CentreFormationContext _context;
        public Ajout_Cours(CentreFormationContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = nom_cours_textbox.Text;
                var cours = new Cours { nomCours = nom };
                var coursDAO = new CoursDAO(_context);
                coursDAO.ajouterCours(cours);
                MessageBox.Show("Cours Ajouté avec succées");
                this.Hide();
                ListCours cs = new ListCours();
                cs.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du cours : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void back_ajout_cours_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListCours cours = new ListCours();
            cours.Show();
        }
    }
}
