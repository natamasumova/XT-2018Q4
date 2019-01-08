using Epam.Task6.Entities;
using System;
using System.Collections.Generic;

namespace Epam.Task6.LogicContracts
{
    public interface ILogic
    {
        IEnumerable<User> GetAllUsers();
        bool AddUser(string userName, DateTime userDateOfBirth);
        bool RemoveUser(int id);

        bool Award(int awardid, int userid);
        IEnumerable<Award> GetAllAwards();
        bool AddAward(string awardTitle);
        bool RemoveAward(int id);
    }
}
