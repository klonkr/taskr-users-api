using taskr_users_api.Models;

namespace taskr_users_api
{
    public interface IRepository{
        void Create(User user);
        User[] Read(int userId);
        void Update(User user);
        void Delete(int userId);
    }
}
