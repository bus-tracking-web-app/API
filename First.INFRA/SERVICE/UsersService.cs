using First.CORE.DATA;
using First.CORE.DTO;
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

        public List<User> GetAllUsers()
        {
            return _usersRepository.GetAllUsers();

        }

        public List<UserRole> GetAllUsersWithRole()
        {
            return _usersRepository.GetAllUsersWithRole();
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

        public int ParentCount()
        {
            return _usersRepository.ParentCount();
        }

        public int DriverCount()
        {
            return _usersRepository.DriverCount();
        }

        public int TeacherCount()
        {
            return _usersRepository.TeacherCount();
        }

    }
}
