using taskr_users_api.Models;

namespace taskr_users_api
{
    public class UserRepository : IRepository
    {
        public void Create(User user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int userId)
        {
            throw new System.NotImplementedException();
        }

        public User[] Read(int userId = 0)
        {
            if(userId == 0){
                // return all
            } else {
                // return specific user
            }

            return  null;
        }

        public void Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}