using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNO.DAL.Models;
using ZNO.DAL.Repositories.Interface;

namespace ZNO.DAL.Repositories
{
    public class TimeRepository :BaseRepository, ITimeRepository
    {
        public TimeRepository(DBContext context) : base(context) { }

        public IEnumerable<Time> GetAllTimes()
        {
            var times = new List<Time>();
            var query = "SELECT * FROM time_in_program";

            using (var reader = _context.GetReaderNonAsync(query))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        times.Add(new Time(reader));
                    }
                }
            }
            return times;
        }

        public Time GetLastTime()
        {
            var time = new Time();
            var query = "SELECT * FROM time_in_program WHERE ID=( SELECT max(ID) FROM time_in_program )";

            using (var reader = _context.GetReaderNonAsync(query))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        time = new Time(reader);
                    }
                }
            }
            return time;
        }

        public void SetCurrentTime(string time)
        {
            var query = $"INSERT INTO time_in_program (Time) VALUES (\'{time.Substring(0, 8)}\')";

            _context.ExecuteNonQuery(query);
        }
    }
}
