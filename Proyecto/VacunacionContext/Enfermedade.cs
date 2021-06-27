using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Enfermedade
    {
        public Enfermedade()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int Id { get; set; }
        public string Enfermedades { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}
