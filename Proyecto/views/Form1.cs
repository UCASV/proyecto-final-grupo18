using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Proyecto.VacunacionContext;
using Proyecto.Controllers;

namespace Proyecto
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmlogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Silver;
            }

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerGestor controller = new controllerGestor();

            if (controller.login(txtuser, txtpass))
            {
                MessageBox.Show("Bienvenido", "Clinica",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Muestra el formulario correspondiente
                Formciudadano frm = new Formciudadano();
                frm.Show();
                this.Hide();                
            }
            else
            {
                MessageBox.Show("El usuario no existe", "Clinica",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formolvido frm = new Formolvido();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerGestor controller = new controllerGestor();

            if (controller.login(txtuser, txtpass))
            {
                MessageBox.Show("Bienvenido", "Clínica",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Muestra el formulario correspondiente
                Formnuevo frm = new Formnuevo();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("ponga el email y password válidos para crear un usuario", "Clínica",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
