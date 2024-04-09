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
    public partial class Modifier_Formateur : Form
    {
        private int iDFormateur;
        public Modifier_Formateur(int idFormateur)
        {
            InitializeComponent();
            this.iDFormateur = idFormateur;
            Formateur formateur = GlobalData.Formateurs.FirstOrDefault(f => f.GetIdFormateur() == iDFormateur);
            if (formateur != null)
            {
                mdf_for_nom.Text = formateur.GetNom();
                mdf_for_prenom.Text = formateur.GetPrenom();
                mdf_for_tel.Text = formateur.GetTel();
                mdf_for_salaire.Text = formateur.GetSalaire().ToString();
            }
            else
            {
                MessageBox.Show("Formateur non trouvé");
                this.Close();
            }
        }

        private void Modifier_Formateur_Load(object sender, EventArgs e)
        {

        }

        private void btn_modifier_formateur_Click(object sender, EventArgs e)
        {
            Formateur formateurRecherche = GlobalData.Formateurs.FirstOrDefault(formateur => formateur.GetIdFormateur() == this.iDFormateur);



            if (formateurRecherche != null)
            {
                string nom = mdf_for_nom.Text;
                string prenom = mdf_for_prenom.Text;
                string tel = mdf_for_tel.Text;
                double salaire = Convert.ToDouble(mdf_for_salaire.Text);
                Formateur f=new Formateur(this.iDFormateur,nom, prenom,tel, salaire);
                formateurRecherche.modifierFormateur(f);
                

                MessageBox.Show("Formateur modifié avec succès");
                this.Hide();
                Formateurs form = new Formateurs();
                form.Show();
            }
            else
            {
                MessageBox.Show("Formateur non trouvé");
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
