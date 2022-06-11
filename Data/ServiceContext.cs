using CrudUsuario.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudUsuario.Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var usuario = modelBuilder.Entity<Usuario>();

            usuario.ToTable("Usuarios");
            usuario.HasKey(x => x.Id).HasName("PK_USUARIOS_4544DWF");
            usuario.Property(x => x.Identificacion).HasColumnType("numeric(18,0)").IsRequired();
            usuario.Property(x => x.Nombre).HasColumnType("varchar(60)").IsRequired();
            usuario.Property(x => x.Apellido).HasColumnType("varchar(60)").IsRequired();
            usuario.Property(x => x.Edad).HasColumnType("numeric(2,0)").IsRequired();
            usuario.Property(x => x.NumeroTelefono).HasColumnType("numeric(18,0)").IsRequired();
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
