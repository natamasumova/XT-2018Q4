using System;
using System.Text.RegularExpressions;

namespace Epam.Task2._3_2._5
{
    public class User
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Midname { get; set; }
        protected DateTime Birthday { get; set; }
        protected int Age { get; set; }

        public User(string surname, string name, DateTime birthday, string midname = null)
        {
            Surname = surname;
            Name = name;
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

        public static bool IsValid(string item)
        {
            Regex regex = new Regex(@"[A-ZА-Я][a-zа-я]+[' '|'-']*[A-ZА-Яa-zа-я]*");
            return regex.IsMatch(item);
        }

        public override string ToString()
        {
            if (Midname != null)
            {
                return $"Name: {this.Name}{Environment.NewLine}Midname: {this.Midname}{Environment.NewLine}" +
                       $"Surname: {this.Surname}{Environment.NewLine}Birthday: {this.Birthday.ToString("D")}{Environment.NewLine}" +
                       $"Age: {this.Age}";
            }
            else
            {
                return $"Name: {this.Name}{Environment.NewLine}Surname: {this.Surname}{Environment.NewLine}" +
                       $"Birthday: {this.Birthday.ToString("D")}{Environment.NewLine}Age: {this.Age}";
            }
        }
    }
}
