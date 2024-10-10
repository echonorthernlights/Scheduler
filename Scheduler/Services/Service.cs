using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Scheduler.Services.Interfaces;

namespace Scheduler.Services
{
    public class Service : IService
    {
        public string GetMessage()
        {
            return "Hello";
        }
    }
}
