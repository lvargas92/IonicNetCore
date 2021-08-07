using System;
using IonicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IonicAPI
{
    public class NoticiaDBContext: DbContext
    {
        public NoticiaDBContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Autor> Autors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new Noticia.Mapeo(modelBuilder.Entity<Noticia>());
            new Autor.Mapeo(modelBuilder.Entity<Autor>());
        }
    }
}
