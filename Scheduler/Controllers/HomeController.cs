using Microsoft.AspNetCore.Mvc;
using Scheduler.Services.Interfaces;

namespace Scheduler.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    
    public class HomeController : ControllerBase
    {
        private readonly IService _service;
        public HomeController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetHello()
        {
            Console.WriteLine("FROM CONTROLLER");
            return Ok(_service.GetMessage());
        }
    }
}
