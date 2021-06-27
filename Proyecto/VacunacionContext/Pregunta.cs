using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Pregunta
    {
        public Pregunta()
        {
            Gestors = new HashSet<Gestor>();
        }

        public int Id { get; set; }
        public string Pregunta1 { get; set; }

        public virtual ICollection<Gestor> Gestors { get; set; }
    }
}
