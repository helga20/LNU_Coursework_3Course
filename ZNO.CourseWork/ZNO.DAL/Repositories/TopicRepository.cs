using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNO.DAL.Models;
using ZNO.DAL.Repositories.Interface;

namespace ZNO.DAL.Repositories
{
    public class TopicRepository : BaseRepository, ITopicRepository
    {
        public TopicRepository(DBContext context) : base(context) { }

        public IEnumerable<Topic> GetAllTopics()
        {
            var topics = new List<Topic>();
            var query = "SELECT general_info.topic_of_page, general_info.ID, paragraph.info, paragraph.definition FROM general_info INNER JOIN paragraph ON general_info.ID = paragraph.ID";

            using (var reader = _context.GetReaderNonAsync(query))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        topics.Add(new Topic(reader));
                    }
                }
            }
            return topics;
        }
    }
}
