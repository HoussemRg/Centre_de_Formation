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
    public partial class Formations : Form
    {
        public Formations()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "idFormations";
            idColumn.HeaderText = "ID";
            idColumn.Name = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.DataPropertyName = "nom";
            nomColumn.HeaderText = "Nom Formation";
            nomColumn.Name = "Nom";
            nomColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(nomColumn);
            DataGridViewTextBoxColumn prixColumn = new DataGridViewTextBoxColumn();
            prixColumn.DataPropertyName = "nom";
            prixColumn.HeaderText = "Prix Formation";
            prixColumn.Name = "Prix";
            prixColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(prixColumn);

            DataGridViewTextBoxColumn coursColumn = new DataGridViewTextBoxColumn();
            coursColumn.DataPropertyName = "nom";
            coursColumn.HeaderText = "Cours";
            coursColumn.Name = "Cours";
            coursColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(coursColumn);

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

            foreach (Formatione f in GlobalData.Formations)
            {
                dataGridView1.Rows.Add(f.getIdFormation(), f.getNomFormation(), f.getPrixFormation(), f.getCours().getNomCours());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette formations ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int iDFormation = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                    foreach (Formatione f in GlobalData.Formations)
                    {
                        if (f.getIdFormation() == iDFormation)
                        {
                            f.supprimerFormation(GlobalData.Formations);
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            break;
                        }
                    }
                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Modifier")
            {
                int iDFormation = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                this.Hide();
                Modifier_Formation mf = new Modifier_Formation(iDFormation);
                mf.Show();
            }

        }

        private void btn_back_formations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }

        private void btn_ajout_formation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_Formation af= new Ajout_Formation();
            af.Show();
        }
    }
}
