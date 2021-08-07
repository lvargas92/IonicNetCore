using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IonicAPI.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public int AutorID { get; set; }
        public Autor Autor { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Noticia> builder)
            {
                builder.HasKey(x => x.NoticiaID);
                builder.Property(x => x.Titulo).HasColumnName("Titulo");
                builder.ToTable("Noticia");
                builder.HasOne(x => x.Autor);
            }
        }
    }
}
