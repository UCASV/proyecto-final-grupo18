using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Proyecto.VacunacionContext;

namespace Proyecto.Controllers
{
    class controllerCabina
    {
        public void read(DataGridView dgvcabina, ComboBox cbgestor)
        {
            List<VacunacionContext.Gestor> listaGestores = new List<VacunacionContext.Gestor>();


            using (var db = new Vacunacion_DBContext())
            {
                var cabinas = db.Cabinas.OrderBy(c => c.Id).ToList();

                dgvcabina.DataSource = cabinas;

                listaGestores = (from d in db.Gestors
                                select new VacunacionContext.Gestor
                                {
                                    Id = d.Id,
                                    Nombre = d.Nombre


                                }).ToList();
                 
            }

            //ComboBox Enfermedades (los campos tienen que estar identicos a los de arriba de gestores)
            cbgestor.DataSource = listaGestores;
            cbgestor.ValueMember = "Id";
            cbgestor.DisplayMember = "Nombre";

        }

         public void insert(TextBox txtUbicacion, ComboBox cmbGestor, TextBox txtEmail, TextBox txtTelefono)
        {
            using (var db = new Vacunacion_DBContext())
            {
                var std = new Cabina()
                {

                    Ubicacion = txtUbicacion.Text,
                    IdGestor = (int)cmbGestor.SelectedValue,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text

                };

                db.Cabinas.Add(std);
                db.SaveChanges();

            }

        }
    }

}
