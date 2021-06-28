﻿using System;
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
    }
}
