namespace Formation
{
    partial class ListCours
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
            btn_cours_back = new Button();
            dataGridView1 = new DataGridView();
            btn_ajout_cours = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(486, 26);
            label1.Name = "label1";
            label1.Size = new Size(287, 54);
            label1.TabIndex = 0;
            label1.Text = "Liste de Cours";
            // 
            // btn_cours_back
            // 
            btn_cours_back.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_cours_back.Location = new Point(42, 26);
            btn_cours_back.Name = "btn_cours_back";
            btn_cours_back.Size = new Size(110, 54);
            btn_cours_back.TabIndex = 1;
            btn_cours_back.Text = "<<";
            btn_cours_back.UseVisualStyleBackColor = true;
            btn_cours_back.Click += btn_cours_back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 351);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_ajout_cours
            // 
            btn_ajout_cours.BackColor = Color.Lime;
            btn_ajout_cours.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            btn_ajout_cours.Location = new Point(1009, 126);
            btn_ajout_cours.Name = "btn_ajout_cours";
            btn_ajout_cours.Size = new Size(218, 52);
            btn_ajout_cours.TabIndex = 3;
            btn_ajout_cours.Text = "Ajouter un Cours";
            btn_ajout_cours.UseVisualStyleBackColor = false;
            btn_ajout_cours.Click += btn_ajout_cours_Click;
            // 
            // ListCours
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 489);
            Controls.Add(btn_ajout_cours);
            Controls.Add(dataGridView1);
            Controls.Add(btn_cours_back);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "ListCours";
            Text = "ListCours";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_cours_back;
        private DataGridView dataGridView1;
        private Button btn_ajout_cours;
    }
}