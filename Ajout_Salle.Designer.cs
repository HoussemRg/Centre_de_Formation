namespace CentreFormation
{
    partial class Ajout_Salle
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
            numsalle_textbox = new TextBox();
            label3 = new Label();
            departement_textbox = new TextBox();
            label2 = new Label();
            ajouter_salle = new Button();
            label1 = new Label();
            btn_ajout_salle_back = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numsalle_textbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(departement_textbox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ajouter_salle);
            panel1.Location = new Point(321, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 279);
            panel1.TabIndex = 0;
            // 
            // numsalle_textbox
            // 
            numsalle_textbox.Location = new Point(22, 61);
            numsalle_textbox.Name = "numsalle_textbox";
            numsalle_textbox.Size = new Size(314, 27);
            numsalle_textbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 24);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Numero";
            // 
            // departement_textbox
            // 
            departement_textbox.Location = new Point(22, 142);
            departement_textbox.Name = "departement_textbox";
            departement_textbox.Size = new Size(314, 27);
            departement_textbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 110);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Departement";
            // 
            // ajouter_salle
            // 
            ajouter_salle.BackColor = Color.Lime;
            ajouter_salle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ajouter_salle.Location = new Point(128, 217);
            ajouter_salle.Name = "ajouter_salle";
            ajouter_salle.Size = new Size(94, 48);
            ajouter_salle.TabIndex = 0;
            ajouter_salle.Text = "Ajouter";
            ajouter_salle.UseVisualStyleBackColor = false;
            ajouter_salle.Click += ajouter_salle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(415, 49);
            label1.Name = "label1";
            label1.Size = new Size(177, 26);
            label1.TabIndex = 1;
            label1.Text = "Ajouter une Salle";
            // 
            // btn_ajout_salle_back
            // 
            btn_ajout_salle_back.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_ajout_salle_back.Location = new Point(56, 27);
            btn_ajout_salle_back.Name = "btn_ajout_salle_back";
            btn_ajout_salle_back.Size = new Size(94, 48);
            btn_ajout_salle_back.TabIndex = 2;
            btn_ajout_salle_back.Text = "<<";
            btn_ajout_salle_back.UseVisualStyleBackColor = true;
            btn_ajout_salle_back.Click += btn_ajout_salle_back_Click;
            // 
            // Ajout_Salle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(btn_ajout_salle_back);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Ajout_Salle";
            Text = "Ajout_Salle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox departement_textbox;
        private Label label2;
        private Button ajouter_salle;
        private Label label1;
        private Button btn_ajout_salle_back;
        private TextBox numsalle_textbox;
        private Label label3;
    }
}