using Epam.Task6.DalContracts;
using Epam.Task6.Entities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;

namespace Epam.Task6.TextFilesDal
{
    public class CommonDao : ICommonDao
    {
        private const string usersFileName = "users.txt";
        private const string awardsFileName = "awards.txt";
        private const string maxUserIdFileName = "maxUserId.txt";
        private const string maxAwardIdFileName = "maxAwardId.txt";
        private const string dateFormat = "dd.MM.yyyy";

        private readonly string usersFilePath;
        private readonly string awardsFilePath;
        private readonly string maxUserIdFilePath;
        private readonly string maxAwardIdFilePath;
        private int maxUserId;
        private int maxAwardId;

        public CommonDao()
        {
            string folder = AppDomain.CurrentDomain.BaseDirectory;
            usersFilePath = Path.Combine(folder, usersFileName);
            awardsFilePath = Path.Combine(folder, awardsFileName);
            maxUserIdFilePath = Path.Combine(folder, maxUserIdFileName);
            maxAwardIdFilePath = Path.Combine(folder, maxAwardIdFileName);

            try
            {
                maxUserId = int.Parse(File.ReadAllText(Path.Combine(folder, maxUserIdFileName)));
                maxAwardId = int.Parse(File.ReadAllText(Path.Combine(folder, maxAwardIdFileName)));
            }
            catch
            {
                maxUserId = 0;
                maxAwardId = 0;
            }
        }
        public void AddUser(User user)
        {
            user.Id = ++maxUserId;
            File.WriteAllText(maxUserIdFilePath, maxUserId.ToString());
            File.AppendAllLines(usersFilePath, new[] { Serialize(user) });
        }

        private static string Serialize(User user)
        {
            StringBuilder userAwards = null;
            foreach (var a in user.Awards)
            {
                userAwards.Append(a.Id).Append('.').Append(a.Title).Append(';');
            }
            if (userAwards == null)
            {
                return $"{user.Id}|{user.Name}|{user.Age}|" +
                       $"{user.DateOfBirth.ToString("dd.MM.yyyy")}";
            }
            else
            {
                return $"{user.Id}|{user.Name}|{user.Age}|" +
                       $"{user.DateOfBirth.ToString("dd.MM.yyyy")}|{userAwards}";
            }
        }

        private static string Serialize(Award award)
        {
            return $"{award.Id}|{award.Title}";
        }

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return File.ReadAllLines(usersFilePath)
                    .Select(line =>
                    {
                        string[] parts = line.Split('|');
                        User user = new User
                        {
                            Id = int.Parse(parts[0]),
                            Name = parts[1],
                            Age = int.Parse(parts[2]),
                            DateOfBirth = DateTime.ParseExact(parts[3], dateFormat, CultureInfo.InvariantCulture),
                            Awards = new List<Award>()
                        };

                        if (parts[4] != null)
                        {
                            string[] awardsString = parts[4].Split(';');
                            for (int i = 0; i < awardsString.Length; i++)
                            {
                                string[] awardSplit = awardsString[i].Split('.');
                                user.Awards.Add(new Award
                                {
                                    Id = int.Parse(awardSplit[0]),
                                    Title = awardSplit[1]
                                }
                                );
                            }
                        }
                        return user;
                    });
            }
            catch
            {
                return Enumerable.Empty<User>();
            }
        }

        public bool RemoveUser(int id)
        {
            var users = GetAllUsers().ToList();
            var user = users.FirstOrDefault(n => n.Id == id);
            if (user == null)
            {
                return false;
            }
            users.Remove(user);
            File.WriteAllLines(usersFilePath, users.Select(Serialize));
            return true;
        }

        public bool Award(int awardid, int userid)
        {
            var users = GetAllUsers().ToList();
            var awards = GetAllAwards().ToList();
            foreach (var a in awards)
            {
                foreach (var u in users)
                {
                    if (a.Id == awardid && u.Id == userid)
                    {
                        u.Awards.Add(a);
                        File.WriteAllLines(usersFilePath, users.Select(Serialize));
                        return true;
                    }
                }
            }
            return false;
        }

        public void AddAward(Award award)
        {
            award.Id = ++maxAwardId;
            File.WriteAllText(maxAwardIdFilePath, maxAwardId.ToString());
            File.AppendAllLines(awardsFilePath, new[] { Serialize(award) });
        }

        public bool RemoveAward(int id)
        {
            var awards = GetAllAwards().ToList();
            var award = awards.FirstOrDefault(n => n.Id == id);
            if (award == null)
            {
                return false;
            }
            awards.Remove(award);
            File.WriteAllLines(awardsFilePath, awards.Select(Serialize));
            return true;
        }



        public IEnumerable<Award> GetAllAwards()
        {
            try
            {
                return File.ReadAllLines(awardsFilePath)
                    .Select(line =>
                    {
                        string[] parts = line.Split(new[] { '|' }, 2);
                        return new Award
                        {
                            Id = int.Parse(parts[0]),
                            Title = parts[1]
                        };
                    });
            }
            catch
            {
                return Enumerable.Empty<Award>();
            }
        }
    }
}
