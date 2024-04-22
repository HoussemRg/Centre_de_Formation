using CentreFormation.Data;
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
    public partial class Ajout_Salle : Form
    {
        private readonly CentreFormationContext _context;
        public Ajout_Salle(CentreFormationContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void ajouter_salle_Click(object sender, EventArgs e)
        {
            try
            {
                
                string departement = departement_textbox.Text;
                Salle salle = new Salle {depatement=departement};
                var salleDAO = new SalleDAO(_context);
                salleDAO.ajouterSalle(salle);
                MessageBox.Show("Salle Ajouté avec succées");
                this.Hide();
                Salles salles = new Salles();
                salles.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la salle : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
            
        }

        private void btn_ajout_salle_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salles salles = new Salles();
            salles.Show();

        }
    }
}
