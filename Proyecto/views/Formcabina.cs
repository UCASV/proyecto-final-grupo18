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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            controllerCabina controler = new controllerCabina();
            controler.update(txtId, txtubicacion, cbgestor, txtcorreo, txttelefono);
            controler.read(dgvcabina, cbgestor);

            MessageBox.Show("Usuario Modificó correctamente", "Clinica",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int? getId()
        {
            try
            {
                int id = int.Parse(dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error");
                return null;
            }
        }

        private void dgvcabina_SelectionChanged_1(object sender, EventArgs e)
        {

            txtId.Text = dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[0].Value.ToString();
            txtubicacion.Text = dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[1].Value.ToString();
            cbgestor.SelectedValue = (int)dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[2].Value;
            txtcorreo.Text = dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[3].Value.ToString();
            txttelefono.Text = dgvcabina.Rows[dgvcabina.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            controllerCabina controler = new controllerCabina();
            controler.delete(txtId);

            controler.read(dgvcabina, cbgestor);

            MessageBox.Show("Usuario insertado correctamente", "Clinica",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
