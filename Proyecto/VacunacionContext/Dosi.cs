using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Dosi
    {
        public Dosi()
        {
            Cita = new HashSet<Citum>();
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int Id { get; set; }
        public string Dosis { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}
