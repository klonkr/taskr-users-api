using System.Collections.Generic;
using System.Linq;
using taskr_users_api.Models;

namespace taskr_users_api
{
    public class InMemoryRepository : IRepository
    {
        public static List<User> Users => new List<User>();
        public void Create(User user)
        {
            Users.Add(user);
        }

        public void Delete(int userId)
        {
            throw new System.NotImplementedException();
        }

        public User[] Read(int userId = 0)
        {
            if (userId != 0)
            {
                return Users.Where(u => u.UserId == userId).ToArray();
            }

            return Users.ToArray();
        }

        public void Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}