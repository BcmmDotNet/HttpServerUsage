using Microsoft.AspNetCore.Mvc;

namespace HttpClientServer.Controllers
{
    public class Info
    {
        public string? Name { get; set; }
        public string? Birth { get; set; }
        public int Age { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class InfoController : Controller
    {
        [HttpGet]
        public Info Index(Info info)
        {
            return info;
        }
    }
}
