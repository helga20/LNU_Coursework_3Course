using AutoMapper;
using ZNO.BLL.Models;
using ZNO.DAL.Models;
using ZNO.Front.Models;

namespace ZNO.Front.Map
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ZmistModel, ZmistDto>();
            CreateMap<ZmistDto, ZmistModel>();

            CreateMap<TopicModel, TopicDto>();
            CreateMap<TopicDto, TopicModel>();

            CreateMap<TimeModel, TimeDto>();
            CreateMap<TimeDto, TimeModel>();
        }
    }
}
