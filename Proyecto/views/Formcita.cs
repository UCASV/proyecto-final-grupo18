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

        private void button7_Click(object sender, EventArgs e) //Boton de guardar datos
        {
            var db = new Vacunacion_DBContext();
            Citum ci = new Citum();
            ci.Lugar = txtLugar.Text;  
            ci.Fecha = dateTimePicker1.Value;
            ci.Hora =  dateTimePicker2.Value;
            ci.IdDosis = CBoxDosis.SelectedIndex;

            db.Cita.Add(ci);
            db.SaveChanges();
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

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
