using Epam.Task6.Entities;
using System.Collections.Generic;

namespace Epam.Task6.DalContracts
{
    public interface IAwardDao
    {
        bool Award(int awardid, int userid);
        void AddAward(Award award);
        bool RemoveAward(int id);
        IEnumerable<Award> GetAllAwards();
    }
}
