using System;
using DataAccessLayer;
using ModelsAndInterfaces;

namespace Services
{
    public class UserService
    {
        private IUserRepository userRepo;

        public UserService()
        {
            // choose the database
            userRepo = new UserMySQLContext("Server = studmysql01.fhict.local; Uid = dbi872209; Database = dbi872209; Pwd = 00000000;");
        }

        public User AddUser(User u)
        {
            return userRepo.AddUser(u);
        }

        public User GetUserByName(string name)
        {
            return userRepo.GetUserByName(name);
        }

    }
}
