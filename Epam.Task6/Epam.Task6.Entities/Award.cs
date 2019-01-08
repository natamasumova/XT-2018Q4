using System.Collections.Generic;

namespace Epam.Task6.Entities
{
    public class Award
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<User> Users { get; set; }
    }
}
