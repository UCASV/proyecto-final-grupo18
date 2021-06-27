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
    class controllerCita
    {
        public void read(DataGridView dgvcabina, ComboBox CboxDosis)
        {
            List<VacunacionContext.Dosi> listaDosis = new List<VacunacionContext.Dosi>(); //Lista de dosis

            using (var db = new Vacunacion_DBContext())
            {
                //Leer datos
                var Cita = db.Cita.OrderBy(c => c.Id).ToList();

                dgvcabina.DataSource = Cita; //para el dataview


                listaDosis = (from de in db.Doses
                              select new VacunacionContext.Dosi
                              {
                                  Id = de.Id,
                                  Dosis = de.Dosis

                              }).ToList();

            }
            //ComboBox Dosis
            CboxDosis.DataSource = listaDosis;
            CboxDosis.ValueMember = "Id";
            CboxDosis.DisplayMember = "Dosis";
        }
        public void insert(TextBox txtLugar, DateTimePicker DTPfecha, DateTimePicker DTPhora, ComboBox CboxDosis)
        {
            using (var db = new Vacunacion_DBContext())
            {
                var STD = new Citum()
                {
                    Lugar = txtLugar.Text,
                    Fecha = DTPfecha.Value,
                    Hora = DTPhora.Value,
                    IdDosis = (int)CboxDosis.SelectedValue
                };
                db.Cita.Add(STD);
                db.SaveChanges();
            }
        }
    }
}
