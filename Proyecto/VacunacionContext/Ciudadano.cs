using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Ciudadano
    {
        public Ciudadano()
        {
            CabinaXciudadanos = new HashSet<CabinaXciudadano>();
            Cita = new HashSet<Citum>();
        }

        public int Dui { get; set; }
        public string Nombre { get; set; }
        public string DireccionCasa { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int IdEnfermedades { get; set; }
        public int IdEmpleo { get; set; }
        public int IdDosis { get; set; }

        public virtual Dosi IdDosisNavigation { get; set; }
        public virtual Empleo IdEmpleoNavigation { get; set; }
        public virtual Enfermedade IdEnfermedadesNavigation { get; set; }
        public virtual ICollection<CabinaXciudadano> CabinaXciudadanos { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
    }
}
