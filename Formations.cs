using CentreFormation.Data;
using Formation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private readonly CentreFormationContext _context;
        public Formations()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();
            _context = new CentreFormationContext();
            LoadFormationsData();
            
        }

        private void InitializeDataGridViewColumns()
        {
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
            coursColumn.DataPropertyName = "cours"; // Utilisez la propriété correcte qui représente le cours
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

            
        }

        private void LoadFormationsData()
        {
            try
            {
                var formations = _context.Formations.ToList();
                
                foreach (Formatione formation in formations)
                {
                    string nomCours = formation.cours != null ? formation.cours.nomCours : "N/A";
                    dataGridView1.Rows.Add(formation.idFormation, formation.nomFormation, formation.prixFormation, nomCours);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors du chargement des formations : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    using (var context = new CentreFormationContext())
                    {
                        var formationDAO = new FormationDAO(context);
                        var formation = context.Formations.Find(iDFormation);
                        if (formation != null)
                        {
                            formationDAO.supprimerFormation(formation);
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Modifier")
            {
                int iDFormation = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                this.Hide();
                Modifier_Formation mf = new Modifier_Formation(_context,iDFormation);
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
            Ajout_Formation af= new Ajout_Formation(_context);
            af.Show();
        }
    }
}
