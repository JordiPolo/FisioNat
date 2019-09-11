using Raist.Models;
using Microsoft.EntityFrameworkCore;

namespace Raist.Data
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options){}
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alergeno> Alergenos { get; set; }
        public DbSet<Especialista> Especialistas { get; set; }
        public DbSet<Imagen> Imagenes {get; set;}

        public DbSet<Registro> registros {get; set;}
        public DbSet<TratamientoCita> tratamientoCitas{get; set;}
        public DbSet<TratamientoFarmacologico> tratamientosFarmacologicos {get; set;}
        public DbSet<Clinica> clinicas {get; set;}
        public DbSet<PacienteDeClinica> pacientesDeClinicas {get; set;}

        public DbSet<Paciente> Pacientes {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registro>()
                .HasKey(c => new { c.usuario, c.password,c.passwordHuella });

            modelBuilder.Entity<PacienteDeClinica>()
                .HasKey(a => new { a.clinica, a.paciente});

            modelBuilder.Entity<PacienteDeClinica>()
                .HasOne(pt => pt.clinica)
                .WithMany(p => p.pacienteDeClinicas)
                .HasForeignKey(pt => pt.clinica);

            modelBuilder.Entity<PacienteDeClinica>()
                .HasOne(pt => pt.paciente)
                .WithMany(p => p.pacienteDeClinicas)
                .HasForeignKey(pt => pt.paciente);
        }
    }
}
