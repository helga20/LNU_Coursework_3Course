using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNO.DAL.Models
{
    public class TopicDto
    {
        public string? NameOfTopic { get; set; }
        public int ID { get; set; }
        public string? Info { get; set; }
        public string? Definition { get; set; }
    }
}
