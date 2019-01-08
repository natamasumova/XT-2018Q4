using Epam.Task6.Entities;
using System.Collections.Generic;

namespace Epam.Task6.DalContracts
{
    public interface ICommonDao
    {
        bool Award(int awardid, int userid);
        void AddAward(Award award);
        bool RemoveAward(int id);
        IEnumerable<Award> GetAllAwards();

        void AddUser(User user);
        bool RemoveUser(int id);
        IEnumerable<User> GetAllUsers();
    }
}
