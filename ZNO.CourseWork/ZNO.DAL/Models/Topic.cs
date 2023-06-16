using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNO.DAL.Models
{
    public class Topic
    {
        public string NameOfTopic { get; set; }
        public int ID { get; set; }
        public string Info { get; set; }
        public string Definition { get; set; }

        public Topic()
        {}

        public Topic(DbDataReader reader)
        {
                NameOfTopic = !reader.IsDBNull(0) ? reader.GetString(reader.GetOrdinal("topic_of_page")) : "";
                ID = !reader.IsDBNull(1) ? reader.GetInt32(reader.GetOrdinal("ID")) : 0;
                Info = !reader.IsDBNull(2) ? reader.GetString(reader.GetOrdinal("info")) : "";
                Definition = !reader.IsDBNull(3) ? reader.GetString(reader.GetOrdinal("definition")) : "";
        }
    }
}
