using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controllers;

namespace Proyecto.views
{
    public partial class frmSesion : Form
    {
        public frmSesion()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void Formsesion_Load(object sender, EventArgs e)
        {
            controllerGestor controller = new controllerGestor();
            controller.readRegistro(dgvusuarios);
        }
    }
}
