using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class CitaXcabina
    {
        public int Id { get; set; }
        public int IdCita { get; set; }
        public int IdCabina { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Citum IdCitaNavigation { get; set; }
    }
}
