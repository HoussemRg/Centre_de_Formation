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
    public partial class Modifier_Formateur : Form
    {
        private int iDFormateur;
        private readonly CentreFormationContext _context;
        public Modifier_Formateur(CentreFormationContext context, int idFormateur)
        {
            InitializeComponent();
            _context = context;
            this.iDFormateur = idFormateur;

            // Recherche du formateur dans la base de données
            var formateur = _context.Formateurs.FirstOrDefault(f => f.idFormateur == iDFormateur);
            if (formateur != null)
            {
                // Remplissage des champs avec les données du formateur trouvé
                mdf_for_nom.Text = formateur.nom;
                mdf_for_prenom.Text = formateur.prenom;
                mdf_for_tel.Text = formateur.tel;
                mdf_for_salaire.Text = formateur.salaire.ToString();
            }
            else
            {
                // Affichage d'un message d'erreur si le formateur n'est pas trouvé
                MessageBox.Show("Formateur non trouvé");
                this.Close();
            }
        }

        private void Modifier_Formateur_Load(object sender, EventArgs e)
        {

        }

        private void btn_modifier_formateur_Click(object sender, EventArgs e)
        {
            var formateurRecherche = _context.Formateurs.FirstOrDefault(formateur => formateur.idFormateur == this.iDFormateur);

            if (formateurRecherche != null)
            {
                string nom = mdf_for_nom.Text;
                string prenom = mdf_for_prenom.Text;
                string tel = mdf_for_tel.Text;
                double salaire = Convert.ToDouble(mdf_for_salaire.Text);

                Formateur nouveauFormateur = new Formateur(this.iDFormateur, nom, prenom, tel, salaire);

                FormateurDAO formateurDAO = new FormateurDAO(_context);
                formateurDAO.ModifierFormateur(formateurRecherche, nouveauFormateur);

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
