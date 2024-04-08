namespace Formation
{
    partial class Modifier_Formateur
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btn_modifier_formateur = new Button();
            mdf_for_salaire = new TextBox();
            mdf_for_tel = new TextBox();
            mdf_for_prenom = new TextBox();
            mdf_for_nom = new TextBox();
            label6 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 15);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "NOM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 92);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "PRENOM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 164);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "TELEPHONE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 239);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "SALAIRE";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_modifier_formateur);
            panel1.Controls.Add(mdf_for_salaire);
            panel1.Controls.Add(mdf_for_tel);
            panel1.Controls.Add(mdf_for_prenom);
            panel1.Controls.Add(mdf_for_nom);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(269, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 408);
            panel1.TabIndex = 6;
            // 
            // btn_modifier_formateur
            // 
            btn_modifier_formateur.BackColor = Color.Lime;
            btn_modifier_formateur.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_modifier_formateur.Location = new Point(140, 335);
            btn_modifier_formateur.Name = "btn_modifier_formateur";
            btn_modifier_formateur.Size = new Size(116, 48);
            btn_modifier_formateur.TabIndex = 10;
            btn_modifier_formateur.Text = "Modifier";
            btn_modifier_formateur.UseVisualStyleBackColor = false;
            btn_modifier_formateur.Click += btn_modifier_formateur_Click;
            // 
            // mdf_for_salaire
            // 
            mdf_for_salaire.Location = new Point(61, 262);
            mdf_for_salaire.Name = "mdf_for_salaire";
            mdf_for_salaire.Size = new Size(328, 27);
            mdf_for_salaire.TabIndex = 9;
            // 
            // mdf_for_tel
            // 
            mdf_for_tel.Location = new Point(61, 187);
            mdf_for_tel.Name = "mdf_for_tel";
            mdf_for_tel.Size = new Size(328, 27);
            mdf_for_tel.TabIndex = 8;
            // 
            // mdf_for_prenom
            // 
            mdf_for_prenom.Location = new Point(61, 115);
            mdf_for_prenom.Name = "mdf_for_prenom";
            mdf_for_prenom.Size = new Size(328, 27);
            mdf_for_prenom.TabIndex = 7;
            // 
            // mdf_for_nom
            // 
            mdf_for_nom.Location = new Point(61, 38);
            mdf_for_nom.Name = "mdf_for_nom";
            mdf_for_nom.Size = new Size(328, 27);
            mdf_for_nom.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(340, 9);
            label6.Name = "label6";
            label6.Size = new Size(319, 38);
            label6.TabIndex = 7;
            label6.Text = "Modifier un Formateur";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            button1.Location = new Point(37, 9);
            button1.Name = "button1";
            button1.Size = new Size(94, 51);
            button1.TabIndex = 8;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Modifier_Formateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Name = "Modifier_Formateur";
            Text = "Modifier_Formateur";
            Load += Modifier_Formateur_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private TextBox mdf_for_salaire;
        private TextBox mdf_for_tel;
        private TextBox mdf_for_prenom;
        private TextBox mdf_for_nom;
        private Label label6;
        private Button btn_modifier_formateur;
        private Button button1;
    }
}