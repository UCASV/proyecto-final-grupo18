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

            List<VacunacionContext.Enfermedade> listaEnfermedades = new List<VacunacionContext.Enfermedade>();//Lista enfermedades

            List<VacunacionContext.Empleo> listaEmpleos = new List<VacunacionContext.Empleo>(); //Lista empleos

            List<VacunacionContext.Dosi> listaDosis = new List<VacunacionContext.Dosi>(); //Lista dosis     
            

            using (var db = new Vacunacion_DBContext())
            {
                //Leer los datos
                var ciudadanos = db.Ciudadanos.OrderBy(c => c.Dui).ToList();

                dgvcabina.DataSource = ciudadanos;//data view


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

        private void btnguardar_Click(object sender, EventArgs e)
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
                    IdEnfermedades = (int) comboBoxEnefermedades.SelectedValue,
                    IdEmpleo = (int) comboBoxEmpleo.SelectedValue,
                    IdDosis = (int) comboBoxDosis.SelectedValue                    
                    
                };

                db.Ciudadanos.Add(std);
                db.SaveChanges();

            }
          

                    
        }
    }
}
