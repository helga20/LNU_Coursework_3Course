using ZNO.DAL.Models;
using ZNO.DAL.Repositories.Interface;

namespace ZNO.DAL.Repositories
{
    public class ZmistRepository : BaseRepository, IZmist
    {
        public ZmistRepository(DBContext context) : base(context) { }

        public async Task<Zmist> GetAllZmist()
        {
            var zm = new Zmist();
            var query = "SELECT general_info.ID AS general_id, \r\ntype_math.Name AS MathName, \r\ntype_pages.TypeName AS TypePageName,  \r\ngeneral_info.num_page AS NumPage,\r\ngeneral_info.topic_of_page AS TopicOfPage, \r\ngeneral_info.full_info AS FullInfo\r\nFROM general_info  \r\nINNER JOIN type_math ON general_info.id_type_math = type_math.ID  \r\nINNER JOIN type_pages ON general_info.id_type_page = type_pages.ID";

            var reader = await _context.GetReader(query);
            if (reader.HasRows)
            {
                zm = new Zmist(reader);
            }
            return zm;
        }

        //public async Task Create(Account account)
        //{
        //    var query = string.Format("INSERT INTO pos.account(code_account, type_account, sum_account, transit_sum, date_change, code_user, version_row)" +
        //        "VALUES({0}, {1}, {2}, {3}, '{4}', {5}, {6}); ",
        //        account.Code,                    // {0}
        //        account.Type,                    // {1}
        //        account.Sum,                     // {2}
        //        account.TransitSum,              // {3}
        //        account.DateChange,              // {4}
        //        account.UserCode,                // {5}
        //        account.Version                  // {6}
        //    );

        //    await _context.ExecuteNonQueryAsync(query);
        //}

        //public async Task Delete(int id)
        //{
        //    var query = "DELETE FROM pos.account " +
        //        $" WHERE code_account = {id}";

        //    await _context.ExecuteNonQueryAsync(query);
        //}
    }
}

