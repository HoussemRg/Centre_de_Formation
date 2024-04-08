namespace Formation
{
    partial class Formateurs
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
            btn_back = new Button();
            dataGridView1 = new DataGridView();
            ajout_formateur = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(402, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 54);
            label1.TabIndex = 0;
            label1.Text = "Listes de Formateurs";
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(58, 20);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(110, 54);
            btn_back.TabIndex = 2;
            btn_back.Text = "<<";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
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
            dataGridView1.Location = new Point(38, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 351);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ajout_formateur
            // 
            ajout_formateur.BackColor = Color.Lime;
            ajout_formateur.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ajout_formateur.Location = new Point(999, 107);
            ajout_formateur.Name = "ajout_formateur";
            ajout_formateur.Size = new Size(218, 52);
            ajout_formateur.TabIndex = 5;
            ajout_formateur.Text = "Ajouter un Formateur";
            ajout_formateur.UseVisualStyleBackColor = false;
            ajout_formateur.Click += ajout_formateur_Click;
            // 
            // Formateurs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 489);
            Controls.Add(ajout_formateur);
            Controls.Add(dataGridView1);
            Controls.Add(btn_back);
            Controls.Add(label1);
            Name = "Formateurs";
            Text = "Formateurs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_back;
        private DataGridView dataGridView1;
        private Button ajout_formateur;
    }
}