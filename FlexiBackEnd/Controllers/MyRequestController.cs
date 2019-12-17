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
        public  Request[] Get()
        {
            IQueryable<Request> query = _flexi.Requests;
            query.OrderByDescending(c => c.requestId);
            Request[] requests = query.ToArray();

            return requests ;
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
        public void Post(Request request)
        {
            _flexi.Add(request);
            _flexi.SaveChanges();
        }

    }
}