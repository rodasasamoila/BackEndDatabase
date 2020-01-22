using AutoMapper;
using BusinessLayer;
using BusinessLayer.ScheduleRequest.Commands;
using FlexiBackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlexiBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleRequestController : ControllerBase
    {
        private readonly IScheduleRequestAdder _scheduleRequestAdder;
        private readonly IMapper _mapper;

        public ScheduleRequestController(IScheduleRequestAdder scheduleRequestAdder, IMapper mapper)
        {
            _scheduleRequestAdder = scheduleRequestAdder;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(AddScheduleRequestModel request)
        {
            _scheduleRequestAdder.Add(_mapper.Map<AddScheduleRequestCommand>(request));
            return Ok();
        }
    }
}