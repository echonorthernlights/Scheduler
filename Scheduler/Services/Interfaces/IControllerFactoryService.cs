using Scheduler.Controllers;

namespace Scheduler.Services.Interfaces
{
    public interface IControllerFactoryService
    {
        HomeController CreateController();
    }
}
