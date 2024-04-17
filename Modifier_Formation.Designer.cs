namespace CentreFormation
{
    partial class Modifier_Formation
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
            comboBox1 = new ComboBox();
            prix_for_textbox = new TextBox();
            nom_for_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(prix_for_textbox);
            panel1.Controls.Add(nom_for_textbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(233, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 391);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(47, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(372, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // prix_for_textbox
            // 
            prix_for_textbox.Location = new Point(47, 172);
            prix_for_textbox.Name = "prix_for_textbox";
            prix_for_textbox.Size = new Size(372, 27);
            prix_for_textbox.TabIndex = 7;
            // 
            // nom_for_textbox
            // 
            nom_for_textbox.Location = new Point(47, 98);
            nom_for_textbox.Name = "nom_for_textbox";
            nom_for_textbox.Size = new Size(372, 27);
            nom_for_textbox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 215);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Cours";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 140);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 4;
            label3.Text = "Prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 63);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Nom Formation";
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(176, 318);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 0;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            button1.Location = new Point(28, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 51);
            button1.TabIndex = 1;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(339, 40);
            label1.Name = "label1";
            label1.Size = new Size(234, 26);
            label1.TabIndex = 2;
            label1.Text = "Modifier une Formation";
            // 
            // Modifier_Formation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Modifier_Formation";
            Text = "Modifier_Formation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox prix_for_textbox;
        private TextBox nom_for_textbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}