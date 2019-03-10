using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SmartUniServerless.Models;

namespace SmartUniServerless.Helpers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<User, UserTransferObject>();
            CreateMap<UserTransferObject, User>();
            CreateMap<Event, EventTransferObject>();
            CreateMap<EventTransferObject, Event>();

        }
    }
}
