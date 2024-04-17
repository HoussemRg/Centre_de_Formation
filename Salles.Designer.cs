namespace CentreFormation
{
    partial class Salles
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
            btn_back_salles = new Button();
            dataGridView1 = new DataGridView();
            btn_ajout_salle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(414, 22);
            label1.Name = "label1";
            label1.Size = new Size(303, 54);
            label1.TabIndex = 0;
            label1.Text = "Liste des Salles";
            // 
            // btn_back_salles
            // 
            btn_back_salles.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_back_salles.Location = new Point(61, 22);
            btn_back_salles.Name = "btn_back_salles";
            btn_back_salles.Size = new Size(94, 58);
            btn_back_salles.TabIndex = 1;
            btn_back_salles.Text = "<<";
            btn_back_salles.UseVisualStyleBackColor = true;
            btn_back_salles.Click += btn_back_salles_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 351);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_ajout_salle
            // 
            btn_ajout_salle.BackColor = Color.Lime;
            btn_ajout_salle.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            btn_ajout_salle.ForeColor = Color.Black;
            btn_ajout_salle.Location = new Point(1020, 106);
            btn_ajout_salle.Name = "btn_ajout_salle";
            btn_ajout_salle.Size = new Size(207, 57);
            btn_ajout_salle.TabIndex = 3;
            btn_ajout_salle.Text = "Ajouter une Salle";
            btn_ajout_salle.UseVisualStyleBackColor = false;
            btn_ajout_salle.Click += btn_ajout_salle_Click;
            // 
            // Salles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 489);
            Controls.Add(btn_ajout_salle);
            Controls.Add(dataGridView1);
            Controls.Add(btn_back_salles);
            Controls.Add(label1);
            Name = "Salles";
            Text = "Salles";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_back_salles;
        private DataGridView dataGridView1;
        private Button btn_ajout_salle;
    }
}