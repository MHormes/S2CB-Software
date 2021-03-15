using ModelsAndInterfaces;
using MySql.Data;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class UserMySQLContext : IUserRepository
    {
        public string ConnString { get; private set; }

        public UserMySQLContext(string connString)
        {
            ConnString = connString;
        }

        public UserMySQLContext()
        {
            ConnString = ("server=studmysql01.fhict.local;database=dbi872209;uid=dbi872209;password=00000000;"); ;
        }

        public User AddUser(User u)
        {
            MySqlConnection con = new MySqlConnection(ConnString);
            con.Open();

            var query = "INSERT INTO user(username, email) VALUES(@username, @email)";
            var cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@username", u.Name);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            //  get the last inserted ID
            query = "SELECT LAST_INSERT_ID();";
            cmd = new MySqlCommand(query,con);
            var result = cmd.ExecuteScalar(); 
            u = new User(Convert.ToInt32(result),u.Name,u.Email);


            return u;
        }

        public User GetUserByName(string userName)
        {

            MySqlConnection con = new MySqlConnection(ConnString);
            con.Open();

            var query = "SELECT * FROM user WHERE username = @name";
            var cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", userName);
            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return new User(reader.GetInt32(0),reader.GetString(1),reader.GetString(2));
                }
            }

            return null;
        }

        public bool EditUser(User u)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool RemoveUser(User u)
        {
            throw new NotImplementedException();
        }
    }
}
