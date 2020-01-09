using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
namespace FlexiBackEnd.Controllers
{

    [Route("api/{controller}")]
    [ApiController]
    public class MyRequestController : Controller
    {

        private Guid _controllerId;
        public MyRequestController()
        {

            _controllerId = Guid.NewGuid();
        }

        [HttpGet]
        public IActionResult Get()
        {
           
            return Ok(RequestContainer.Instance.GetRequests());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Requestid)
        {
            return null;
        }

        [HttpDelete]
        public IActionResult Delete(Request request)
        {

           
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