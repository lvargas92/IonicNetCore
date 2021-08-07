using System;
using System.Collections.Generic;
using System.Linq;
using IonicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IonicAPI.Services
{
    public class NoticiaService
    {
        private readonly NoticiaDBContext _noticiaDBContext;
        public NoticiaService(NoticiaDBContext noticiaDB)
        {
            _noticiaDBContext = noticiaDB;
        }

        public bool AgregarNoticia(Noticia noticia)
        {
            try
            {
                _noticiaDBContext.Noticias.Add(noticia);
                _noticiaDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Noticia> Obtener()
        {
            var resultado = _noticiaDBContext.Noticias.Include(x => x.Autor).ToList();
            return resultado;
        }

        public bool EditarNoticias(Noticia noticia)
        {
            try
            {
                var noticiaDb = _noticiaDBContext.Noticias.FirstOrDefault(x => x.NoticiaID == noticia.NoticiaID);
                noticiaDb.Titulo = noticia.Titulo;
                noticiaDb.Descripcion = noticia.Descripcion;
                noticiaDb.Contenido = noticia.Contenido;
                noticiaDb.Fecha = noticia.Fecha;
                noticiaDb.AutorID = noticia.AutorID;
                _noticiaDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarNoticias(int id)
        {
            try
            {
                var noticiaDb = _noticiaDBContext.Noticias.FirstOrDefault(x => x.NoticiaID == id);
                _noticiaDBContext.Noticias.Remove(noticiaDb);
                _noticiaDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
