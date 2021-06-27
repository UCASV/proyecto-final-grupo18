using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Empleo
    {
        public Empleo()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int Id { get; set; }
        public string Empleo1 { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}
