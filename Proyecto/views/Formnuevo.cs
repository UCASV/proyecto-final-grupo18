using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.VacunacionContext;
using Proyecto.Controllers;
using Proyecto.views;
namespace Proyecto
{
    public partial class Formnuevo : Form
    {
        public Formnuevo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Formnuevo_Load(object sender, EventArgs e)
        {
            controllerGestor controler = new controllerGestor();
            controler.read2(cmbPregunta);
        }

        private void cmbPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerGestor controler = new controllerGestor();
            controler.insert(txtNombre, txtCorreo, txtDireccion, txtContra, cmbPregunta, txtRespuesta);
            controler.read2(cmbPregunta);

            MessageBox.Show("Usuario insertado correctamente", "Clinica",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSesion frm = new frmSesion();
            frm.Show();
            this.Close();
        }
    }
}
