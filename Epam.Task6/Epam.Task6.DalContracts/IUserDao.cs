using Epam.Task6.Entities;
using System.Collections.Generic;

namespace Epam.Task6.DalContracts
{
    public interface IUserDao
    {
        void AddUser(User user);
        bool RemoveUser(int id);
        IEnumerable<User> GetAllUsers();
    }
}
