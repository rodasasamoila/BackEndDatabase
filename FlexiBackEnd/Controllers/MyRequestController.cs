using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
namespace FlexiBackEnd.Controllers
{

    [Route("api/{controller}")]
    [ApiController]
    public class MyRequestController : Controller
    {

        public MyRequestController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
           
            return Ok(RequestContainer.Instance.GetRequests());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            return null;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            RequestContainer.Instance.DeleteRequest(id);
           
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Request request)
        {
            RequestContainer.Instance.AddRequest(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Request request)
        {
            return Ok();
        }

    }
}