using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Registro
    {
        public int Id { get; set; }
        public DateTime? Fechayhora { get; set; }
        public int IdGestor { get; set; }

        public virtual Gestor IdGestorNavigation { get; set; }
    }
}
