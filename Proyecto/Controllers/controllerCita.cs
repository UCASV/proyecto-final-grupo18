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
        public void read(DataGridView dgvcabina, ComboBox CboxDosis, ComboBox CboxDUI)
        {
            List<VacunacionContext.Dosi> listaDosis = new List<VacunacionContext.Dosi>(); //Lista de dosis
            List<VacunacionContext.Ciudadano> listaDUI = new List<VacunacionContext.Ciudadano>();
            

            using (var db = new Vacunacion_DBContext())
            {
                //Leer datos
                var Cita = db.Cita.OrderBy(c => c.Id).ToList();

                dgvcabina.DataSource = Cita; //para el dataview


                listaDosis = (from d in db.Doses
                              select new VacunacionContext.Dosi
                              {
                                  Id = d.Id,
                                  Dosis = d.Dosis

                              }).ToList();

                listaDUI = (from d in db.Ciudadanos
                            select new VacunacionContext.Ciudadano
                            {
                                Dui = d.Dui
                            }).ToList();

            }
            //ComboBox Dosis
            CboxDosis.DataSource = listaDosis;
            CboxDosis.ValueMember = "Id";
            CboxDosis.DisplayMember = "Dosis";

            CboxDUI.DataSource = listaDUI;
            CboxDUI.ValueMember = "DUI";
            CboxDUI.DataSource = "DUI";
        }
        public void insert(TextBox txtID, TextBox txtLugar, DateTimePicker DTPfecha, DateTimePicker DTPhora, ComboBox CboxDosis, ComboBox CboxDUI)
        {
            using (var db = new Vacunacion_DBContext())
            {
                var STD = new Citum()
                {
                    Id = Convert.ToInt32(txtID.Text),
                    Lugar = txtLugar.Text,
                    Fecha = DTPfecha.Value,
                    Hora = DTPhora.Value,
                    IdDosis = (int)CboxDosis.SelectedValue,
                    DuiCiudadano = (int)CboxDUI.SelectedIndex
                    
                };
                db.Cita.Add(STD);
                db.SaveChanges();
            }
        }
    }
}
