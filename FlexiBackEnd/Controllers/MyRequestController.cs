using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace FlexiBackEnd.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class MyRequestController : Controller
    {
        private readonly FlexiDbContext _flexi;
        public MyRequestController(FlexiDbContext flexi)
        {
            _flexi = flexi;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<Request> query = _flexi.Requests;
            query.OrderByDescending(c => c.requestId);
            Request[] requests = query.ToArray();
            return Ok(requests);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int Requestid)
        {
            IQueryable<Request> query = _flexi.Requests;

            return null;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IQueryable<Request> query = _flexi.Requests;
            Request request = query.First(
                r => r.requestId == id
                );
            _flexi.Remove(request);
            _flexi.SaveChanges();
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(Request request)
        {
            _flexi.Add(request);
            _flexi.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public void Put(Request request)
        {
            //if()
        }

    }
}