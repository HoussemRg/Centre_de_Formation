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
    public partial class Participants : Form
    {
        public Participants()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "idParticipant";
            idColumn.HeaderText = "ID";
            idColumn.Name = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.DataPropertyName = "nom";
            nomColumn.HeaderText = "Nom Participant";
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

            DataGridViewTextBoxColumn etatPaymentColumn = new DataGridViewTextBoxColumn();
            etatPaymentColumn.DataPropertyName = "etat";
            etatPaymentColumn.HeaderText = "Etat de Payment";
            etatPaymentColumn.Name = "etat";
            etatPaymentColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(etatPaymentColumn);
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

            DataGridViewButtonColumn payerButtonColumn = new DataGridViewButtonColumn();
            payerButtonColumn.HeaderText = "Payer";
            payerButtonColumn.Text = "Payer";
            payerButtonColumn.Name = "Payer";
            payerButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(payerButtonColumn);

            foreach (Participant participant in GlobalData.Participants)
            {
                if(participant.getEtatPayment()==false)
                {
                    dataGridView1.Rows.Add(participant.getIdParticipant(), participant.GetNom(), participant.GetPrenom(), participant.GetTel(), "Non payé");
                }
                else
                {
                    dataGridView1.Rows.Add(participant.getIdParticipant(), participant.GetNom(), participant.GetPrenom(), participant.GetTel(), "Payé");
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce participant ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int iDParticipant = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                    foreach (Participant p in GlobalData.Participants)
                    {
                        if (p.getIdParticipant() == iDParticipant)
                        {
                            p.supprimerParticipant(GlobalData.Participants);
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            break;
                        }
                    }
                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Modifier")
            {
                int iDParticipant = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                this.Hide();
                Modifier_Participant mf = new Modifier_Participant(iDParticipant);
                mf.Show();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Payer" && dataGridView1.Rows[e.RowIndex].Cells["etat"].Value == "Non payé")
            {
                DialogResult result = MessageBox.Show("Valider le payment", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int iDParticipant = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                    foreach (Participant p in GlobalData.Participants)
                    {
                        if (p.getIdParticipant() == iDParticipant)
                        {
                            p.payerFormation();
                            dataGridView1.Rows[e.RowIndex].Cells["etat"].Value = "Payé";

                            break;
                        }
                    }
                }
            }

        }

        private void participants_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }

        private void btn_modif_participant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_Participant ap = new Ajout_Participant();
            ap.Show();
        }
    }
}
