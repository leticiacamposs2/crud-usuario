using crud_usuario.Model;
using Microsoft.AspNetCore.Mvc;

namespace crud_usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> Usuarios()
        {
            return new List<Usuario>{
                new Usuario{ Id = 1, Nome = "Leticia", DataNascimento = new DateTime(1994, 09, 22) }
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios());
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.Add(usuario);
            return Ok(usuarios);
        }

    }
}