namespace CentreFormation
{
    partial class Ajout_Session
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
            button1 = new Button();
            panel1 = new Panel();
            salle_combo = new ComboBox();
            duree_textbox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            formateur_combo = new ComboBox();
            formation_combo = new ComboBox();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
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
            label1.Location = new Point(393, 32);
            label1.Name = "label1";
            label1.Size = new Size(183, 26);
            label1.TabIndex = 0;
            label1.Text = "Créer une Session";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            button1.Location = new Point(71, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 55);
            button1.TabIndex = 1;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(salle_combo);
            panel1.Controls.Add(duree_textbox);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(formateur_combo);
            panel1.Controls.Add(formation_combo);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(282, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 393);
            panel1.TabIndex = 2;
            // 
            // salle_combo
            // 
            salle_combo.FormattingEnabled = true;
            salle_combo.Location = new Point(30, 276);
            salle_combo.Name = "salle_combo";
            salle_combo.Size = new Size(343, 28);
            salle_combo.TabIndex = 10;
            salle_combo.SelectedIndexChanged += salle_combo_SelectedIndexChanged;
            // 
            // duree_textbox
            // 
            duree_textbox.Location = new Point(30, 223);
            duree_textbox.Name = "duree_textbox";
            duree_textbox.Size = new Size(343, 27);
            duree_textbox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 170);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(343, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // formateur_combo
            // 
            formateur_combo.FormattingEnabled = true;
            formateur_combo.Location = new Point(30, 110);
            formateur_combo.Name = "formateur_combo";
            formateur_combo.Size = new Size(343, 28);
            formateur_combo.TabIndex = 7;
            formateur_combo.SelectedIndexChanged += formateur_combo_SelectedIndexChanged;
            // 
            // formation_combo
            // 
            formation_combo.FormattingEnabled = true;
            formation_combo.Location = new Point(30, 49);
            formation_combo.Name = "formation_combo";
            formation_combo.Size = new Size(343, 28);
            formation_combo.TabIndex = 6;
            formation_combo.SelectedIndexChanged += formation_combo_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(141, 321);
            button2.Name = "button2";
            button2.Size = new Size(94, 50);
            button2.TabIndex = 5;
            button2.Text = "Créer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 253);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 4;
            label6.Text = "Salle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 200);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 3;
            label5.Text = "Durée (Jours)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 141);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 2;
            label4.Text = "Date Debut";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 80);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Formateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 16);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Formation";
            // 
            // Ajout_Session
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Ajout_Session";
            Text = "Ajout_Session";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox salle_combo;
        private TextBox duree_textbox;
        private DateTimePicker dateTimePicker1;
        private ComboBox formateur_combo;
        private ComboBox formation_combo;
    }
}