using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IonicAPI.Models
{
    public class Autor
    {
        public int AutorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Autor> builder)
            {
                builder.HasKey(x => x.AutorID);
                builder.Property(x => x.Nombre).HasColumnName("Nombre");
                builder.ToTable("Autor");
            }
        }
    }
}
