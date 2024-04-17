namespace Formation
{
    partial class Ajout_Cours
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
            panel1 = new Panel();
            button1 = new Button();
            nom_cours_textbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            back_ajout_cours = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(nom_cours_textbox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(311, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 199);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(108, 130);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 2;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // nom_cours_textbox
            // 
            nom_cours_textbox.Location = new Point(23, 75);
            nom_cours_textbox.Name = "nom_cours_textbox";
            nom_cours_textbox.Size = new Size(310, 27);
            nom_cours_textbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom Cours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(407, 56);
            label2.Name = "label2";
            label2.Size = new Size(143, 26);
            label2.TabIndex = 1;
            label2.Text = "Ajouter Cours";
            // 
            // back_ajout_cours
            // 
            back_ajout_cours.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            back_ajout_cours.Location = new Point(51, 36);
            back_ajout_cours.Name = "back_ajout_cours";
            back_ajout_cours.Size = new Size(110, 54);
            back_ajout_cours.TabIndex = 2;
            back_ajout_cours.Text = "<<";
            back_ajout_cours.UseVisualStyleBackColor = true;
            back_ajout_cours.Click += back_ajout_cours_Click;
            // 
            // Ajout_Cours
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(back_ajout_cours);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Ajout_Cours";
            Text = "Ajout_Cours";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox nom_cours_textbox;
        private Label label2;
        private Button back_ajout_cours;
    }
}