using AgileProject.Data;
using AgileProject.Data.Entities;
using AgileProject.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AgileProject.Services.User
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> RegisterUserAsync(UserRegister model)
        {
            if (await GetUserByEmailAsync(model.Email) != null || await GetUserByUsernameAsync(model.Username) != null)
            {
                return false;
            }
            var entity = new UserEntity
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            var passwordHasher = new PasswordHasher<UserEntity>();
            entity.Password = passwordHasher.HashPassword(entity, model.Password);

            _context.Users.Add(entity);
            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }
        public async Task<UserDetail> GetUserByIdAsync(int userId)
        {
            var entity = await _context.Users.FindAsync(userId);
            if (entity is null)
            {
                return null;
            }
            var userDetail = new UserDetail
            {
                UserId = entity.UserId,
                Username = entity.Username,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
            return userDetail;
        }
        // Helper Methods
        private async Task<UserEntity> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Email.ToLower() == email.ToLower());
        }
        private async Task<UserEntity> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Username.ToLower() == username.ToLower());
        }
    }
}