﻿using CentreFormation.Data;
using Formation;
using Microsoft.VisualBasic;
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
    public partial class Sessions : Form
    {
        private readonly CentreFormationContext _context;
        public Sessions()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();
            _context = new CentreFormationContext();
            LoadSessionsData();


            
        }

        private void InitializeDataGridViewColumns()
        {
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "idSession";
            idColumn.HeaderText = "ID";
            idColumn.Name = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn dureeColumn = new DataGridViewTextBoxColumn();
            dureeColumn.DataPropertyName = "durée";
            dureeColumn.HeaderText = "Durée(jours)";
            dureeColumn.Name = "Durée";
            dureeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(dureeColumn);
            DataGridViewTextBoxColumn formateurColumn = new DataGridViewTextBoxColumn();
            formateurColumn.DataPropertyName = "Formateur";
            formateurColumn.HeaderText = "Formateur";
            formateurColumn.Name = "Formateur";
            formateurColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(formateurColumn);

            DataGridViewTextBoxColumn formationColumn = new DataGridViewTextBoxColumn();
            formationColumn.DataPropertyName = "Formation";
            formationColumn.HeaderText = "Formation";
            formationColumn.Name = "Formation";
            formationColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(formationColumn);

            DataGridViewTextBoxColumn dateDebutColumn = new DataGridViewTextBoxColumn();
            dateDebutColumn.DataPropertyName = "date";
            dateDebutColumn.HeaderText = "Date Debut";
            dateDebutColumn.Name = "date";
            dateDebutColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(dateDebutColumn);

            DataGridViewTextBoxColumn salleColumn = new DataGridViewTextBoxColumn();
            salleColumn.DataPropertyName = "salle";
            salleColumn.HeaderText = "Salle";
            salleColumn.Name = "Salle";
            salleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(salleColumn);

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

            foreach (Session s in GlobalData.Sessions)
            {
                dataGridView1.Rows.Add(s.idSession, s.duree, s.formateur.nom, s.formation.nomFormation, s.dateDebut, s.salle.numSalle);
            }


        }

        private void LoadSessionsData()
        {
           
                var sessions = _context.sessions.ToList();

                foreach (Session session in sessions)
                {
                    
                    dataGridView1.Rows.Add(session.idSession, session.duree, session.formateur.nom, session.formation.nomFormation,session.dateDebut,session.salle.numSalle);
                }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette session ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int iDSession = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                    using (var context = new CentreFormationContext())
                    {
                        var sessionDAO = new SessionDAO(context);
                        var session = context.sessions.Find(iDSession);
                        if (session != null)
                        {
                            sessionDAO.annulerSession(session);
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Modifier")
            {
                int iDSession = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                this.Hide();
                Modifier_Session ms = new Modifier_Session(_context, iDSession);
                ms.Show();
            }
        }

        private void btn_back_sessions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }

        private void btn_creer_session_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_Session asess = new Ajout_Session(_context);
            asess.Show();
        }
    }
}
