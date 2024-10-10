using Scheduler.Controllers;
using Scheduler.Services.Interfaces;

namespace Scheduler.Services
{
    public class ControllerFactoryService : IControllerFactoryService
    {
        private readonly IService _service;
        public ControllerFactoryService(IService service)
        {
            _service = service;
        }
        public HomeController CreateController()
        {
            return new HomeController(_service);
        }
    }
}
