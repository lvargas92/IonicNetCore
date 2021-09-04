using System;
using System.Collections.Generic;
using System.Linq;
using IonicAPI.Models;

namespace IonicAPI.Services
{
    public class AutorService
    {
        private readonly NoticiaDBContext _noticiaDBContext;
        
        public AutorService(NoticiaDBContext noticiaDB)
        {
            _noticiaDBContext = noticiaDB;
        }

        public List<Autor> ListaAutores()
        {
            try
            {
                var autores = _noticiaDBContext.Autors.ToList();
                return autores;
            }
            catch (Exception ex)
            {
                return new List<Autor>();
            }
        }

        internal object AgregarAutor(Autor autor)
        {
            try
            {
                _noticiaDBContext.Autors.Add(autor);
                _noticiaDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditarAutor(Autor autor)
        {
            try
            {
                var autorDb = _noticiaDBContext.Autors.FirstOrDefault(x => x.AutorID == autor.AutorID);
                autorDb.Apellido = autor.Apellido;                
                autorDb.Nombre = autor.Nombre;                
                _noticiaDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarAutor(int id)
        {
            try
            {
                var autorDB = _noticiaDBContext.Autors.FirstOrDefault(x => x.AutorID == id);
                _noticiaDBContext.Autors.Remove(autorDB);
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
