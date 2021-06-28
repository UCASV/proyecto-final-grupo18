using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
=======
using System.Data;
>>>>>>> FormCita
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.VacunacionContext;//importen el context en sus archivos


namespace Proyecto.Controllers
{
    class controllerCiudadano
    {
            
        public void read(DataGridView datagrid, ComboBox comboBoxEnefermedades, ComboBox comboBoxEmpleo, ComboBox comboBoxDosis)
        {
            List<VacunacionContext.Enfermedade> listaEnfermedades = new List<VacunacionContext.Enfermedade>();//Lista enfermedades

            List<VacunacionContext.Empleo> listaEmpleos = new List<VacunacionContext.Empleo>(); //Lista empleos

            List<VacunacionContext.Dosi> listaDosis = new List<VacunacionContext.Dosi>(); //Lista dosis     
            

            using (var db = new Vacunacion_DBContext())
            {
                //Leer los datos
                var ciudadanos = db.Ciudadanos.OrderBy(c => c.Dui).ToList();

                datagrid.DataSource = ciudadanos;//data view


                //ComboBox Enfermedades (los nombres tienen que ser igual que los campos de la clase)
                listaEnfermedades = (from d in db.Enfermedades select new VacunacionContext.Enfermedade {

                    Id = d.Id,
                    Enfermedades = d.Enfermedades

                }).ToList();

                // ComboBox Empleo (los nombres tienen que ser igual que los campos de la clase)
                listaEmpleos = (from d in db.Empleos
                                select new VacunacionContext.Empleo
                                {
                                    Id = d.Id,
                                    Empleo1 = d.Empleo1

                                }).ToList();

                //ComboBox Dosis (los nombres tienen que ser igual que los campos de la clase)
                listaDosis = (from d in db.Doses
                              select new VacunacionContext.Dosi
                              {
                                   Id = d.Id,
                                   Dosis = d.Dosis
                              }).ToList();




            }

            //ComboBox Enfermedades (los campos tienen que estar identicos a los de arriba de Enfermedaedes)
            comboBoxEnefermedades.DataSource = listaEnfermedades;
            comboBoxEnefermedades.ValueMember = "Id";
            comboBoxEnefermedades.DisplayMember = "Enfermedades";

            //ComboBox Empleos (los campos tienen que estar identicos a los de arriba de Empleos)
            comboBoxEmpleo.DataSource = listaEmpleos;
            comboBoxEmpleo.ValueMember = "Id";
            comboBoxEmpleo.DisplayMember = "Empleo1";

            //ComboBox Empleos (los campos tienen que estar identicos a los de arriba de Empleos)
            comboBoxDosis.DataSource = listaDosis;
            comboBoxDosis.ValueMember = "Id";
            comboBoxDosis.DisplayMember = "Dosis";
        }

        public void insert (TextBox txtDui, TextBox txtNombre, TextBox txtDireccion, TextBox txtEmail, TextBox txtTelefono, ComboBox comboBoxEnefermedades, ComboBox comboBoxEmpleo, ComboBox comboBoxDosis)
        {
            using (var db = new Vacunacion_DBContext())
            {
                var std = new Ciudadano()
                {
                    Dui = Convert.ToInt32(txtDui.Text),
                    Nombre = txtNombre.Text,
                    DireccionCasa = txtDireccion.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    IdEnfermedades = (int)comboBoxEnefermedades.SelectedValue,
                    IdEmpleo = (int)comboBoxEmpleo.SelectedValue,
                    IdDosis = (int)comboBoxDosis.SelectedValue

                };

                db.Ciudadanos.Add(std);
                db.SaveChanges();

            }
           
        }
    }
}
