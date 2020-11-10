using System;
using ApiPatrimonioEmpresa.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiPatrimonioEmpresa.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
