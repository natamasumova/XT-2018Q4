using System;
using System.Collections.Generic;

namespace Epam.Task6.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public List<Award> Awards { get; set; } 
    }
}
