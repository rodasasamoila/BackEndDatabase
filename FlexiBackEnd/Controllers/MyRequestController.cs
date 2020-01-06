using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
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
            List<Request> requests = new List<Request>();
            Request request = new Request{ Accepted = true,CreationDate= new DateTime(),DeniedReason="",EndHour=18,StartHour=9,ExceptionDate
            =new DateTime(),RequestType="Schedule"};
            Request request1 = new Request
            {
                Accepted = false,
                CreationDate = new DateTime(),
                DeniedReason = "",
                EndHour = 18,
                StartHour = 9,
                ExceptionDate
           = new DateTime(),
                RequestType = "Schedule"
            };
            Request request3 = new Request
            {
                Accepted = null,
                CreationDate = new DateTime(),
                DeniedReason = "",
                EndHour = 18,
                StartHour = 9,
                ExceptionDate
        = new DateTime(),
                RequestType = "Schedule"
            };
            Request request4 = new Request
            {
                Accepted = true,
                CreationDate = new DateTime(),
                DeniedReason = "",
                EndHour = 18,
                StartHour = 9,
                ExceptionDate
          = new DateTime(),
                RequestType = "ExceptionFromSchedule"
            };
            Request request5 = new Request
            {
                Accepted = false,
                CreationDate = new DateTime(),
                DeniedReason = "",
                EndHour = 18,
                StartHour = 9,
                ExceptionDate
          = new DateTime(),
                RequestType = "ExceptionFromSchedule"
            };
            Request request6 = new Request
            {
                Accepted = null,
                CreationDate = new DateTime(),
                DeniedReason = "",
                EndHour = 18,
                StartHour = 9,
                ExceptionDate
          = new DateTime(),
                RequestType = "ExceptionFromSchedule"
            };
           
            requests.Add(request);
            requests.Add(request1);
            requests.Add(request3);
            requests.Add(request4);
            requests.Add(request5);
            requests.Add(request6);
            //  IQueryable<Request> query = _flexi.Requests;
            //   query.OrderByDescending(c => c.RequestId);
            //  Request[] requests = query.ToArray();
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
                r => r.RequestId == id
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