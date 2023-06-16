using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNO.DAL.Models;

namespace ZNO.DAL.Repositories.Interface
{
    public interface ITopicRepository
    {
        IEnumerable<Topic> GetAllTopics();
    }
}
