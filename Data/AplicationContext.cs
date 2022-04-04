using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MonitoriaWebAPI.Data
{
    public class AplicationContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-OKSRU50;Initial Catalog=Monitoriac#;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table => {
                table.ToTable("Clientes");
                table.Property("Nome").HasMaxLength(40);
                table.Property("CPF").HasColumnType("CHAR(11)");
                table.Property("Nascimento").HasColumnType("DATE");

                table.HasKey("Id");
            });
               
        }
    }
}
