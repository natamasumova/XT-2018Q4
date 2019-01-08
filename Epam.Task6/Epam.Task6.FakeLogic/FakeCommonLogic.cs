using Epam.Task6.Entities;
using Epam.Task6.LogicContracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam.Task6.FakeLogic
{
    public class FakeCommonLogic : ILogic
    {
        private readonly ICollection<User> users;
        private readonly ICollection<Award> awards;
        private int maxUserId;
        private int maxAwardId;

        public FakeCommonLogic()
        {
            this.users = new HashSet<User>();
            this.awards = new HashSet<Award>();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.users.Select(n => n);
        }

        public bool AddUser(string userName, DateTime userDateOfBirth)
        {
            User user = new User
            {
                Id = ++this.maxUserId,
                Name = userName,
                DateOfBirth = userDateOfBirth,
                Age = DateTime.Now.Year - userDateOfBirth.Year,
                Awards = new List<Award>()
            };
            this.users.Add(user);
            return true;
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
        
        public IEnumerable<Award> GetAllAwards()
        {
            return this.awards.Select(n => n);
        }

        public bool AddAward(string awardTitle)
        {
            Award award = new Award
            {
                Id = ++this.maxAwardId,
                Title = awardTitle,
                Users = new List<User>()
            };
            this.awards.Add(award);
            return true;
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

        public bool Award(int awardid, int userid)
        {
            Award award = this.awards.FirstOrDefault(n => n.Id == awardid);
            User user = this.users.FirstOrDefault(n => n.Id == userid); //FROM UserLOGIC
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
    }
}
