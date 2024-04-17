using Habitica.interfaces;
using Habitica.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HabiticaController : ControllerBase
    {
        readonly HabiticaServices _service = new();

        [HttpGet("tasks")]
        public List<HabiticaDatum>? GetTasks()
        {

            return this._service.GetTasks().Result;

        }


        [HttpGet("notifications")]
        public List<HabiticaNotification>? GetNotifications()
        {

            return this._service.GetNotifications().Result;

        }
    }
}
