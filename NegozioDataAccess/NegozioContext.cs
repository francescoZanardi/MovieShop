using Microsoft.EntityFrameworkCore;
using Negozio.DataAccess.DbModel;
using System;

namespace NegozioDataAccess
{
    public class NegozioContext : DbContext 
    {
        public NegozioContext(DbContextOptions<NegozioContext> options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet <Film> Film { get; set; }
        public DbSet<Negozioo> Negozioo  { get; set; }
        public DbSet<FilmRegista> FilmRegista { get; set; }
        public DbSet<Regista> Regista { get; set; }
    }
}
