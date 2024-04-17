namespace CentreFormation
{
    partial class Modifier_Participant
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
            modifier_btn = new Button();
            tel_textbox = new TextBox();
            prenom_textbox = new TextBox();
            nom_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_modif_part_back = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(modifier_btn);
            panel1.Controls.Add(tel_textbox);
            panel1.Controls.Add(prenom_textbox);
            panel1.Controls.Add(nom_textbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(263, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 408);
            panel1.TabIndex = 0;
            // 
            // modifier_btn
            // 
            modifier_btn.BackColor = Color.Lime;
            modifier_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            modifier_btn.Location = new Point(155, 332);
            modifier_btn.Name = "modifier_btn";
            modifier_btn.Size = new Size(126, 41);
            modifier_btn.TabIndex = 6;
            modifier_btn.Text = "Modifier";
            modifier_btn.UseVisualStyleBackColor = false;
            modifier_btn.Click += modifier_btn_Click;
            // 
            // tel_textbox
            // 
            tel_textbox.Location = new Point(34, 250);
            tel_textbox.Name = "tel_textbox";
            tel_textbox.Size = new Size(401, 27);
            tel_textbox.TabIndex = 5;
            // 
            // prenom_textbox
            // 
            prenom_textbox.Location = new Point(34, 167);
            prenom_textbox.Name = "prenom_textbox";
            prenom_textbox.Size = new Size(401, 27);
            prenom_textbox.TabIndex = 4;
            // 
            // nom_textbox
            // 
            nom_textbox.Location = new Point(34, 80);
            nom_textbox.Name = "nom_textbox";
            nom_textbox.Size = new Size(401, 27);
            nom_textbox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 212);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 2;
            label4.Text = "Téléphone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 135);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 1;
            label3.Text = "Prénom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 48);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Nom ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label1.Location = new Point(340, 23);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 1;
            label1.Text = "Modifier Participant";
            // 
            // btn_modif_part_back
            // 
            btn_modif_part_back.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_modif_part_back.Location = new Point(24, 23);
            btn_modif_part_back.Name = "btn_modif_part_back";
            btn_modif_part_back.Size = new Size(94, 53);
            btn_modif_part_back.TabIndex = 2;
            btn_modif_part_back.Text = "<<";
            btn_modif_part_back.UseVisualStyleBackColor = true;
            btn_modif_part_back.Click += btn_modif_part_back_Click;
            // 
            // Modifier_Participant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(btn_modif_part_back);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Modifier_Participant";
            Text = "Modifier_Participant";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_modif_part_back;
        private Button modifier_btn;
        private TextBox tel_textbox;
        private TextBox prenom_textbox;
        private TextBox nom_textbox;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}