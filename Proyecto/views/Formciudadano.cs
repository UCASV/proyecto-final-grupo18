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
    public partial class Formciudadano : Form
    {
        public Formciudadano()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formciudadano_Load(object sender, EventArgs e)
        {
            controllerCiudadano controler = new controllerCiudadano();
            controler.read(dgvCiudadanos, comboBoxEnefermedades, comboBoxEmpleo, comboBoxDosis);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            controllerCiudadano controler = new controllerCiudadano();
            controler.insert(txtDui, txtNombre, txtDireccion, txtEmail, txtTelefono, comboBoxEnefermedades, comboBoxEmpleo, comboBoxDosis);
            controler.read(dgvCiudadanos, comboBoxEnefermedades, comboBoxEmpleo, comboBoxDosis);

            MessageBox.Show("Usuario insertado correctamente", "Clinica",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btngestor_Click(object sender, EventArgs e)
        {
            Formgestor frm = new Formgestor();
            frm.Show();
            this.Hide();
        }
    }
}
