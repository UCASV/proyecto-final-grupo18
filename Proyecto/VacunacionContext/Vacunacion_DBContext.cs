using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto.VacunacionContext
{
    public partial class Vacunacion_DBContext : DbContext
    {
        public Vacunacion_DBContext()
        {
        }

        public Vacunacion_DBContext(DbContextOptions<Vacunacion_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<CabinaXciudadano> CabinaXciudadanos { get; set; }
        public virtual DbSet<CitaXcabina> CitaXcabinas { get; set; }
        public virtual DbSet<Citum> Cita { get; set; }
        public virtual DbSet<Ciudadano> Ciudadanos { get; set; }
        public virtual DbSet<Dosi> Doses { get; set; }
        public virtual DbSet<Empleo> Empleos { get; set; }
        public virtual DbSet<Enfermedade> Enfermedades { get; set; }
        public virtual DbSet<Gestor> Gestors { get; set; }
        public virtual DbSet<Pregunta> Preguntas { get; set; }
        public virtual DbSet<Registro> Registros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-1UA3FIU\\SQLEXPRESS; database=Vacunacion_DB; integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.ToTable("Cabina");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ubicacion");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Cabinas)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cabina__id_gesto__3A81B327");
            });

            modelBuilder.Entity<CabinaXciudadano>(entity =>
            {
                entity.ToTable("CabinaXCiudadano");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiCiudadano).HasColumnName("Dui_ciudadano");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.CabinaXciudadanos)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CabinaXCi__Dui_c__4222D4EF");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.CabinaXciudadanos)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CabinaXCi__id_ca__412EB0B6");
            });

            modelBuilder.Entity<CitaXcabina>(entity =>
            {
                entity.ToTable("CitaXCabina");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.CitaXcabinas)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CitaXCabi__id_ca__3E52440B");

                entity.HasOne(d => d.IdCitaNavigation)
                    .WithMany(p => p.CitaXcabinas)
                    .HasForeignKey(d => d.IdCita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CitaXCabi__id_ci__3D5E1FD2");
            });

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiCiudadano).HasColumnName("DUI_ciudadano");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hora");

                entity.Property(e => e.IdDosis).HasColumnName("id_dosis");

                entity.Property(e => e.Lugar)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("lugar");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cita__DUI_ciudad__300424B4");

                entity.HasOne(d => d.IdDosisNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdDosis)
                    .HasConstraintName("FK__Cita__id_dosis__2F10007B");
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__Ciudadan__C03671B83EB64BC0");

                entity.ToTable("Ciudadano");

                entity.Property(e => e.Dui)
                    .ValueGeneratedNever()
                    .HasColumnName("DUI");

                entity.Property(e => e.DireccionCasa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion_casa")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdDosis).HasColumnName("id_dosis");

                entity.Property(e => e.IdEmpleo).HasColumnName("id_empleo");

                entity.Property(e => e.IdEnfermedades).HasColumnName("id_enfermedades");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdDosisNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdDosis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ciudadano__id_do__2C3393D0");

                entity.HasOne(d => d.IdEmpleoNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdEmpleo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ciudadano__id_em__2B3F6F97");

                entity.HasOne(d => d.IdEnfermedadesNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdEnfermedades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ciudadano__id_en__2A4B4B5E");
            });

            modelBuilder.Entity<Dosi>(entity =>
            {
                entity.ToTable("Dosis");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Dosis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dosis");
            });

            modelBuilder.Entity<Empleo>(entity =>
            {
                entity.ToTable("Empleo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Empleo1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Empleo");
            });

            modelBuilder.Entity<Enfermedade>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Enfermedades)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gestor>(entity =>
            {
                entity.ToTable("Gestor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.CorreoInstitucional)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_institucional")
                    .IsFixedLength(true);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdPregunta).HasColumnName("id_pregunta");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Respuesta)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("respuesta");

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.Gestors)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Gestor__id_pregu__34C8D9D1");
            });

            modelBuilder.Entity<Pregunta>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Pregunta1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pregunta");
            });

            modelBuilder.Entity<Registro>(entity =>
            {
                entity.ToTable("Registro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fechayhora).HasColumnType("datetime");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Registros)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registro__id_ges__37A5467C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
