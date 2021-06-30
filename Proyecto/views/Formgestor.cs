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

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncita_Click_1(object sender, EventArgs e)
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            controllerGestor controler = new controllerGestor();
            controler.update(txtId, txtNombre, txtCorreo, txtDireccion,txtContra, cmbPrgunta, txtRespuesta);
            controler.read(dgvGestor, cmbPrgunta);

            MessageBox.Show("Usuario Modificó correctamente", "Clinica",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int? getId()
        {
            try
            {
                int id = int.Parse(dgvGestor.Rows[dgvGestor.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error");
                return null;
            }
        }

        private void dgvGestor_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvGestor.Rows[dgvGestor.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvGestor.Rows[dgvGestor.CurrentRow.Index].Cells[1].Value.ToString();
            txtContra.Text = dgvGestor.Rows[dgvGestor.CurrentRow.Index].Cells[2].Value.ToString();
            txtCorreo.Text = dgvGestor.Rows[dgvGestor.CurrentRow.Index].Cells[3].Value.ToString();
            txtDireccion.Text = dgvGestor.Rows[dgvGestor.CurrentRow.Index].Cells[4].Value.ToString();
            cmbPrgunta.SelectedValue = (int)dgvGestor.Rows[dgvGestor.CurrentRow.Index].Cells[5].Value;
            txtRespuesta.Text = dgvGestor.Rows[dgvGestor.CurrentRow.Index].Cells[6].Value.ToString();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            controllerGestor controler = new controllerGestor();
            controler.delete(txtId);

            controler.read(dgvGestor, cmbPrgunta);

            MessageBox.Show("Usuario Eliminado correctamente", "Clinica",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvGestor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
