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
            btn_salles = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_formateurs
            // 
            btn_formateurs.BackgroundImage = (Image)resources.GetObject("btn_formateurs.BackgroundImage");
            btn_formateurs.BackgroundImageLayout = ImageLayout.Stretch;
            btn_formateurs.Location = new Point(65, 205);
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
            btn_participants.Location = new Point(400, 205);
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
            btn_sessions.Location = new Point(688, 205);
            btn_sessions.Name = "btn_sessions";
            btn_sessions.Size = new Size(200, 105);
            btn_sessions.TabIndex = 2;
            btn_sessions.UseVisualStyleBackColor = true;
            btn_sessions.Click += btn_sessions_Click;
            // 
            // btn_salles
            // 
            btn_salles.BackgroundImage = (Image)resources.GetObject("btn_salles.BackgroundImage");
            btn_salles.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salles.Location = new Point(958, 205);
            btn_salles.Name = "btn_salles";
            btn_salles.Size = new Size(203, 105);
            btn_salles.TabIndex = 3;
            btn_salles.UseVisualStyleBackColor = true;
            btn_salles.Click += btn_salles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 349);
            label1.Name = "label1";
            label1.Size = new Size(167, 38);
            label1.TabIndex = 4;
            label1.Text = "Formateurs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label2.Location = new Point(405, 349);
            label2.Name = "label2";
            label2.Size = new Size(172, 38);
            label2.TabIndex = 5;
            label2.Text = "Participants";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label3.Location = new Point(725, 349);
            label3.Name = "label3";
            label3.Size = new Size(130, 38);
            label3.TabIndex = 6;
            label3.Text = "Sessions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold);
            label4.Location = new Point(1015, 349);
            label4.Name = "label4";
            label4.Size = new Size(93, 38);
            label4.TabIndex = 7;
            label4.Text = "Salles";
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
            // Acceuil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 489);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_salles);
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
        private Button btn_salles;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}