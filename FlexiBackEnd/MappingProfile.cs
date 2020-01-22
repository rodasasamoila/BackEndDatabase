

using AutoMapper;
using BusinessLayer.ScheduleRequest.Commands;
using FlexiBackEnd.Models;

namespace BusinessLayer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddScheduleRequestModel, AddScheduleRequestCommand>();
        }
    }
}
