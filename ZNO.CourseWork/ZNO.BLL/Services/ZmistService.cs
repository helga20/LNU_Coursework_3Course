using AutoMapper;
using ZNO.BLL.Models;
using ZNO.BLL.Services.Interface;
using ZNO.DAL.Interface;
using ZNO.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ZNO.BLL.Services
{
    public class ZmistService :BaseService, IZmistService
    {
        public ZmistService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<ZmistDto>GetAllZmist()
        {
            var zmist = await _unitOfWork.Zmist.GetAllZmist();

            return _mapper.Map<ZmistDto>(zmist);
        }
    }
}
