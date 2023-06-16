using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNO.DAL.Models
{
    public class Zmist
    {
        public int GeneralId { get; set; }
        public string? MathName { get; set; }
        public string? TypePageName { get; set; }
        public int NumPage { get; set; }
        public string? TopicOfPage { get; set; }
        public string? FullInfo { get; set; }


        public Zmist() { }

        public Zmist(DbDataReader reader)
        {
            GeneralId = !reader.IsDBNull(0) ? reader.GetInt32(reader.GetOrdinal("general_id")) : 0;
            MathName = !reader.IsDBNull(1) ? reader.GetString(reader.GetOrdinal("MathName")) : "";
            TypePageName = !reader.IsDBNull(2) ? reader.GetString(reader.GetOrdinal("TypePageName")) : "";
            NumPage = !reader.IsDBNull(3) ? reader.GetInt32(reader.GetOrdinal("NumPage")) : 0;
            TopicOfPage = !reader.IsDBNull(4) ? reader.GetString(reader.GetOrdinal("TopicOfPage")) : "";
            FullInfo = !reader.IsDBNull(5) ? reader.GetString(reader.GetOrdinal("FullInfo")) : "";
        }
    }
}
