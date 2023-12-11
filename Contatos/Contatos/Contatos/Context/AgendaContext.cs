using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Context
{
    public class AgendaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=contatos;user=root;password=0f8jsiz6ik5y",
                new MySqlServerVersion("10.4.28-MariaDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired();
            });
            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired();
                entity.Property(e => e.Telefone).IsRequired();
                entity.Property(e => e.Email).IsRequired();
            });



        }
    }
}
 