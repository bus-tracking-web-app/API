using First.CORE.DATA;

namespace First.CORE.SERVICE
{
    public interface IJWTService
    {
        string Auth(User user);
    }
}
