using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.VacunacionContext;//importen el context en sus archivos
using Proyecto.Controllers;

namespace Proyecto
{
    public partial class Formcabina : Form
    {
        public Formcabina()
        {
            InitializeComponent();
        }

        private void dgvcabina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Formcabina_Load(object sender, EventArgs e)
        {
            controllerCabina controler = new controllerCabina();
            controler.read(dgvcabina, cbgestor);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            controllerCabina controler = new controllerCabina();
            controler.insert(txtubicacion, cbgestor, txtcorreo, txttelefono);   
            controler.read(dgvcabina, cbgestor);

            MessageBox.Show(" insertado correctamente", "...",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
