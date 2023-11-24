using JobApplicationTrackerApi.Domain;

namespace JobApplicationTrackerApi.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int userId);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
