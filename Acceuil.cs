using CentreFormation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formation
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void btn_formateurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formateurs formateurs = new Formateurs();
            formateurs.Show();
        }

        private void btn_participants_Click(object sender, EventArgs e)
        {
            this.Hide();
            Participants participants = new Participants();
            participants.Show();

        }

        private void btn_sessions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sessions sess = new Sessions();
            sess.Show();

        }

        private void btn_salles_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListCours listCours = new ListCours();
            listCours.Show();
        }

        private void btn_formations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formations f = new Formations();
            f.Show();

        }

        private void btn_salles_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Salles s = new Salles();
            s.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
