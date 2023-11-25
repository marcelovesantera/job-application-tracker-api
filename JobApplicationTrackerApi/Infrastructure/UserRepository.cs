using JobApplicationTrackerApi.Domain;
using JobApplicationTrackerApi.Infrastructure.Interfaces;
using JobApplicationTrackerApi.Persistence;
using JobApplicationTrackerApi.Presentation.Models;
using Microsoft.EntityFrameworkCore;

namespace NomeDoSeuProjeto.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public int AddUser(UserInputModel UserInputModel)
        {
            var newUser = new User(
                UserInputModel.Name,
                UserInputModel.Lastname,
                UserInputModel.Email,
                UserInputModel.Password
                );

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return newUser.Id;
        }

        public void UpdateUser(User UserUpdateModel)
        {
            _context.Entry(UserUpdateModel).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                user.Deactivate();
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
