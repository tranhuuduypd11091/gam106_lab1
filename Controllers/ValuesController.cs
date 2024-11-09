using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IActionResult Get()
        {
            lab1 lab1 = new lab1
            {
                CouresName = "Back-end game Frogamming",
                CouresCode = "gam106",
                Name = "TranHuuDuy",
                StudentCode = "PD11091",
                Class = "GA19301",
            };
            int status = 1;
            string message = "get data succes!";
            var data = new {status, message, lab1};
            return new JsonResult(data);

          
        }
    }
}
