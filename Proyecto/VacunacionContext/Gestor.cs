using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Gestor
    {
        public Gestor()
        {
            Cabinas = new HashSet<Cabina>();
            Registros = new HashSet<Registro>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Direccion { get; set; }
        public int IdPregunta { get; set; }
        public string Respuesta { get; set; }

        public virtual Pregunta IdPreguntaNavigation { get; set; }
        public virtual ICollection<Cabina> Cabinas { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
