using Microsoft.AspNetCore.Mvc;

namespace CRUD_BACK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok(new
            {
                mensaje = "Endpoint funcionando correctamente 🚀"
            });
        }
    }
}