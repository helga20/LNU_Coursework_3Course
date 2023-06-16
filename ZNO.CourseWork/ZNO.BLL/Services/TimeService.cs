using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNO.BLL.Models;
using ZNO.BLL.Services.Interface;
using ZNO.DAL.Interface;
using ZNO.DAL.Models;

namespace ZNO.BLL.Services
{
    public class TimeService : BaseService, ITimeService
    {
        public TimeService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public string GetSumAllTimes()
        {
            string res = "";
            var SumTime = new TimeSpan();
            var times = _unitOfWork.Time.GetAllTimes();
            if(times != null)
            {
                if(times.Count() > 0)
                {
                    foreach(var time in times)
                    {
                        SumTime += time.DataTime;
                    }
                }
            }

            res = SumTime.ToString();

            return res;
        }

        public TimeDto GetLastTime()
        {
            var time = _unitOfWork.Time.GetLastTime();

            return _mapper.Map<TimeDto>(time);
        }

        public void SetCurrentTime(string time)
        {
             _unitOfWork.Time.SetCurrentTime(time);
        }

    }
}
