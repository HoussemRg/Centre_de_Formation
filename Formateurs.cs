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
    public partial class Formateurs : Form
    {
        public Formateurs()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "idFormateur";
            idColumn.HeaderText = "ID";
            idColumn.Name = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.DataPropertyName = "nom";
            nomColumn.HeaderText = "Nom";
            nomColumn.Name = "Nom";
            nomColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(nomColumn);

            DataGridViewTextBoxColumn prenomColumn = new DataGridViewTextBoxColumn();
            prenomColumn.DataPropertyName = "prenom";
            prenomColumn.HeaderText = "Prénom";
            prenomColumn.Name = "Prénom";
            prenomColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(prenomColumn);

            DataGridViewTextBoxColumn telColumn = new DataGridViewTextBoxColumn();
            telColumn.DataPropertyName = "tel";
            telColumn.HeaderText = "Téléphone";
            telColumn.Name = "Téléphone";
            telColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(telColumn);

            DataGridViewTextBoxColumn salaireColumn = new DataGridViewTextBoxColumn();
            salaireColumn.DataPropertyName = "salaire";
            salaireColumn.HeaderText = "Salaire";
            salaireColumn.Name = "Salaire";
            salaireColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(salaireColumn);
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Supprimer";
            deleteButtonColumn.Text = "Supprimer";
            deleteButtonColumn.Name = "Supprimer";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);
            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "Modifier";
            updateButtonColumn.Text = "Modifier";
            updateButtonColumn.Name = "Modifier";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(updateButtonColumn);

            foreach (Formateur formateur in GlobalData.Formateurs)
            {
                dataGridView1.Rows.Add(formateur.idFormateur, formateur.nom, formateur.prenom, formateur.tel, formateur.salaire);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce formateur ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int iDFormateur = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                    foreach (Formateur formateur in GlobalData.Formateurs)
                    {
                        if (formateur.idFormateur == iDFormateur)
                        {
                            formateur.supprimerFormateur(GlobalData.Formateurs);
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            break;
                        }
                    }
                }

            }
            else if(dataGridView1.Columns[e.ColumnIndex].Name == "Modifier")
            {
                int iDFormateur = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                this.Hide();
                Modifier_Formateur mf = new Modifier_Formateur(iDFormateur);
                mf.Show();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }

        private void ajout_formateur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_Formateur af = new Ajout_Formateur();
            af.Show();
        }

        
    }
}
