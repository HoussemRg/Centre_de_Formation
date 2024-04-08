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


        }

        private void btn_sessions_Click(object sender, EventArgs e)
        {

        }

        private void btn_salles_Click(object sender, EventArgs e)
        {

        }
    }

}
