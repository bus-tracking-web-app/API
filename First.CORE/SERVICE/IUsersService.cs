using First.CORE.DATA;
using System.Collections.Generic;

namespace First.CORE.SERVICE
{
    public interface IUsersService
    {
        List<User> GetAllCourse();
        void CreateUser(User user);
        void DeleteUser(int id);
        public void UpdateUser(User user);
        User GetUserById(int id);

    }
}
