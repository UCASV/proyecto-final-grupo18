using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class CabinaXciudadano
    {
        public int Id { get; set; }
        public int IdCabina { get; set; }
        public int DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual Cabina IdCabinaNavigation { get; set; }
    }
}
