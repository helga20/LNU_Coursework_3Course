using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNO.BLL.Models;

namespace ZNO.BLL.Services.Interface
{
    public interface ITimeService
    {
        string GetSumAllTimes();
        TimeDto GetLastTime();
        void SetCurrentTime(string time);
    }
}
