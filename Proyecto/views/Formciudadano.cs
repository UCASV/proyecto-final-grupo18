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

        private void btnmodificar_Click(object sender, EventArgs e)
        {           
           controllerCiudadano controler = new controllerCiudadano();
           controler.update(txtId, txtDui, txtNombre, txtDireccion, txtEmail, txtTelefono, comboBoxEnefermedades, comboBoxEmpleo, comboBoxDosis);  
           controler.read(dgvCiudadanos, comboBoxEnefermedades, comboBoxEmpleo, comboBoxDosis);

            MessageBox.Show("Usuario Modificó correctamente", "Clinica",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ? getId()
        {
            try
            {
                int id = int.Parse(dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[0].Value.ToString());
                return id;                
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocurrio un error");
                return null;
            }
        }

        private void dgvCiudadanos_SelectionChanged(object sender, EventArgs e)
        {
            //los cell[numero] tienen que ir en orden con su respectivo TextBox

            txtId.Text = dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[1].Value.ToString();
            txtDireccion.Text = dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[2].Value.ToString();
            txtEmail.Text = dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[3].Value.ToString();
            txtTelefono.Text = dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[4].Value.ToString();
            comboBoxEnefermedades.SelectedValue = (int) dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[5].Value;
            comboBoxEmpleo.SelectedValue = (int) dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[6].Value;
            comboBoxDosis.SelectedValue = (int) dgvCiudadanos.Rows[dgvCiudadanos.CurrentRow.Index].Cells[7].Value;            

        }        
                
    }
}
