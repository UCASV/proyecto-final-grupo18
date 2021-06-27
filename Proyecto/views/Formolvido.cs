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
using Microsoft.EntityFrameworkCore;

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

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new Vacunacion_DBContext();
            var listGestor = db.Gestors
                .Include(g => g.IdPreguntaNavigation)
                .ToList();
            var Result = listGestor.Where(u =>
                u.CorreoInstitucional.Equals((txtCorreo.Text))).ToList();
            bool found = Result.Count() > 0;
            Pregunta sq = Result[0].IdPreguntaNavigation;

            if (found)
            {
                lblQuestion.Text = sq.Pregunta1;
                MessageBox.Show("Usuario encontrado, ahora ingresa la respuesta a tu pregunta de seguridad", "Clinic",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
