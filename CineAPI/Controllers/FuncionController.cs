using CineBack.Entidades;
using CineBack.Fachada.Implementacion;
using CineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionController : ControllerBase
    {
        private IAplicacion app;
        public FuncionController()
        {
            app = new Aplicacion();
        }

        [HttpPost("/Pelicula")]
        public IActionResult PostPelicula(Funcion oFuncion)
        {
            try
            {
                if (oFuncion == null)
                    return BadRequest("Funcion Invalida!!!");
                if (app.SaveFuncion(oFuncion))
                    return Ok(oFuncion);
                else
                    return NotFound("No se pudo guardar la funcion");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!! Intente mas tarde...");
            }
        }
    }
}
