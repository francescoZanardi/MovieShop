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
        public DbSet<Attore> Attore { get; set; }
        public DbSet<FilmAttore> FilmAttore { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Attore>(e => 
        //    {
        //        e.HasMany(x => x.FilmAttores)
        //            .WithOne(x => x.Attore)
        //            .HasForeignKey(x => x.AttoreId)
        //            .HasForeignKey("FK_FilmAttori_Attori");
        //    });

        //    modelBuilder.Entity<Film>(e =>
        //    {
        //        e.HasOne(x => x.Attore)
        //            .WithOne(x => x.FilmAttores)
        //    });
        //}
    }
}
