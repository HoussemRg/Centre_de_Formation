namespace Formation
{
    partial class Ajout_Formateur
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
            nom_for_textbox = new TextBox();
            prenom_for_textbox = new TextBox();
            tel_for_textbox = new TextBox();
            salaire_form_textbox = new TextBox();
            panel1 = new Panel();
            btn_ajout_formateur = new Button();
            label6 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 1;
            label2.Text = "NOM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "PRENOM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 182);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 3;
            label4.Text = "TELEPHONE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 252);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 4;
            label5.Text = "SALAIRE";
            // 
            // nom_for_textbox
            // 
            nom_for_textbox.Location = new Point(86, 58);
            nom_for_textbox.Margin = new Padding(2);
            nom_for_textbox.Name = "nom_for_textbox";
            nom_for_textbox.Size = new Size(275, 25);
            nom_for_textbox.TabIndex = 6;
            // 
            // prenom_for_textbox
            // 
            prenom_for_textbox.Location = new Point(86, 129);
            prenom_for_textbox.Margin = new Padding(2);
            prenom_for_textbox.Name = "prenom_for_textbox";
            prenom_for_textbox.Size = new Size(275, 25);
            prenom_for_textbox.TabIndex = 7;
            // 
            // tel_for_textbox
            // 
            tel_for_textbox.Location = new Point(86, 201);
            tel_for_textbox.Margin = new Padding(2);
            tel_for_textbox.Name = "tel_for_textbox";
            tel_for_textbox.Size = new Size(275, 25);
            tel_for_textbox.TabIndex = 8;
            // 
            // salaire_form_textbox
            // 
            salaire_form_textbox.Location = new Point(86, 271);
            salaire_form_textbox.Margin = new Padding(2);
            salaire_form_textbox.Name = "salaire_form_textbox";
            salaire_form_textbox.Size = new Size(275, 25);
            salaire_form_textbox.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_ajout_formateur);
            panel1.Controls.Add(salaire_form_textbox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tel_for_textbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(prenom_for_textbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nom_for_textbox);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(239, 91);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 391);
            panel1.TabIndex = 10;
            // 
            // btn_ajout_formateur
            // 
            btn_ajout_formateur.BackColor = Color.Lime;
            btn_ajout_formateur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ajout_formateur.Location = new Point(142, 326);
            btn_ajout_formateur.Margin = new Padding(2);
            btn_ajout_formateur.Name = "btn_ajout_formateur";
            btn_ajout_formateur.Size = new Size(113, 46);
            btn_ajout_formateur.TabIndex = 10;
            btn_ajout_formateur.Text = "Ajouter";
            btn_ajout_formateur.UseVisualStyleBackColor = false;
            btn_ajout_formateur.Click += btn_ajout_formateur_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(340, 24);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(251, 26);
            label6.TabIndex = 11;
            label6.Text = "AJOUTER UN FORMATEUR";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            button1.Location = new Point(25, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 12;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ajout_Formateur
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "Ajout_Formateur";
            Text = "Ajout_Formateur";
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
        private TextBox nom_for_textbox;
        private TextBox prenom_for_textbox;
        private TextBox tel_for_textbox;
        private TextBox salaire_form_textbox;
        private Panel panel1;
        private Button btn_ajout_formateur;
        private Label label6;
        private Button button1;
    }
}