using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.views
{
    public partial class Formmenu : Form
    {
        public Formmenu()
        {
            InitializeComponent();
        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncita_Click(object sender, EventArgs e)
        {
            Formcita frm = new Formcita();
            frm.Show();
            this.Hide();
        }

        private void btnciudadano_Click(object sender, EventArgs e)
        {
            Formciudadano frm = new Formciudadano();
            frm.Show();
            this.Hide();
        }

        private void btncabina_Click(object sender, EventArgs e)
        {
            Formcabina frm = new Formcabina();
            frm.Show();
            this.Hide();
        }

        private void btngestor_Click(object sender, EventArgs e)
        {
            Formgestor frm = new Formgestor();
            frm.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Formgestor frm = new Formgestor();
            frm.Show();
            this.Hide();
        }
    }
}
