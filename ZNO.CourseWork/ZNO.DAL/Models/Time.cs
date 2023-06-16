using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNO.DAL.Models
{
    public class Time
    {
        public int ID { get; set; }
        public TimeSpan DataTime { get; set; }

        public Time() { }

        public Time(DbDataReader reader)
        {
            ID = !reader.IsDBNull(0) ? reader.GetInt32(reader.GetOrdinal("ID")) : 0;
            DataTime = !reader.IsDBNull(1) ? Convert.ToDateTime(reader.GetString(reader.GetOrdinal("Time"))).TimeOfDay : TimeSpan.Zero;
        }
    }
}
