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
    public partial class Formgestor : Form
    {
        public Formgestor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btncita_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            controllerGestor controler = new controllerGestor();
            controler.insert(txtNombre, txtCorreo, txtDireccion, txtContra , cmbPrgunta, txtRespuesta );
            controler.read(dgvGestor, cmbPrgunta);

            MessageBox.Show("Usuario insertado correctamente", "Clinica",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Formgestor_Load(object sender, EventArgs e)
        {
            controllerGestor controler = new controllerGestor();
            controler.read(dgvGestor, cmbPrgunta);
        }
    }
}
