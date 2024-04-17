namespace CentreFormation
{
    partial class Sessions
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
            btn_back_sessions = new Button();
            btn_creer_session = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(381, 14);
            label1.Name = "label1";
            label1.Size = new Size(355, 54);
            label1.TabIndex = 0;
            label1.Text = "Liste des Sessions";
            // 
            // btn_back_sessions
            // 
            btn_back_sessions.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_back_sessions.Location = new Point(58, 14);
            btn_back_sessions.Name = "btn_back_sessions";
            btn_back_sessions.Size = new Size(94, 48);
            btn_back_sessions.TabIndex = 1;
            btn_back_sessions.Text = "<<";
            btn_back_sessions.UseVisualStyleBackColor = true;
            btn_back_sessions.Click += btn_back_sessions_Click;
            // 
            // btn_creer_session
            // 
            btn_creer_session.BackColor = Color.Lime;
            btn_creer_session.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            btn_creer_session.Location = new Point(1037, 106);
            btn_creer_session.Name = "btn_creer_session";
            btn_creer_session.Size = new Size(190, 60);
            btn_creer_session.TabIndex = 2;
            btn_creer_session.Text = "Créer une Session";
            btn_creer_session.UseVisualStyleBackColor = false;
            btn_creer_session.Click += btn_creer_session_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(953, 351);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Sessions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 489);
            Controls.Add(dataGridView1);
            Controls.Add(btn_creer_session);
            Controls.Add(btn_back_sessions);
            Controls.Add(label1);
            Name = "Sessions";
            Text = "Sessions";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_back_sessions;
        private Button btn_creer_session;
        private DataGridView dataGridView1;
    }
}