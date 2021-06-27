using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Cabina
    {
        public Cabina()
        {
            CabinaXciudadanos = new HashSet<CabinaXciudadano>();
            CitaXcabinas = new HashSet<CitaXcabina>();
        }

        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public int IdGestor { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public virtual Gestor IdGestorNavigation { get; set; }
        public virtual ICollection<CabinaXciudadano> CabinaXciudadanos { get; set; }
        public virtual ICollection<CitaXcabina> CitaXcabinas { get; set; }
    }
}
