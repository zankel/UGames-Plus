using Microsoft.EntityFrameworkCore;
using System;

namespace RestWithASPNETUdemy.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
