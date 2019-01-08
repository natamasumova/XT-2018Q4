using Epam.Task6.Entities;
using Epam.Task6.DalContracts;
using Epam.Task6.LogicContracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam.Task6.Logic
{
    public class CommonLogic : ILogic
    {
        private readonly ICommonDao userDao;
        private readonly ICommonDao awardDao;

        public CommonLogic()
        {
            this.userDao = new TextFilesDal.CommonDao();
            this.awardDao = new TextFilesDal.CommonDao();
        }

        public bool AddAward(string awardTitle)
        {
            if (awardTitle == null)
            {
                throw new Exception("The award cannot be noname.");
            }
            Award award = new Award
            {
                Title = awardTitle
            };

            try
            {
                awardDao.AddAward(award);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddUser(string userName, DateTime userDateOfBirth)
        {
            if (userName == null)
            {
                throw new Exception("The user cannot be noname.");
            }
            if (userDateOfBirth >= DateTime.Now)
            {
                throw new Exception("The birthday of user cannot be later than the current date.");
            }
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan dif = DateTime.Now - userDateOfBirth;
            User user = new User
            {
                Name = userName,
                DateOfBirth = userDateOfBirth,
                Age = dif.Days / 365,
                Awards = new List<Award>()
            };

            try
            {
                userDao.AddUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Award(int awardid, int userid)
        {
            return awardDao.Award(awardid, userid);
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return awardDao.GetAllAwards().ToArray();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return userDao.GetAllUsers().ToArray();
        }

        public bool RemoveAward(int id)
        {
            return awardDao.RemoveAward(id);
        }

        public bool RemoveUser(int id)
        {
            return userDao.RemoveUser(id);
        }
    }
}
