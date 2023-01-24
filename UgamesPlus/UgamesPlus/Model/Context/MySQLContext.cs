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


    }
}
