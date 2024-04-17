namespace CentreFormation
{
    partial class Ajout_Participant
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
            btn_ajout_part_back = new Button();
            panel1 = new Panel();
            btn_ajout_part = new Button();
            tel_textbox = new TextBox();
            prenom_textbox = new TextBox();
            nom_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(408, 25);
            label1.Name = "label1";
            label1.Size = new Size(224, 26);
            label1.TabIndex = 0;
            label1.Text = "Ajouter un Participant";
            // 
            // btn_ajout_part_back
            // 
            btn_ajout_part_back.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_ajout_part_back.Location = new Point(43, 16);
            btn_ajout_part_back.Name = "btn_ajout_part_back";
            btn_ajout_part_back.Size = new Size(94, 50);
            btn_ajout_part_back.TabIndex = 1;
            btn_ajout_part_back.Text = "<<";
            btn_ajout_part_back.UseVisualStyleBackColor = true;
            btn_ajout_part_back.Click += btn_ajout_part_back_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_ajout_part);
            panel1.Controls.Add(tel_textbox);
            panel1.Controls.Add(prenom_textbox);
            panel1.Controls.Add(nom_textbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(297, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 391);
            panel1.TabIndex = 2;
            // 
            // btn_ajout_part
            // 
            btn_ajout_part.BackColor = Color.Lime;
            btn_ajout_part.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ajout_part.Location = new Point(164, 306);
            btn_ajout_part.Name = "btn_ajout_part";
            btn_ajout_part.Size = new Size(94, 58);
            btn_ajout_part.TabIndex = 6;
            btn_ajout_part.Text = "Ajouter";
            btn_ajout_part.UseVisualStyleBackColor = false;
            btn_ajout_part.Click += btn_ajout_part_Click;
            // 
            // tel_textbox
            // 
            tel_textbox.Location = new Point(32, 212);
            tel_textbox.Name = "tel_textbox";
            tel_textbox.Size = new Size(383, 27);
            tel_textbox.TabIndex = 5;
            // 
            // prenom_textbox
            // 
            prenom_textbox.Location = new Point(32, 147);
            prenom_textbox.Name = "prenom_textbox";
            prenom_textbox.Size = new Size(383, 27);
            prenom_textbox.TabIndex = 4;
            // 
            // nom_textbox
            // 
            nom_textbox.Location = new Point(32, 85);
            nom_textbox.Name = "nom_textbox";
            nom_textbox.Size = new Size(383, 27);
            nom_textbox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 189);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 2;
            label4.Text = "Téléphone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 124);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 1;
            label3.Text = "Prénom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 62);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Nom";
            // 
            // Ajout_Participant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(panel1);
            Controls.Add(btn_ajout_part_back);
            Controls.Add(label1);
            Name = "Ajout_Participant";
            Text = "Ajout_Participant";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_ajout_part_back;
        private Panel panel1;
        private TextBox tel_textbox;
        private TextBox prenom_textbox;
        private TextBox nom_textbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_ajout_part;
    }
}