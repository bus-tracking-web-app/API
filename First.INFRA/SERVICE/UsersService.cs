using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using System.Collections.Generic;

namespace First.INFRA.SERVICE
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public void CreateUser(User user)
        {
            _usersRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            _usersRepository.DeleteUser(id);
        }

        public List<User> GetAllCourse()
        {
            return _usersRepository.GetAllCourse();
        }

        public User GetByName(string name)
        {
           return _usersRepository.GetByName(name);
        }

        public User GetUserById(int id)
        {
            return _usersRepository.GetUserById(id);
        }

        public void UpdateUser(User user)
        {
            _usersRepository.UpdateUser(user);
        }
    }
}
