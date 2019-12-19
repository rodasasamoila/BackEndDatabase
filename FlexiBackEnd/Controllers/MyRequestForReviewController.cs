using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlexiBackEnd.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FlexiBackEnd.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class MyRequestForReviewController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            RequestForReview requestForReview = new RequestForReview { Id = 2, RequestType = "Schedule" };
            List<RequestForReview> list = new List<RequestForReview>();
            list.Add(requestForReview);
            return Ok(list);
        }
        [HttpGet("{id}")]
        public IActionResult GetById()
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(RequestForReview RequestForReview )
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(RequestForReview RequestForReview)
        {
            return Ok();
        }
    }

}