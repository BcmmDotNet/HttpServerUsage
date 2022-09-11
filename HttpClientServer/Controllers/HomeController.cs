using Microsoft.AspNetCore.Mvc;

namespace HttpClientServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "This is home controller.";
        }
    }
}
