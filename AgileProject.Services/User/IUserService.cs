using AgileProject.Models.User;

namespace AgileProject.Services.User
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(UserRegister model);
        Task<UserDetails> GetUserByIdAsync(int userId);
    }
}