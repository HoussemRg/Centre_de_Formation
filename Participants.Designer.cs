namespace CentreFormation
{
    partial class Participants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            participants_btn_back = new Button();
            dataGridView1 = new DataGridView();
            btn_modif_participant = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(440, 29);
            label1.Name = "label1";
            label1.Size = new Size(416, 54);
            label1.TabIndex = 0;
            label1.Text = "Liste des Participants";
            // 
            // participants_btn_back
            // 
            participants_btn_back.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            participants_btn_back.Location = new Point(50, 30);
            participants_btn_back.Name = "participants_btn_back";
            participants_btn_back.Size = new Size(94, 53);
            participants_btn_back.TabIndex = 1;
            participants_btn_back.Text = "<<";
            participants_btn_back.UseVisualStyleBackColor = true;
            participants_btn_back.Click += participants_btn_back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 351);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_modif_participant
            // 
            btn_modif_participant.BackColor = Color.Lime;
            btn_modif_participant.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            btn_modif_participant.Location = new Point(1018, 115);
            btn_modif_participant.Name = "btn_modif_participant";
            btn_modif_participant.Size = new Size(218, 63);
            btn_modif_participant.TabIndex = 3;
            btn_modif_participant.Text = "Ajouter Participant";
            btn_modif_participant.UseVisualStyleBackColor = false;
            btn_modif_participant.Click += btn_modif_participant_Click;
            // 
            // Participants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 489);
            Controls.Add(btn_modif_participant);
            Controls.Add(dataGridView1);
            Controls.Add(participants_btn_back);
            Controls.Add(label1);
            Name = "Participants";
            Text = "Participants";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button participants_btn_back;
        private DataGridView dataGridView1;
        private Button btn_modif_participant;
    }
}