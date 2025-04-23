using BuildCreadorUsuarios.Services;
using Microsoft.AspNetCore.Mvc;
using PatronesDeDiseño.Web.ViewModels;

namespace PatronesDeDiseño.Web.Controllers
{
    [ApiController]
    [Route("apiBuildPattern/[controller]")]
    public class BuildUserController : Controller
    {

        [HttpPost]
        [Route("Index")]
        public IActionResult Createuser([FromBody] int Edad, string Nombres, string? Apellidos, string? Rol)
        {
            try
            {
                if (string.IsNullOrEmpty(Apellidos) && string.IsNullOrEmpty(Rol))
                {
                    var creaUser = new BuilderUsuarioService()
                        .WithAge(Edad)
                        .WithNames(Nombres)
                        .WithEstate()
                        .Build();
                    creaUser.CreateUser();
                }
                else if (string.IsNullOrEmpty(Apellidos) && !string.IsNullOrEmpty(Rol))
                {
                    var creaUser = new BuilderUsuarioService()
                    .WithAge(Edad)
                    .WithNames(Nombres)
                    .WithRole(Rol)
                    .WithEstate()
                    .Build();
                    creaUser.CreateUser();
                    return Ok(creaUser);
                }
                else if (string.IsNullOrEmpty(Apellidos))
                {
                    var creaUser = new BuilderUsuarioService()
                        .WithAge(Edad)
                        .WithNames(Nombres)
                        .WithRole(Rol)
                        .WithEstate()
                        .Build();
                    creaUser.CreateUser();
                    return Ok(creaUser);
                }
                else if (string.IsNullOrEmpty(Rol))
                {
                    var creaUser = new BuilderUsuarioService()
                        .WithAge(Edad)
                        .WithNames(Nombres)
                        .WithLastName(Apellidos)
                        .WithEstate()
                        .Build();
                    creaUser.CreateUser();
                    return Ok(creaUser);
                }
                else
                {
                    var creaUser = new BuilderUsuarioService()
                   .WithAge(Edad)
                   .WithNames(Nombres)
                   .WithLastName(Apellidos)
                   .WithRole(Rol)
                   .WithEstate()
                   .Build();
                    creaUser.CreateUser();
                    return Ok(creaUser);
                }
                return Ok("Ingresar data correctamente!!!!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
