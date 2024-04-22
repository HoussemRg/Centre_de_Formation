using CentreFormation.Data;
using Formation;
using Microsoft.EntityFrameworkCore;
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
        private readonly CentreFormationContext _context;
        public Salles()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();
            _context = new CentreFormationContext();
            LoadSallesData();


            
        }

        private void InitializeDataGridViewColumns()
        {
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

            


        }

        private void LoadSallesData()
        {
            var salles = _context.salles.ToList();
            foreach (var salle in salles)
            {
                dataGridView1.Rows.Add(salle.numSalle, salle.depatement);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ajout_salle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_Salle asalle = new Ajout_Salle(_context);
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
