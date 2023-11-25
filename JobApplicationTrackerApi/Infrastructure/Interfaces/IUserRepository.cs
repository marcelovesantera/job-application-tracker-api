using JobApplicationTrackerApi.Domain;
using JobApplicationTrackerApi.Presentation.Models;

namespace JobApplicationTrackerApi.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int userId);
        int AddUser(UserInputModel user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
