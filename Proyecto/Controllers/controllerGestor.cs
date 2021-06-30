using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Proyecto.VacunacionContext;//importen el context en sus archivos

namespace Proyecto.Controllers
{
    class controllerGestor
    {
        public void read(DataGridView dgvGestor, ComboBox cmbPregunta)
        {
            List<VacunacionContext.Pregunta> listaPreguntas = new List<VacunacionContext.Pregunta>();//Lista enfermedades
    


            using (var db = new Vacunacion_DBContext())
            {
                //Leer los datos
                var gestors = db.Gestors.OrderBy(c => c.Id).ToList();

                dgvGestor.DataSource = gestors;//data view


                //ComboBox Enfermedades (los nombres tienen que ser igual que los campos de la clase)
                listaPreguntas = (from d in db.Preguntas
                                     select new VacunacionContext.Pregunta
                                     {

                                         Id = d.Id,
                                         Pregunta1 = d.Pregunta1

                                     }).ToList();


            }

            //ComboBox Enfermedades (los campos tienen que estar identicos a los de arriba de Enfermedaedes)
            cmbPregunta.DataSource = listaPreguntas;
            cmbPregunta.ValueMember = "Id";
            cmbPregunta.DisplayMember = "Pregunta1";

        }
        public void read2( ComboBox cmbPregunta)
        {
            List<VacunacionContext.Pregunta> listaPreguntas = new List<VacunacionContext.Pregunta>();//Lista enfermedades



            using (var db = new Vacunacion_DBContext())
            {
 
                //ComboBox Enfermedades (los nombres tienen que ser igual que los campos de la clase)
                listaPreguntas = (from d in db.Preguntas
                                  select new VacunacionContext.Pregunta
                                  {

                                      Id = d.Id,
                                      Pregunta1 = d.Pregunta1

                                  }).ToList();


            }

            //ComboBox Enfermedades (los campos tienen que estar identicos a los de arriba de Enfermedaedes)
            cmbPregunta.DataSource = listaPreguntas;
            cmbPregunta.ValueMember = "Id";
            cmbPregunta.DisplayMember = "Pregunta1";

        }


        public void insert(TextBox txtNombre, TextBox txtCorreo, TextBox txtDireccion, TextBox txtContra, ComboBox cmbPregunta, TextBox txtRespuesta)
        {
            using (var db = new Vacunacion_DBContext())
            {
                var std = new Gestor()
                {

                    Nombre = txtNombre.Text,
                    CorreoInstitucional = txtCorreo.Text,
                    Direccion = txtDireccion.Text,
                    Contrasena = txtContra.Text,
                    IdPregunta = (int)cmbPregunta.SelectedValue,
                    Respuesta = txtRespuesta.Text
                };

                db.Gestors.Add(std);
                db.SaveChanges();

            }

        }
        public void update(TextBox txtId, TextBox txtNombre,  TextBox txtCorreo, TextBox txtDireccion,TextBox txtContra, ComboBox cmbPregunta, TextBox txtRespuesta)
        {
            int id = int.Parse(txtId.Text);
            using (var db = new Vacunacion_DBContext())
            {
                var std = db.Gestors.First(i => i.Id == id);
                std.Nombre = txtNombre.Text;
                std.Contrasena = txtContra.Text;
                std.CorreoInstitucional = txtCorreo.Text;
                std.Direccion = txtDireccion.Text;
                std.IdPregunta = (int)cmbPregunta.SelectedValue;
                std.Respuesta = txtRespuesta.Text;

                db.SaveChanges();
            }
        }
        public void delete(TextBox txtId)
        {
            int id = int.Parse(txtId.Text);

            using (var db = new Vacunacion_DBContext())
            {
                var std = db.Gestors.Single(i => i.Id == id);

                db.Remove(std);
                db.SaveChanges();
            }

        }
    }
}
