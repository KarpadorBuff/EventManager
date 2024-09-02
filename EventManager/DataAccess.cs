using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace EventManager
{
    public class DataAccess
    {
        GUI inst;
        public DataAccess(GUI instance)
        {
            inst = instance;
        }




        private readonly string databasename = "EventDB";
        public List<Benutzer> GetUserInformationFromUsername(string username)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                return connection.Query<Benutzer>($"SELECT * FROM Benutzer WHERE username = '{username}'").ToList();
            }
        }
        public List<Benutzer> GetUserInformationFromEmail(string email)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                return connection.Query<Benutzer>($"SELECT * FROM Benutzer WHERE email = '{email}'").ToList();
            }
        }
        public List<Benutzer> GetUserInformationFromId(string id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                return connection.Query<Benutzer>($"SELECT * FROM Benutzer WHERE BenutzerID = '{id}'").ToList();
            }
        }

        public List<Benutzer> getAllUsers()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                return connection.Query<Benutzer>($"SELECT * FROM Benutzer").ToList();
            }
        }

        public List<Benutzer> getUserID(string username)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                return connection.Query<Benutzer>($"SELECT idBenutzer FROM Benutzer WHERE username = '{username}'").ToList();
            }
        }

        public List<Benutzer> CreateNewUser(string username, string email)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                return connection.Query<Benutzer>($"INSERT INTO Benutzer (username, email) Values ('{username}','{email}')").ToList();
            }
        }

        public List<Event> CreateNewEvent(string title, string location, DateTime date)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                return connection.Query<Event>($"INSERT INTO TBEvents (eventname, eventlocation, eventdate) Values ('{title}','{location}', '{date}')").ToList();
            }
        }

        public List<Benutzer> SetUserInformation(string username, string email, int userID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                return connection.Query<Benutzer>($"UPDATE Benutzer SET username = '{username}', email = '{email}' WHERE BenutzerID = '{userID}'").ToList();
            }
        }
        public string DeleteUser(int userID)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal(databasename)))
            {
                connection.Query<Benutzer>($"DELETE FROM Benutzer WHERE BenutzerID = '{userID}'").ToList();
                return "User Deleted";
            }
        }
    }
}