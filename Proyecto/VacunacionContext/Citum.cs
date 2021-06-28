using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Citum
    {
        public Citum()
        {
            CitaXcabinas = new HashSet<CitaXcabina>();
        }

        public int Id { get; set; }
        public string Lugar { get; set; }
        public DateTime ? Fecha { get; set; }
        public DateTime ? Hora { get; set; }
        public int? IdDosis { get; set; }
        public int? DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual Dosi IdDosisNavigation { get; set; }
        public virtual ICollection<CitaXcabina> CitaXcabinas { get; set; }

    }
}
