namespace Formation
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            btn_formateurs = new Button();
            btn_participants = new Button();
            btn_sessions = new Button();
            btn_cours = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_formations = new Button();
            label6 = new Label();
            btn_list_salles = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // btn_formateurs
            // 
            btn_formateurs.BackgroundImage = (Image)resources.GetObject("btn_formateurs.BackgroundImage");
            btn_formateurs.BackgroundImageLayout = ImageLayout.Stretch;
            btn_formateurs.Location = new Point(65, 114);
            btn_formateurs.Name = "btn_formateurs";
            btn_formateurs.Size = new Size(167, 105);
            btn_formateurs.TabIndex = 0;
            btn_formateurs.UseVisualStyleBackColor = true;
            btn_formateurs.Click += btn_formateurs_Click;
            // 
            // btn_participants
            // 
            btn_participants.BackgroundImage = (Image)resources.GetObject("btn_participants.BackgroundImage");
            btn_participants.BackgroundImageLayout = ImageLayout.Stretch;
            btn_participants.Location = new Point(65, 321);
            btn_participants.Name = "btn_participants";
            btn_participants.Size = new Size(177, 105);
            btn_participants.TabIndex = 1;
            btn_participants.UseVisualStyleBackColor = true;
            btn_participants.Click += btn_participants_Click;
            // 
            // btn_sessions
            // 
            btn_sessions.BackgroundImage = (Image)resources.GetObject("btn_sessions.BackgroundImage");
            btn_sessions.BackgroundImageLayout = ImageLayout.Stretch;
            btn_sessions.Location = new Point(942, 114);
            btn_sessions.Name = "btn_sessions";
            btn_sessions.Size = new Size(200, 105);
            btn_sessions.TabIndex = 2;
            btn_sessions.UseVisualStyleBackColor = true;
            btn_sessions.Click += btn_sessions_Click;
            // 
            // btn_cours
            // 
            btn_cours.BackgroundImage = (Image)resources.GetObject("btn_cours.BackgroundImage");
            btn_cours.BackgroundImageLayout = ImageLayout.Stretch;
            btn_cours.Location = new Point(498, 321);
            btn_cours.Name = "btn_cours";
            btn_cours.Size = new Size(203, 105);
            btn_cours.TabIndex = 3;
            btn_cours.UseVisualStyleBackColor = true;
            btn_cours.Click += btn_salles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 233);
            label1.Name = "label1";
            label1.Size = new Size(167, 38);
            label1.TabIndex = 4;
            label1.Text = "Formateurs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label2.Location = new Point(65, 442);
            label2.Name = "label2";
            label2.Size = new Size(172, 38);
            label2.TabIndex = 5;
            label2.Text = "Participants";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label3.Location = new Point(978, 233);
            label3.Name = "label3";
            label3.Size = new Size(130, 38);
            label3.TabIndex = 6;
            label3.Text = "Sessions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label4.Location = new Point(523, 442);
            label4.Name = "label4";
            label4.Size = new Size(93, 38);
            label4.TabIndex = 7;
            label4.Text = "Cours";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(453, 42);
            label5.Name = "label5";
            label5.Size = new Size(348, 35);
            label5.TabIndex = 8;
            label5.Text = "Centre de Formation";
            // 
            // btn_formations
            // 
            btn_formations.BackgroundImage = (Image)resources.GetObject("btn_formations.BackgroundImage");
            btn_formations.BackgroundImageLayout = ImageLayout.Stretch;
            btn_formations.Location = new Point(512, 114);
            btn_formations.Name = "btn_formations";
            btn_formations.Size = new Size(176, 105);
            btn_formations.TabIndex = 9;
            btn_formations.UseVisualStyleBackColor = true;
            btn_formations.Click += btn_formations_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label6.Location = new Point(523, 233);
            label6.Name = "label6";
            label6.Size = new Size(165, 38);
            label6.TabIndex = 10;
            label6.Text = "Formations";
            // 
            // btn_list_salles
            // 
            btn_list_salles.BackgroundImage = (Image)resources.GetObject("btn_list_salles.BackgroundImage");
            btn_list_salles.BackgroundImageLayout = ImageLayout.Stretch;
            btn_list_salles.Location = new Point(942, 321);
            btn_list_salles.Name = "btn_list_salles";
            btn_list_salles.Size = new Size(203, 105);
            btn_list_salles.TabIndex = 11;
            btn_list_salles.UseVisualStyleBackColor = true;
            btn_list_salles.Click += btn_salles_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label7.Location = new Point(993, 442);
            label7.Name = "label7";
            label7.Size = new Size(93, 38);
            label7.TabIndex = 12;
            label7.Text = "Salles";
            // 
            // Acceuil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 489);
            Controls.Add(label7);
            Controls.Add(btn_list_salles);
            Controls.Add(label6);
            Controls.Add(btn_formations);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_cours);
            Controls.Add(btn_sessions);
            Controls.Add(btn_participants);
            Controls.Add(btn_formateurs);
            Name = "Acceuil";
            Text = "Acceuil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_formateurs;
        private Button btn_participants;
        private Button btn_sessions;
        private Button btn_cours;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_formations;
        private Label label6;
        private Button btn_list_salles;
        private Label label7;
    }
}