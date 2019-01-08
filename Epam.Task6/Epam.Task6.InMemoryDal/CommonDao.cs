using Epam.Task6.DalContracts;
using Epam.Task6.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Epam.Task6.InMemoryDal
{
    public class CommonDao : ICommonDao
    {
        private readonly ICollection<User> users;
        private readonly ICollection<Award> awards;
        private int maxUserId;
        private int maxAwardId;

        public CommonDao()
        {
            this.users = new HashSet<User>();
            this.awards = new HashSet<Award>();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.users.Select(n => n);
        }

        public void AddUser(User user)
        {
            user.Id = ++this.maxUserId;
            this.users.Add(user);
        }

        public bool RemoveUser(int id)
        {
            User user = this.users.FirstOrDefault(n => n.Id == id);
            if (user != null)
            {
                this.users.Remove(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Award(int awardid, int userid)
        {
            Award award = this.awards.FirstOrDefault(n => n.Id == awardid);
            User user = this.users.FirstOrDefault(n => n.Id == userid);
            foreach (var a in awards)
            {
                foreach (var u in users)
                {
                    if (a.Id == awardid && u.Id == userid)
                    {
                        u.Awards.Add(a);
                        return true;
                    }
                }
            }
            return false;
        }

        public void AddAward(Award award)
        {
            award.Id = ++this.maxAwardId;
            this.awards.Add(award);
        }

        public bool RemoveAward(int id)
        {
            Award award = this.awards.FirstOrDefault(n => n.Id == id);
            if (award != null)
            {
                this.awards.Remove(award);
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return this.awards.Select(n => n);
        }
    }
}
