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
        public Ajout_Salle()
        {
            InitializeComponent();
        }

        private void ajouter_salle_Click(object sender, EventArgs e)
        {
            int numSalle = Convert.ToInt32(numsalle_textbox.Text);
            string departement = departement_textbox.Text;

            Salle s = new Salle(numSalle, departement);
            s.ajouterSalle(GlobalData.Salles);
            MessageBox.Show("Salle Ajouté avec succées");
            this.Hide();
            Salles salles = new Salles();
            salles.Show();
        }

        private void btn_ajout_salle_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salles salles = new Salles();
            salles.Show();

        }
    }
}
