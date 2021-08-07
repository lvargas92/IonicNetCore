using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IonicAPI.Models;
using IonicAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IonicAPI.Controllers
{
    [Route("api/[controller]")]
    public class NoticiaController : Controller
    {
        private readonly NoticiaService _noticiaSercie;

        public NoticiaController(NoticiaService noticiaService)
        {
            _noticiaSercie = noticiaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_noticiaSercie.Obtener());
        }

        [HttpPost]
        [Route("agregar")]
        public IActionResult Agregar([FromBody] Noticia noticia)
        {
            var resultado = _noticiaSercie.AgregarNoticia(noticia);
            return Ok(resultado);
        }

        [HttpPut]
        [Route("editar")]
        public IActionResult Editar([FromBody] Noticia noticia)
        {
            var resultado = _noticiaSercie.EditarNoticias(noticia);
            return Ok(resultado);
        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public IActionResult Eliminar(int id)
        {
            var resultado = _noticiaSercie.EliminarNoticias(id);
            return Ok(resultado);
        }

    }
}
