using equiposWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace equiposWebApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        //Mi primer controlador
        //Configurar mi variable de conexion al contexto db
        private readonly prestamosContext _contexto;

        public equiposController(prestamosContext miContexto)
        {
            _contexto = miContexto;
        }
        
        [HttpGet]
        [Route("api/equipos/{idUsuarios}")]
        public IActionResult Get(int idUsuario)
        {
            IEnumerable<equipos> equiposList = (from e in _contexto.equipos
                                                where e.id_equipos == idUsuario
                                                select e
                                                );

            IEnumerable<equipos> equiposListado = _contexto.equipos;

            if(equiposList.Count()>0)
            {
                return Ok(equiposList);
            }
            return NotFound();
        }

    }
}
