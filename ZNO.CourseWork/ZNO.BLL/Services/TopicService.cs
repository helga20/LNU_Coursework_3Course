using AutoMapper;
using ZNO.BLL.Models;
using ZNO.BLL.Services.Interface;
using ZNO.DAL.Interface;
using ZNO.DAL.Models;

namespace ZNO.BLL.Services
{
    public class TopicService : BaseService, ITopicService
    {
        public TopicService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public IEnumerable<TopicDto> GetAllTopics()
        {
            var topics = _unitOfWork.Topic.GetAllTopics();

            return _mapper.Map<IEnumerable<TopicDto>>(topics);
        }
    }
}
