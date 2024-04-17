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
    public partial class ListCours : Form
    {
        public ListCours()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "idCours";
            idColumn.HeaderText = "ID";
            idColumn.Name = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.DataPropertyName = "nom";
            nomColumn.HeaderText = "Nom Cours";
            nomColumn.Name = "Nom";
            nomColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(nomColumn);
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Supprimer";
            deleteButtonColumn.Text = "Supprimer";
            deleteButtonColumn.Name = "Supprimer";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);

            foreach (Cours c in GlobalData.Cours)
            {
                dataGridView1.Rows.Add(c.getIdCours(), c.getNomCours());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce cours ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int iDCours = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                    foreach (Cours c in GlobalData.Cours)
                    {
                        if (c.getIdCours() == iDCours)
                        {
                            c.supprimerCours(GlobalData.Cours);
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            break;
                        }
                    }
                }

            }
        }

        private void btn_ajout_cours_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_Cours ac = new Ajout_Cours();
            ac.Show();
        }

        private void btn_cours_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }
    }
}
