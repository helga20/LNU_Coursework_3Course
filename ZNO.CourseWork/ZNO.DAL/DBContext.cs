using System.Data.SQLite;
using System.Data.Common;

namespace ZNO.DAL
{
    public class DBContext : IDisposable
    {
        private SQLiteConnection? _connection;
        private SQLiteCommand? _command;
        private SQLiteDataReader? _dataReader;
        private bool _disposed = false;

        public DBContext(string connectionString)
        {
            string dataDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
            if(dataDirectoryPath.Contains("Debug"))
            {
                dataDirectoryPath = dataDirectoryPath.Substring(0, dataDirectoryPath.Length - 32);
                dataDirectoryPath += ".DAL\\DataBase\\";
            }
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
            _connection = new SQLiteConnection(connectionString);
            _connection.Open();
        }

        public async Task<DbDataReader> GetReader(string query)
        {
            _command = new SQLiteCommand(query, _connection);
            _dataReader = (SQLiteDataReader?)await _command.ExecuteReaderAsync();

            return _dataReader!;
        }

        public DbDataReader GetReaderNonAsync(string query)
        {
            _command = new SQLiteCommand(query, _connection);
            _dataReader = _command.ExecuteReader();

            return _dataReader;
        }

        public async Task<int> ExecuteQueryAsync(string query)
        {
            _command = new SQLiteCommand(query, _connection);

            return Convert.ToInt32(await _command.ExecuteScalarAsync());
        }

        public void ExecuteNonQuery(string query)
        {
            _command = new SQLiteCommand(query, _connection);

             _command.ExecuteNonQuery();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _connection!.Close();
                    _connection.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}


