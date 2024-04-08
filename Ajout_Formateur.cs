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
        public Ajout_Formateur()
        {
            InitializeComponent();
        }

        private void btn_ajout_formateur_Click(object sender, EventArgs e)
        {
            int idForm = GlobalData.Formateurs.Count + 1;
            string nom = nom_for_textbox.Text;
            string prenom = prenom_for_textbox.Text;
            string tel = tel_for_textbox.Text;
            double salaire = Convert.ToDouble(salaire_form_textbox.Text);
            Formateur f = new Formateur(idForm, nom, prenom, tel, salaire);
            f.ajouterFormateur(GlobalData.Formateurs);
            MessageBox.Show("Formateur Ajouté avec succées");
            this.Hide();
            Formateurs form = new Formateurs();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formateurs form = new Formateurs();
            form.Show();
        }
    }
}
