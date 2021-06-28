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
using Proyecto.VacunacionContext;

namespace Proyecto
{
    public partial class Formcita : Form
    {
        public Formcita()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formcita_Load(object sender, EventArgs e)
        {
            controllerCita CCita = new controllerCita();
            CCita.read(dgvcabina, CboxDosis, CboxDUI);

            MessageBox.Show("Se ha ingresado datos correctamente", "Clinica",
                            MessageBoxButtons.OK ,
                            MessageBoxIcon.Information);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            controllerCita CCita = new controllerCita();
            CCita.insert(txtID, txtLugar, DTPfecha, DTPhora, CboxDosis, CboxDUI);
            CCita.read(dgvcabina, CboxDosis, CboxDUI);
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

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
