using Microsoft.AspNetCore.Mvc;

namespace SignalR.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "Hello for debug";
        }
    }
}
