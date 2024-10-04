using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;

namespace HOTELMANAGEMENTSYSTEM_OOP.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Authenticate(string email, string passwordHash)
        {
            return _userRepository.GetUserByEmailAndPassword(email, passwordHash);
        }
    }
}
