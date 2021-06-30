using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto.VacunacionContext;
using Proyecto.Controllers;
using Proyecto.views;

namespace Proyecto
{
    public partial class Formolvido : Form
    {
        
        public Formolvido()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formolvido_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new Vacunacion_DBContext();
            var listGestores = db.Gestors
                .Include(g => g.IdPreguntaNavigation)
                .ToList();
            var Result = listGestores.Where(g =>
                g.CorreoInstitucional.Equals((txtuser.Text))).ToList();
            bool found = Result.Count() > 0;
            Pregunta sq = Result[0].IdPreguntaNavigation;

            if (found)
            {
                lblQuestion.Text = sq.Pregunta1;
                MessageBox.Show("Usuario encontrado, ahora ingresa la respuesta a tu pregunta de seguridad", "Clinic",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = new Vacunacion_DBContext();
            var listaGestores = db.Gestors
                .OrderBy(c => c.Id)
                .ToList();
            var resultado = listaGestores.Where(
                g => g.Respuesta == txtrespuesta.Text
            ).ToList(); 

            if (resultado.Count == 0)
                MessageBox.Show("Error!, vuelva a ingresar su respuesta", "Clinica Uca",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Gestor g = resultado[0];
                button4.Enabled = true;
                MessageBox.Show("Has recuperado tu cuenta, ahora ingresa tu nueva contrasena", "Clinica Uca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var db = new Vacunacion_DBContext();
            var listaUsers = db.Gestors
                .OrderBy(c => c.Id)
                .ToList();
            var resultado = listaUsers.Where(
                u => u.Respuesta == txtrespuesta.Text
            ).ToList();

            Gestor u = resultado[0];
            u.Contrasena = txtVerificar.Text;
            db.Update(u);
            db.SaveChanges();
            MessageBox.Show("Se ha establecido correctamente una nueva contrasena", "Clinica Uca",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            frm.Show();
            this.Hide();
        }
    }
}
