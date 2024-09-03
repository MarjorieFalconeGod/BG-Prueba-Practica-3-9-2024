using BG_Marjorie_Falcone_Godoy_392024.Models;
using BG_Marjorie_Falcone_Godoy_392024.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;

namespace BG_Marjorie_Falcone_Godoy_392024.Controllers
{
    public class UserController : Controller
    {

        //private const object StringHandler;
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = UserService;
        }

        //[Route(StringHandler.PATH_APLICACIONES)]
        public IActionResult AgeAplicaciones()
        {
            return View("~/Views/User/AdminParametros/AgeAplicaciones.cshtml");
        }

        [HttpGet]
            public async Task<IResult> ConsultarTodos()
            {
                return await _userService.ConsultarTodos();
            }

            [HttpPut]

            public async Task<IResult> Actualizar(
           [FromBody] User user)
            {
                return await _userService.Actualizar(user);
            }

            [HttpGet]
            public async Task<IResult> Ver(
           [FromQuery] int codigo)
            {
                return await _userService.ver(codigo);
            }

            [HttpPost]
            public async Task<IResult> Registrar(
                [FromBody] User user)
            {
                return await _userService.Registrar(user);
            }
        }
    }

    