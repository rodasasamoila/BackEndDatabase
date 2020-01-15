using System.Collections.Generic;
using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using PersistanceLayer;

namespace FlexiBackEnd.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class MyRequestForReviewController : Controller
    {
        private readonly IContainer _container;
        public MyRequestForReviewController(IContainer container)
        {
            _container = container;
        }
        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_container.GetRequestsForReview());
        }

        [HttpGet("{id}")]
        public IActionResult GetById()
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(RequestForReview RequestForReview )
        {
            List<RequestForReview> list = new List<RequestForReview>();
            list.Add(RequestForReview);
            return Ok(list);
        }

        [HttpPut]
        public IActionResult Put(RequestForReview RequestForReview)
        {
            return Ok();
        }
    }

}