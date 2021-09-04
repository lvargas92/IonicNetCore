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
    public class AutorController : Controller
    {
        private readonly AutorService _autorService;
        public AutorController(AutorService autorService)
        {
            _autorService = autorService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_autorService.ListaAutores());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost]
        [Route("agregar")]
        public IActionResult Agregar([FromBody] Autor autor)
        {
            var resultado = _autorService.AgregarAutor(autor);
            return Ok(resultado);
        }

        [HttpPut]
        [Route("editar")]
        public IActionResult Editar([FromBody] Autor autor)
        {
            var resultado = _autorService.EditarAutor(autor);
            return Ok(resultado);
        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public IActionResult Eliminar(int id)
        {
            var resultado = _autorService.EliminarAutor(id);
            return Ok(resultado);
        }
    }
}
