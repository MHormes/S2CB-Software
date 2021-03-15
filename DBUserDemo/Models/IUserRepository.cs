using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsAndInterfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// gets a list of all users in the persistence
        /// </summary>
        /// <returns></returns>
        List<User> GetAllUsers();
        /// <summary>
        /// Edits the user if present, and returns true, if not present, returns false
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        bool EditUser(User u);
        /// <summary>
        /// Removes the user if present, and returns true, if not present, returns false
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        bool RemoveUser(User u);
        /// <summary>
        /// Adds a new user to the data storage
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        User AddUser(User u);

        /// <summary>
        /// gets the user corresponding the name
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        User GetUserByName(string unName);
    }
}
