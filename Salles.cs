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
    public partial class Salles : Form
    {
        public Salles()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "idSalle";
            idColumn.HeaderText = "ID";
            idColumn.Name = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.DataPropertyName = "Departement";
            nomColumn.HeaderText = "Departement";
            nomColumn.Name = "Departement";
            nomColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(nomColumn);

            foreach (Salle s in GlobalData.Salles)
            {
                dataGridView1.Rows.Add(s.getNumSalle(), s.getDepartements());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ajout_salle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_Salle asalle = new Ajout_Salle();
            asalle.Show();
        }

        private void btn_back_salles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }
    }
}
