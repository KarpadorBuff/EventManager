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
                return connection.Query<Benutzer>($"SELECT * FROM Benutzer WHERE username = '{username}'").ToList();
            }
        }

        public List<Benutzer> getidBenutzer(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EventDB")))
            {
                return connection.Query<Benutzer>($"SELECT idBenutzer FROM Benutzer WHERE username = '{username}'").ToList();
            }
        }

        public List<Benutzer> createBenutzer()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EventDB")))
            {
                return connection.Query<Benutzer>($"").ToList();
            }
        }
    }
}