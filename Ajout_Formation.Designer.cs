namespace CentreFormation
{
    partial class Ajout_Formation
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
            ajout_formation_btn = new Button();
            comboBox1 = new ComboBox();
            prix_form_textbox = new TextBox();
            nom_for_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_back_ajout_for = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ajout_formation_btn);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(prix_form_textbox);
            panel1.Controls.Add(nom_for_textbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(255, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 391);
            panel1.TabIndex = 0;
            // 
            // ajout_formation_btn
            // 
            ajout_formation_btn.BackColor = Color.Lime;
            ajout_formation_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ajout_formation_btn.Location = new Point(164, 299);
            ajout_formation_btn.Name = "ajout_formation_btn";
            ajout_formation_btn.Size = new Size(109, 48);
            ajout_formation_btn.TabIndex = 6;
            ajout_formation_btn.Text = "Ajouter";
            ajout_formation_btn.UseVisualStyleBackColor = false;
            ajout_formation_btn.Click += ajout_formation_btn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(344, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // prix_form_textbox
            // 
            prix_form_textbox.Location = new Point(56, 140);
            prix_form_textbox.Name = "prix_form_textbox";
            prix_form_textbox.Size = new Size(344, 27);
            prix_form_textbox.TabIndex = 4;
            // 
            // nom_for_textbox
            // 
            nom_for_textbox.Location = new Point(56, 64);
            nom_for_textbox.Name = "nom_for_textbox";
            nom_for_textbox.Size = new Size(344, 27);
            nom_for_textbox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 192);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "Cours";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 104);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 1;
            label3.Text = "Prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 28);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 0;
            label2.Text = "Nom Formation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(388, 28);
            label1.Name = "label1";
            label1.Size = new Size(228, 26);
            label1.TabIndex = 1;
            label1.Text = "Ajouter une Formation";
            // 
            // btn_back_ajout_for
            // 
            btn_back_ajout_for.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_back_ajout_for.Location = new Point(44, 12);
            btn_back_ajout_for.Name = "btn_back_ajout_for";
            btn_back_ajout_for.Size = new Size(94, 56);
            btn_back_ajout_for.TabIndex = 2;
            btn_back_ajout_for.Text = "<<";
            btn_back_ajout_for.UseVisualStyleBackColor = true;
            btn_back_ajout_for.Click += btn_back_ajout_for_Click;
            // 
            // Ajout_Formation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(btn_back_ajout_for);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Ajout_Formation";
            Text = "Ajout_Formation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox prix_form_textbox;
        private TextBox nom_for_textbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_back_ajout_for;
        private Button ajout_formation_btn;
        private ComboBox comboBox1;
    }
}