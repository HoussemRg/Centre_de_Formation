namespace CentreFormation
{
    partial class Modifier_Session
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
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            duree_textbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            mdf_session = new Button();
            back_mod_session = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label1.Location = new Point(389, 24);
            label1.Name = "label1";
            label1.Size = new Size(298, 38);
            label1.TabIndex = 0;
            label1.Text = "Modifier une Session";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(duree_textbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(mdf_session);
            panel1.Location = new Point(280, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 423);
            panel1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(27, 269);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(340, 28);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 128);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(340, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // duree_textbox
            // 
            duree_textbox.Location = new Point(27, 62);
            duree_textbox.Name = "duree_textbox";
            duree_textbox.Size = new Size(340, 27);
            duree_textbox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 246);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 4;
            label5.Text = "Salle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 177);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Formateur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 105);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Date Debut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 39);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Durée (Jours)";
            // 
            // mdf_session
            // 
            mdf_session.BackColor = Color.Lime;
            mdf_session.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mdf_session.Location = new Point(164, 358);
            mdf_session.Name = "mdf_session";
            mdf_session.Size = new Size(103, 46);
            mdf_session.TabIndex = 0;
            mdf_session.Text = "Modifier";
            mdf_session.UseVisualStyleBackColor = false;
            mdf_session.Click += mdf_session_Click;
            // 
            // back_mod_session
            // 
            back_mod_session.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            back_mod_session.Location = new Point(44, 24);
            back_mod_session.Name = "back_mod_session";
            back_mod_session.Size = new Size(94, 57);
            back_mod_session.TabIndex = 1;
            back_mod_session.Text = "<<";
            back_mod_session.UseVisualStyleBackColor = true;
            back_mod_session.Click += back_mod_session_Click;
            // 
            // Modifier_Session
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 505);
            Controls.Add(back_mod_session);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Modifier_Session";
            Text = "Modifier_Session";
            Load += Modifier_Session_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button mdf_session;
        private Button back_mod_session;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox duree_textbox;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
    }
}