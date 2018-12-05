using System;

namespace Epam.Task2._3_2._5
{
    public class Employee : User
    {
        private string Post { get; set; }
        private int WorkExperience { get; set; }
        private Employee(string surname,
                         string name,
                         DateTime birthday,
                         string post,
                         int workexperience,
                         string midname = null)
                : base(surname, name, birthday, midname = null)
        {
            Surname = surname;
            Name = name;
            Post = post;
            WorkExperience = workexperience;
            if (birthday >= DateTime.Now)
            {
                throw new Exception("Birthday is not valid");
            }
            else
            {
                Birthday = birthday;
                Age = DateTime.Now.Year - birthday.Year;
            }
            if (midname != null)
            {
                Midname = midname;
            }
        }

        public override string ToString()
        {
            if (Midname != null)
            {
                return $"Name: {this.Name}{Environment.NewLine}Midname: {this.Midname}{Environment.NewLine}" +
                       $"Surname: {this.Surname}{Environment.NewLine}Birthday: {this.Birthday.ToString("D")}{Environment.NewLine}" +
                       $"Age: {this.Age}{Environment.NewLine}Post: {this.Post}{Environment.NewLine}" +
                       $"Work experience: {this.WorkExperience}";
            }
            else
            {
                return $"Name: {this.Name}{Environment.NewLine}Surname: {this.Surname}{Environment.NewLine}" +
                       $"Birthday: {this.Birthday.ToString("D")}{Environment.NewLine}Age: {this.Age}" +
                       $"Post: {this.Post}{Environment.NewLine}Work experience: {this.WorkExperience}";
            }
        }
    }
}
