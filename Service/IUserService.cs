using Enitity;

namespace Service
{
    public interface IUserService
    {
        User Get(int id);
        User Post(LoginUser user);
        User Post(User user);
        void Put(int id, User user);
    }
}