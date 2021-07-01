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
            CboxDUI.DisplayMember = "DUI";
        }
        public void insert(TextBox txtLugar, DateTimePicker DTPfecha, DateTimePicker DTPhora, ComboBox CboxDosis, ComboBox CboxDUI)
        {           
            using (var db = new Vacunacion_DBContext())
            {
                var STD = new Citum()
                {                    
                    Lugar = txtLugar.Text,
                    Fecha = DTPfecha.Value,
                    Hora = DTPhora.Value.ToString("T"),
                    IdDosis = (int)CboxDosis.SelectedValue,
                    DuiCiudadano = (int)CboxDUI.SelectedValue                  

                };
                db.Cita.Add(STD);
                db.SaveChanges();
            }           
        }

        public void update(TextBox txtId, TextBox txtLugar, DateTimePicker DTPfecha, DateTimePicker DTPhora, ComboBox CboxDosis, ComboBox CboxDUI)
        {
            int id = int.Parse(txtId.Text);
            using (var db = new Vacunacion_DBContext())
            {
                var std = db.Cita.First(i => i.Id == id);
                std.Lugar = txtLugar.Text;
                std.Fecha = DTPfecha.Value;
                std.Hora = DTPhora.Value.ToString("T");
                std.IdDosis = (int) CboxDosis.SelectedValue;
                std.DuiCiudadano = (int) CboxDUI.SelectedValue;

                db.SaveChanges();
              
            }
        }

        public void delete(TextBox txtId)
        {
            int id = int.Parse(txtId.Text);

            using (var db = new Vacunacion_DBContext())
            {
                var std = db.Cita.Single(i=> i.Id == id);

                db.Remove(std);
                db.SaveChanges();
            }

        }


    }
}
