namespace CentreFormation
{
    partial class Formations
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
            dataGridView1 = new DataGridView();
            btn_ajout_formation = new Button();
            btn_back_formations = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(381, 21);
            label1.Name = "label1";
            label1.Size = new Size(388, 54);
            label1.TabIndex = 0;
            label1.Text = "Liste de Formations";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 351);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_ajout_formation
            // 
            btn_ajout_formation.BackColor = Color.Lime;
            btn_ajout_formation.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            btn_ajout_formation.Location = new Point(1009, 104);
            btn_ajout_formation.Name = "btn_ajout_formation";
            btn_ajout_formation.Size = new Size(231, 56);
            btn_ajout_formation.TabIndex = 3;
            btn_ajout_formation.Text = "Ajouter une Formation";
            btn_ajout_formation.UseVisualStyleBackColor = false;
            btn_ajout_formation.Click += btn_ajout_formation_Click;
            // 
            // btn_back_formations
            // 
            btn_back_formations.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_back_formations.Location = new Point(39, 21);
            btn_back_formations.Name = "btn_back_formations";
            btn_back_formations.Size = new Size(94, 54);
            btn_back_formations.TabIndex = 4;
            btn_back_formations.Text = "<<";
            btn_back_formations.UseVisualStyleBackColor = true;
            btn_back_formations.Click += btn_back_formations_Click;
            // 
            // Formations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 489);
            Controls.Add(btn_back_formations);
            Controls.Add(btn_ajout_formation);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Formations";
            Text = "Formations";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_ajout_formation;
        private Button btn_back_formations;
    }
}