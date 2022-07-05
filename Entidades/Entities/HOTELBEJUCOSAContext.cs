using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entidades.Entities
{
    public partial class HOTELBEJUCOSAContext : DbContext
    {
        public HOTELBEJUCOSAContext()
        {
        }

        public HOTELBEJUCOSAContext(DbContextOptions<HOTELBEJUCOSAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SSEQUIERA_HIO03; Database=HOTELBEJUCOSA; Persist Security info=true; user id=admin; password=masterkey;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CedulaCliente)
                    .HasName("PK__CLIENTE__CADDEA55C786657C");

                entity.ToTable("CLIENTE");

                entity.Property(e => e.CedulaCliente)
                    .HasColumnName("cedula_cliente")
                    .HasMaxLength(20);

                entity.Property(e => e.Apellido1Cliente)
                    .IsRequired()
                    .HasColumnName("apellido1_cliente")
                    .HasMaxLength(50);

                entity.Property(e => e.Apellido2Cliente)
                    .IsRequired()
                    .HasColumnName("apellido2_cliente")
                    .HasMaxLength(50);

                entity.Property(e => e.CorreoCliente)
                    .IsRequired()
                    .HasColumnName("correo_cliente")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasColumnName("nombre_cliente")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoCliente)
                    .IsRequired()
                    .HasColumnName("telefono_cliente")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Habitacion>(entity =>
            {
                entity.HasKey(e => e.CodHabitacion)
                    .HasName("PK__HABITACI__B65FA5AB2BB01179");

                entity.ToTable("HABITACION");

                entity.Property(e => e.CodHabitacion)
                    .HasColumnName("cod_habitacion")
                    .ValueGeneratedNever();

                entity.Property(e => e.CapacidadHabitacion).HasColumnName("capacidad_habitacion");

                entity.Property(e => e.EstadoHabitacion)
                    .IsRequired()
                    .HasColumnName("estado_habitacion")
                    .HasMaxLength(30);

                entity.Property(e => e.TipoHabitacion)
                    .IsRequired()
                    .HasColumnName("tipo_habitacion")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__RESERVA__423CBE5DAEB2F1E1");

                entity.ToTable("RESERVA");

                entity.Property(e => e.IdReserva)
                    .HasColumnName("id_reserva")
                    .ValueGeneratedNever();

                entity.Property(e => e.CantidadAdultos).HasColumnName("cantidad_adultos");

                entity.Property(e => e.CantidadNinos).HasColumnName("cantidad_ninos");

                entity.Property(e => e.CedulaCliente)
                    .IsRequired()
                    .HasColumnName("cedula_cliente")
                    .HasMaxLength(20);

                entity.Property(e => e.CodHabitacion).HasColumnName("cod_habitacion");

                entity.Property(e => e.CodReserva)
                    .IsRequired()
                    .HasColumnName("cod_reserva")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaEntrada)
                    .HasColumnName("fecha_entrada")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSalida)
                    .HasColumnName("fecha_salida")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrecioHabitacion)
                    .HasColumnName("precio_habitacion")
                    .HasColumnType("smallmoney");

                entity.HasOne(d => d.CedulaClienteNavigation)
                    .WithMany(p => p.Reserva)
                    .HasForeignKey(d => d.CedulaCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cedula_cliente_cliente_reserva");

                entity.HasOne(d => d.CodHabitacionNavigation)
                    .WithMany(p => p.Reserva)
                    .HasForeignKey(d => d.CodHabitacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cod_habitacion_habitacion_reserva");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
