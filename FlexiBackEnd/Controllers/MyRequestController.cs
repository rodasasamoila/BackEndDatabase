using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using PersistanceLayer;

namespace FlexiBackEnd.Controllers
{

    [Route("api/{controller}")]
    [ApiController]
    public class MyRequestController : Controller
    {
        private readonly IContainer _container;

        public MyRequestController(IContainer container)
        {
            _container = container;
        }

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_container.GetAllMyRequests());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            return null;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _container.DeleteRequest(id);

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Request request)
        {

            _container.SaveScheduleRequest(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Request request)
        {
            return Ok();
        }

    }
}