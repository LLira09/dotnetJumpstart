using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // If we wanted to have a view we would just have Controller
    // Since this is just an API we use ControllerBase
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}