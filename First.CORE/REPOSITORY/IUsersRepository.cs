using First.CORE.DATA;
using First.CORE.DTO;
using System.Collections.Generic;

namespace First.CORE.REPOSITORY
{
    public interface IUsersRepository
    {
        List<User> GetAllCourse();
        List<UserRole> GetAllUsersWithRole();
        void CreateUser(User user);
        void DeleteUser(int id);
        public void UpdateUser(User user);
        User GetUserById(int id);

        User GetByName(string name);
        int ParentCount();
        int DriverCount();
        int TeacherCount();



    }
}
