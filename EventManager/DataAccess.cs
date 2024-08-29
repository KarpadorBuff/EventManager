using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace EventManager
{
    public class DataAccess
    {
        public List<Benutzer> GetUsers(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EventDB")))
            {
                return connection.Query<Benutzer>($"SELECT * FROM Benutzer ").ToList();
            }
        }
    }
}