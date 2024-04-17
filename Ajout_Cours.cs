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
        public Ajout_Cours()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCours = GlobalData.Cours.Count + 1;
            string nom = nom_cours_textbox.Text;

            Cours c = new Cours(idCours, nom);
            c.ajouterCours(GlobalData.Cours);
            MessageBox.Show("Cours Ajouté avec succées");
            this.Hide();
            ListCours cours = new ListCours();
            cours.Show();
        }

        private void back_ajout_cours_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListCours cours = new ListCours();
            cours.Show();
        }
    }
}
