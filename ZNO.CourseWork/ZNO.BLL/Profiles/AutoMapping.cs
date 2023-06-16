using AutoMapper;
using ZNO.BLL.Models;
using ZNO.DAL.Models;
using System.Security.Principal;

namespace ZNO.BLL.Profiles
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Zmist, ZmistDto>();
            CreateMap<ZmistDto, Zmist>();

            CreateMap<Topic, TopicDto>();
            CreateMap<TopicDto, Topic>();

            CreateMap<Time, TimeDto>();
            CreateMap<TimeDto, Time>();
        }
    }
}
