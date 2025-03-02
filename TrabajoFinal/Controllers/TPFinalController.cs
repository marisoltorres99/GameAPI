using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrabajoFinal.Model;

namespace TrabajoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TPFinalController : ControllerBase
    {
        [HttpGet]
        [Route("api/CrearSuperHeroe")]
        public IActionResult CrearSuperHeroe([FromQuery] string nombre, [FromQuery] string tipo)
        {
            ISuperHeroe superheroe = SuperHeroeFactory.CrearSuperHeroe(nombre, tipo);
            return Ok(superheroe);
        }

        [HttpGet]
        [Route("api/VisitarEnfermeria")]
        public IActionResult VisitarEnfermeria([FromQuery] string tipo, [FromQuery] int salud, [FromQuery] int cantidadDeVisitas)
        {
            Enfermeria enfermeria = Enfermeria.Instance;

            tipo = tipo.ToLower();

            if (tipo != "arquero" && tipo != "mago" && tipo != "guerrero")
            {
                return BadRequest("Tipo de héroe no soportado");
            }
            
            if (salud == 5)
            {
                return BadRequest("La salud del superhéroe ya está al máximo");
            }

            if (salud > 5)
            {
                return BadRequest("La salud no puede ser mayor a 5");
            }

            if (cantidadDeVisitas <= 0)
            {
                return BadRequest("La cantidad de visitas debe ser mayor a 0");
            }

            for (int i = 0; i < cantidadDeVisitas; i++)
            {
                if (!enfermeria.CurarSuperHeroe(ref salud))
                {
                    return BadRequest("El Héroe no se puede curar más, límite de visitas alcanzado");
                }
            }

            return Ok($"La salud actual del {tipo} es {salud}");
        }
    }
}
