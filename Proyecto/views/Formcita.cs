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
            controllerCita Ccita = new controllerCita();
            Ccita.update(txtID, txtLugar, DTPfecha, DTPhora, CboxDosis, CboxDUI);
            Ccita.read(dgvcabina, CboxDosis, CboxDUI);

            MessageBox.Show("Usuario Modificado correctamente", "Clinica",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            frm.Show();
            this.Close();
        }

        private void Formcita_Load(object sender, EventArgs e)
        {
            controllerCita CCita = new controllerCita();
            CCita.read(dgvcabina, CboxDosis, CboxDUI);            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            controllerCita CCita = new controllerCita();
            CCita.insert(txtLugar, DTPfecha, DTPhora, CboxDosis, CboxDUI);
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

        private void dgvcabina_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[0].Value.ToString();
            txtLugar.Text = dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[1].Value.ToString();
            DTPfecha.Value = DateTime.Parse(dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[2].Value.ToString());
            DTPhora.Value = DateTime.Parse(dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[3].Value.ToString());
            CboxDosis.SelectedValue = (int) dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[4].Value;
            CboxDUI.SelectedValue = (int) dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[5].Value;
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            controllerCita Ccita = new controllerCita();
            Ccita.delete(txtID);
            Ccita.read(dgvcabina, CboxDosis, CboxDUI);
            MessageBox.Show("Usuario Eliminado correctamente", "Clinica",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
