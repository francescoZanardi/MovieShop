using Microsoft.EntityFrameworkCore;
using Negozio.DataAccess.DbModel;
using System;

namespace NegozioDataAccess
{
    public class NegozioContext : DbContext 
    {
        public NegozioContext(DbContextOptions<NegozioContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet <Film> Films { get; set; }
        public DbSet<Negozioo> Negozios  { get; set; }
        public DbSet<FilmAutore> FilmAutores { get; set; }
        public DbSet<Regista> Registas { get; set; }
    }
}
